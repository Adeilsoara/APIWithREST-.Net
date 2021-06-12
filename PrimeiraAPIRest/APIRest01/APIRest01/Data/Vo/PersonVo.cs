using System.Text.Json.Serialization;

namespace APIRest01.Data.Vo {
    public class PersonVo {
        [JsonPropertyName("")]
        public long Id { get; set; }

        public string Nome { get; set; }
       
        public string Sobrenome { get; set; }
       
        public string Endereco { get; set; }

        public string Genero { get; set; }

    }
}