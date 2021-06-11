using APIRest01.Model;
using APIRest01.Model.Context;
using APIRest01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace APIRest01.Business.Implemetations {
    public class BookRepositoryImplementation : IBookRepository {
        private MysqlContext _context;

        public BookRepositoryImplementation(MysqlContext context) {
            _context = context;
        }
       
        public Book Create(Book book) {
            try {
                _context.Add(book);
                _context.SaveChanges();
            }
            catch (Exception) {

                throw;
            }
            return book;
        }

        public void Delete(long id) {
            var result = _context.Books.SingleOrDefault(b => b.Id.Equals(id));
            if (result != null) {
                try {
                    _context.Books.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception) {

                    throw;
                }
            }
        }

        public List<Book> FindAll() { 
            
            return _context.Books.ToList();

        }

   
        public Book FindById(long id) {
            return _context.Books.SingleOrDefault(b => b.Id.Equals(id));
        }

        public Book Update(Book book) {
            if (!Exists(book.Id)) return null;
            var result = _context.Books.SingleOrDefault(b => b.Id.Equals(book.Id));

            if (result != null) {
                try {
                    _context.Entry(result).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                }
                catch (Exception) {

                    throw;
                }
            }
            
            return book;
        }

        private bool Exists(long id) {
            return _context.Books.Any(b => b.Id.Equals(id));
        }

        bool IBookRepository.Exists(long id) {
            throw new NotImplementedException();
        }
    }

    }
