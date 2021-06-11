using System;
using System.Collections.Generic;
using APIRest01.Model;
using APIRest01.Repository;

namespace APIRest01.Repository {
    public interface IBookRepository {

        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);

        bool Exists(long id);
    }
}
