using Business.Abstract;
using Core.Aspects.LogAspects;
using Core.CrossCuttingConcems.Logging.Log4Net.Loggers;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ClinicManager : IClinicService
    {

        IClinicDal _clinicDal;

        public ClinicManager(IClinicDal clinicDal)
        {
            _clinicDal = clinicDal;
        }


        public IResult Add(Clinic clinic)
        {
            // kontroleri yap
            _clinicDal.Add(clinic);
            return new SuccessResult("Clinic added.");
        }

        public IResult Delete(Clinic clinic)
        {
            _clinicDal.Delete(clinic);
            return new SuccessResult("Clinic deleted.");
        }

        [LogAspect(typeof(FileLogger))]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Clinic>> GetAll()
        {
            return new SuccessDataResult<List<Clinic>>(_clinicDal.GetAll(),"Clinic listed.");
        }

        public IDataResult<Clinic> GetById(int id)
        {
            return new SuccessDataResult<Clinic>(_clinicDal.Get(c => c.Id == id));
        }

        public IDataResult<Clinic> GetName(string name)
        {
            return new SuccessDataResult<Clinic>(_clinicDal.Get(c => c.Name == name));
        }

        public IResult Update(Clinic clinic)
        {
            _clinicDal.Update(clinic);
            return new SuccessResult("Clinic updated.");
        }
    }
}
