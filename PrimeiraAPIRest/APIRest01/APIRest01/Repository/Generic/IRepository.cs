using System;
using System.Collections.Generic;
using APIRest01.Model;
using APIRest01.Model.Base;
using APIRest01.Repository;

namespace APIRest01.Repository {
    public interface IRepository<T> where T : BaseEntity {

        T Create(T item);
        T FindById(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);

        bool Exists(long id);
    }
}
