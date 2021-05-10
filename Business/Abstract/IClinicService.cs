using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IClinicService
    {

        IResult Add(Clinic clinic);
        IResult Update(Clinic clinic);
        IResult Delete(Clinic clinic);

        IDataResult<List<Clinic>> GetAll();
        IDataResult<Clinic> GetById(int id);
        IDataResult<Clinic> GetName(string name);

    }
}
