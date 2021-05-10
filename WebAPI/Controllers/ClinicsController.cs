using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Localize;

namespace WebAPI.Controllers
{
    [Route("{culture:culture}/[controller]")]
    //[Route("api/[controller]")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private readonly IStringLocalizer<Resource> _localizer;
     
        IClinicService _clinicService;
        public ClinicsController(IClinicService carService, IStringLocalizer<Resource> localizer)
        {
            _clinicService = carService;
            _localizer = localizer;
        }

        [HttpGet("get")]
        public string Get()
        {
            return _localizer["Clinic"];
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _clinicService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _clinicService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getname")]
        public IActionResult GetName(string name)
        {
            var result = _clinicService.GetName(name);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Clinic clinic)
        {
            var result = _clinicService.Add(clinic);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Clinic clinic)
        {
            var result = _clinicService.Update(clinic);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Clinic clinic)
        {
            var result = _clinicService.Delete(clinic);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

     


    }
}
