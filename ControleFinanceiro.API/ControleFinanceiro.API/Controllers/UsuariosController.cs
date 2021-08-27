using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL;
using ControleFinanceiro.DAL.Interfaces;
using Nancy.IO;
using System.IO;
using Microsoft.AspNetCore.Identity;
using ControleFinanceiro.API.ViewModels;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;


        public UsuariosController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(string id)
        {
            var usuario = await _usuarioRepositorio.PegarPeloId(id);

            if (usuario == null)
            {
                return NotFound();
            }

            AtualizarUsuarioViewlModel model = new AtualizarUsuarioViewlModel
            {
                id = usuario.Id,
                UserName = usuario.UserName,
                Email = usuario.Email,
                CPF = usuario.CPF,
                Profissao = usuario.Profissao,
                Foto = usuario.Foto
            };

            return model;
        }

        [HttpPost("SalvarFoto")]

        public async Task<ActionResult> SalvarFoto()
        {
            var foto = Request.Form.Files[0];
            byte[] b;

            using (var openReadStream = foto.OpenReadStream())
            {
                using (var memoryStream = new MemoryStream())
                {
                    await openReadStream.CopyToAsync(memoryStream);
                    b = memoryStream.ToArray();
                }
            }

            return Ok(new
            {
                foto = b
            });
        }

        [HttpPost("RegistrarUsuario")]
        public async Task<ActionResult> RegistrarUsuario(RegistroViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityResult usuarioCriado;
                string funcaoUsuario;

                Usuario usuario = new Usuario
                {
                    UserName = model.NomeUsuario,
                    Email = model.Email,
                    PasswordHash = model.Senha,
                    CPF = model.CPF,
                    Profissao = model.Profissao,
                    Foto = model.Foto

                };

                if (await _usuarioRepositorio.PegarQuantidadeUsuariosRegistrados() > 0)
                {
                    funcaoUsuario = "Usuario";
                }
                else
                {
                    funcaoUsuario = "Administrador";
                }

                usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                if (usuarioCriado.Succeeded)
                {
                    await _usuarioRepositorio.IncluirUsuarioEmFuncao(usuario, funcaoUsuario);
                    await _usuarioRepositorio.LogarUsuario(usuario, false);

                    return Ok(new
                    {
                        emailUsuarioLogado = usuario.Email,
                        usuarioId = usuario.Id
                    });
                }

                else
                {
                    return BadRequest(model);
                }

                return BadRequest(model);

            }

            [HttpPost("LogarUsuario")]

            public async Task<ActionResult> LogarUsuario(LoginViewModel model)
            {
                if (model == null)
                    return NotFound("Usuario e / ou senhas inválidos");
                Usuario usuario = await _usuarioRepositorio.PegaUsuarioPeloEmail(model.Email);

                if (usuario != null)
                {
                    PasswordHasher<Usuario> passwordHasher = new PasswordHasher<Usuario>();
                    if (passwordHasher.VerifyHashedPassword(usuario, usuario.PasswordHash, model.Senha) != PasswordVerificationResult.Failed)
                    {
                        var funcoesUsuario = await _usuarioRepositorio.PegarFuncoesUsuario(usuario);

                    }
                }
            }
        }

    }
}