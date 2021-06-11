using APIRest01.Model;
using APIRest01.Model.Context;
using APIRest01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using APIRest01.Business;

namespace APIRest01.Business.Implemetations {
    public class BookBusinessImplementation : IBookBusiness {
        
        private readonly IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository) {
            _repository = repository;
        }
       
        public Book Create(Book book) {
        
            return _repository.Create(book);
        }

        public void Delete(long id) {
            _repository.Delete(id);
        }

        public List<Book> FindAll() { 
            
            return _repository.FindAll();

        }

        public Book FindById(long id) {
            return _repository.FindById(id);
        }

        public Book Update(Book book) {
            return _repository.Update(book);
        }

        
    }

    }
