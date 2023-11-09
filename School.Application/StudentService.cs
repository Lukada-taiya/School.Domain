using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain;

namespace School.Application
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
            return student;
        }

        public List<Student> GetAllStudents()
        {
            var students = _studentRepository.GetAllStudents();
            return students;
        }
    }
}
