using cw11.DTOs.Requests;
using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IDoctorDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public Doctor GetDoctor(int id);
        public void RemoveDoctor(int? id);
        public Doctor AddDoctor(DoctorDto doctorDto);
        public Doctor UpdateDoctor(DoctorDto doctor);
    }
}
