using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRest01.Model {
    [Table("person")]
    public class Person {
        [Column("id")]
        public long Id { get; set; }
       
        [Column("first_name")]
        public string Nome { get; set; }
       
        [Column("last_name")]
        public string Sobrenome { get; set; }
       
        [Column("address")]
        public string Endereco { get; set; }

        [Column("gender")]
        public string Genero { get; set; }

    }
}