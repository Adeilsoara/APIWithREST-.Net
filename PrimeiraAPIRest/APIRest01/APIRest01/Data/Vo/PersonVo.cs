using APIRest01.Hypermidia;
using APIRest01.Hypermidia.Abstract;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace APIRest01.Data.Vo {
    public class PersonVo : ISupportHypermidia {
       
        public long Id { get; set; }

        public string Nome { get; set; }
       
        public string Sobrenome { get; set; }
       
        public string Endereco { get; set; }

        public string Genero { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}