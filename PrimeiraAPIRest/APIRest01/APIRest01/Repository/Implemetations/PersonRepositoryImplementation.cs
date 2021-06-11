using APIRest01.Model;
using APIRest01.Model.Context;
using APIRest01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace APIRest01.Business.Implemetations {
    public class PersonRepositoryImplementation : IPersonRepository {
        private MysqlContext _context;

        public PersonRepositoryImplementation(MysqlContext context) {
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
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null) {
                try {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception) {

                    throw;
                }
            }
        }

        public List<Person> FindAll() { 
            
            return _context.Persons.ToList();

        }

   
        public Person FindById(long id) {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person) {
            if (!Exists(person.Id)) return null;
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));

            if (result != null) {
                try {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception) {

                    throw;
                }
            }
            
            return person;
        }

        private bool Exists(long id) {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }

        bool IPersonRepository.Exists(long id) {
            throw new NotImplementedException();
        }
    }

    }
