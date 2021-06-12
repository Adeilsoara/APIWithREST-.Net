using APIRest01.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRest01.Model {
    public class BookVo {
        
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public DateTime LaunchDate { get; set; }

    }
}