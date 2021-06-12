using APIRest01.Data.Converter.Implementation;
using APIRest01.Data.Vo;
using APIRest01.Model;
using APIRest01.Model.Context;
using APIRest01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace APIRest01.Business.Implemetations {
    public class PersonBusinessImplementation : IPersonBusiness {

        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository) {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVo Create(PersonVo person) {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id) {
            _repository.Delete(id);
        }

        public List<PersonVo> FindAll() { 
            
            return _converter.Parse(_repository.FindAll());

        }

        public PersonVo FindById(long id) {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVo Update(PersonVo person) {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

    }

    }
