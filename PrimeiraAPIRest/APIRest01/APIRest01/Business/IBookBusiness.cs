using System;
using System.Collections.Generic;
using APIRest01.Model;
using APIRest01.Business;

namespace APIRest01.Business {
    public interface IBookBusiness {
        Book Create(Book book);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
    }
}
