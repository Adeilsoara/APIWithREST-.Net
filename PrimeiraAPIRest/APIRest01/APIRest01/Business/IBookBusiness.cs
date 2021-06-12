using System;
using System.Collections.Generic;
using APIRest01.Model;

namespace APIRest01.Business {
    public interface IBookBusiness {
        BookVo Create(BookVo book);
        BookVo FindById(long id);
        List<BookVo> FindAll();
        BookVo Update(BookVo book);
        void Delete(long id);
    }
}
