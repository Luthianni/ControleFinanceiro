﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.ViewModels
{
    public class AtualizarUsuarioViewMOdel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
        public byte[] Foto { get; set; }
    }
}
