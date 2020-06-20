using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorDbService _dbService;
        public DoctorsController(IDoctorDbService service)
        {
            _dbService = service;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_dbService.GetDoctors());
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            return Ok();
        }

    }
}
