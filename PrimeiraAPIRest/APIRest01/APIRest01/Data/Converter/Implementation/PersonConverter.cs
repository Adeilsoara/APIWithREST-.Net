using APIRest01.Data.Converter.Contract;
using APIRest01.Data.Vo;
using APIRest01.Model;
using System.Collections.Generic;
using System.Linq;

namespace APIRest01.Data.Converter.Implementation {
    public class PersonConverter : IParser<PersonVo, Person>, IParser<Person, PersonVo> {
        public Person Parse(PersonVo origin) {

            if (origin == null) return null;
            return new Person
            {
                Id = origin.Id,
                Nome = origin.Nome,
                Sobrenome = origin.Sobrenome,
                Endereco = origin.Endereco,
                Genero = origin.Genero
            };
        }

        public List<Person> Parse(List<PersonVo> origin) {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public PersonVo Parse(Person origin) {
            if (origin == null) return null;
            return new PersonVo {
                Id = origin.Id,
                Nome = origin.Nome,
                Sobrenome = origin.Sobrenome,
                Endereco = origin.Endereco,
                Genero = origin.Genero
            };
        }

        public List<PersonVo> Parse(List<Person> origin) {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}