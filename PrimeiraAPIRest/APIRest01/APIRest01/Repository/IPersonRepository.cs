using System;
using System.Collections.Generic;
using APIRest01.Model;
using APIRest01.Repository;

namespace APIRest01.Repository {
    public interface IPersonRepository {

        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

        bool Exists(long id);
    }
}
