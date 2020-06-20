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

        public Doctor AddDoctor(DoctorDto doctorDto)
        {

            if (doctorDto == null)
            {
                throw new Exception("Data must be specified");
            }

            if (doctorDto.FirstName == null || doctorDto.FirstName.Equals(""))
            {
                throw new Exception("FirtName be specified");
            }

            if (doctorDto.LastName == null || doctorDto.LastName.Equals(""))
            {
                throw new Exception("LastName be specified");
            }

            var newDoctor = new Doctor();
            newDoctor.FirstName = doctorDto.FirstName;
            newDoctor.LastName = doctorDto.LastName;
            newDoctor.Email = doctorDto.Email;

            _context.Add(newDoctor);
            _context.SaveChanges();
            return newDoctor;
        }

        public Doctor GetDoctor(int id)
        {
            return _context.Doctor.Where(d => d.IdDoctor == id).FirstOrDefault();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctor.ToList();
        }

        public void RemoveDoctor(int? id)
        {
            if (id == null)
            {
                throw new Exception("Id must be specified");
            }

            var retrievedDoctor = _context.Doctor.Where(d => d.IdDoctor.Equals(id)).FirstOrDefault();
            if (retrievedDoctor == null)
            {
                throw new Exception("Doctor with id " + id + " doesn't exist");
            }

            _context.Remove(retrievedDoctor);

            throw new NotImplementedException();
        }

        public Doctor UpdateDoctor(DoctorDto doctorDto)
        {
            if (doctorDto == null || doctorDto.IdDoctor == null)
            {
                throw new Exception("Id must be specified");
            }

            var retrievedDoctor = _context.Doctor.Where(d => d.IdDoctor.Equals(doctorDto.IdDoctor)).FirstOrDefault();
            if (retrievedDoctor == null)
            {
                throw new Exception("Doctor with id " + doctorDto.IdDoctor + " doesn't exist");
            }

            if (doctorDto.FirstName != null && !doctorDto.FirstName.Equals(""))
            {
                retrievedDoctor.FirstName = doctorDto.FirstName;
            }

            if (doctorDto.LastName != null && !doctorDto.LastName.Equals(""))
            {
                retrievedDoctor.LastName = doctorDto.LastName;
            }

            retrievedDoctor.Email = doctorDto.Email;

            _context.SaveChanges();
            return retrievedDoctor;
        }
    }
}
