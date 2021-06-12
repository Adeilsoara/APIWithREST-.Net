using APIRest01.Model;
using APIRest01.Model.Context;
using APIRest01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using APIRest01.Business;
using APIRest01.Data.Converter.Implementation;

namespace APIRest01.Business.Implemetations {
    public class BookBusinessImplementation : IBookBusiness {
        
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository) {
            _repository = repository;
            _converter = new BookConverter();
        }
       
        public BookVo Create(BookVo book) {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public void Delete(long id) {
            _repository.Delete(id);
        }

        public List<BookVo> FindAll() {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVo FindById(long id) {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVo Update(BookVo book) {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        
    }

    }
