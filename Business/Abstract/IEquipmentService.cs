using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEquipmentService
    {
        IResult Add(Equipment equipment);
        IResult Update(Equipment equipment);
        IResult Delete(Equipment equipment);

        IDataResult<List<Equipment>> GetAll();
        IDataResult<Equipment> GetById(int id);
        IDataResult<Equipment> GetName(string name);
    }
}
