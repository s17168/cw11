using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.DTOs.Requests;
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
            var retrievedDoctor = _dbService.GetDoctor(id);
            if (retrievedDoctor == null)
            {
                return BadRequest("Doktor o id " + id + " nie istnieje");
            }
            return Ok(retrievedDoctor);
        }

        [HttpPut]
        public IActionResult UpdateDoctor(DoctorDto doctorDto)
        {
            Doctor modifiedDoctor = null;
            try 
            {
                modifiedDoctor = _dbService.UpdateDoctor(doctorDto);
            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(modifiedDoctor);             
        }

        [HttpPost]
        public IActionResult CreateDoctor(DoctorDto doctorDto)
        {
            Doctor createdDoctor = null;
            try
            {
                createdDoctor = _dbService.AddDoctor(doctorDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(createdDoctor);
        }

        [HttpDelete]
        public IActionResult DeleteDoctor(int? id)
        {
            try
            {
                 _dbService.RemoveDoctor(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok("Doctor " + id + " removed");
        }

    }
}
