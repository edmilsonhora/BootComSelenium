using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESH_MyBoot.AppWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Perfil { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
    }
}