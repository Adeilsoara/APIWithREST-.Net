using System;
using System.Collections.Generic;
using APIRest01.Data.Vo;
using APIRest01.Model;

namespace APIRest01.Business {
    public interface IPersonBusiness {

        PersonVo Create(PersonVo person);
        PersonVo FindById(long id);
        List<PersonVo> FindAll();
        PersonVo Update(PersonVo person);
        void Delete(long id);
    }
}
