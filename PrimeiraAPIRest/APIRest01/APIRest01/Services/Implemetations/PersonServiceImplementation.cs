using APIRest01.Model;
using APIRest01.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace APIRest01.Services.Implemetations {
    public class PersonServiceImplementation : IpersonServices {
        private MysqlContext _context;

        public PersonServiceImplementation(MysqlContext context) {
            _context = context;
        }
       
        public Person Create(Person person) {
            try {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception) {

                throw;
            }
            return person;
        }

        public void Delete(long id) {
           
        }

        public List<Person> FindAll() { 
            
            return _context.Persons.ToList();

        }

   
        public Person FindById(long id) {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person) {
            try {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception) {

                throw;
            }
            return person;
        }
    }

    }
