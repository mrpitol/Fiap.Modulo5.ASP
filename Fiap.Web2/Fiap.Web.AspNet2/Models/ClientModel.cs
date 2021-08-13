using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet2.Models
{
    public class ClientModel
    {
        public int Clienteid { get; set; }
        public string Nome { get; set; }
        public string Email{ get; set; }
        public DateTime DataNascimento { get; set; }
        public string Observacao { get; set; }
    }
}
