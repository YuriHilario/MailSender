using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.Entities
{
    class JsonGov_Municipal
    {
        public int id { get; set; }
        public int versao { get; set; }
        public string situacao { get; set; }
        public string cnpj { get; set; }
        public string nomeEmpresarial { get; set; }
        public string nomeFantasia { get; set; }
        public string cnaeCodigo { get; set; }
        public string cnaeDescricao { get; set; }
        public string naturezaJuridicaCodigo { get; set; }
        public string naturezaJuridicaDescricao { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string populacao { get; set; }
        public string idh { get; set; }
        public object responsavel { get; set; }
        public Municipio municipio { get; set; }
        public object gruposDestinatarios { get; set; }
        public object anexos { get; set; }
        public object usuariosEntes { get; set; }
        public object fundos { get; set; }
        public object membrosConselhos { get; set; }

        public class Municipio
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string codigo { get; set; }
            public bool? capital { get; set; }
            public Uf uf { get; set; }
        }

        public class Uf
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string sigla { get; set; }
        }
    }
}
