//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiContatos.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Endereco
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Tipo { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
    }
}
