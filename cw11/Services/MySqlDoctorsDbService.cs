using cw11.DTOs.Requests;
using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public class MySqlDoctorsDbService : IDoctorDbService
    {
        private readonly DoctorsDbContext _context;

        public MySqlDoctorsDbService(DoctorsDbContext cotext)
        {
            _context = cotext;
        }

        public Doctor AddDoctor()
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctor.ToList();
        }

        public void RemoveDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor UpdateDoctor(DoctorDto doctor)
        {
            throw new NotImplementedException();
        }
    }
}
