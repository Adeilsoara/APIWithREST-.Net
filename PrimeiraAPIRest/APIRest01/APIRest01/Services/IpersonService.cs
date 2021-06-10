using System;
using System.Collections.Generic;
using APIRest01.Model;

namespace APIRest01.Services {
    public interface IpersonServices {

        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
