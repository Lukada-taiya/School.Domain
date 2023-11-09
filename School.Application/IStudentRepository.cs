using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain;

namespace School.Application
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();

        Student AddStudent(Student student);
    }
}
