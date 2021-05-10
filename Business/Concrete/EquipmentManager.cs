using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.LogAspects;
using Core.CrossCuttingConcems.Logging.Log4Net.Loggers;
using Core.CrossCuttingConcems.Validation;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EquipmentManager : IEquipmentService
    {
        IEquipmentDal _equipmentDal;

        public EquipmentManager(IEquipmentDal equipmentDal)
        {

            _equipmentDal = equipmentDal;
        }

        public IResult Add(Equipment equipment)
        {
            ValidationTool.Validate(new EquipmentValidator(),equipment);

            _equipmentDal.Add(equipment);
            return new SuccessResult("Equipment added.");
        }

        public IResult Delete(Equipment equipment)
        {
            _equipmentDal.Delete(equipment);
            return new SuccessResult("Equipment deleted.");
        }


        [LogAspect(typeof(FileLogger))]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Equipment>> GetAll()
        {
            return new SuccessDataResult<List<Equipment>>(_equipmentDal.GetAll(), "Equipment listed.");
        }

        public IDataResult<Equipment> GetById(int id)
        {
            return new SuccessDataResult<Equipment>(_equipmentDal.Get(c => c.Id == id));
        }

        public IDataResult<Equipment> GetName(string name)
        {
            return new SuccessDataResult<Equipment>(_equipmentDal.Get(c => c.Name == name));
        }


        public IResult Update(Equipment equipment)
        {
            _equipmentDal.Update(equipment);
            return new SuccessResult("Equipment updated.");
        }

     
    }
}
