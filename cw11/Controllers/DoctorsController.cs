using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorsDbContext _dbContext;
        public DoctorsController(DoctorsDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult TestDoctors()
        {
            return Ok();
        }

    }
}
