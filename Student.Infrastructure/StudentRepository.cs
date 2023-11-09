using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Application;
using School.Domain;

namespace School.Infrastructure
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;

        //List<Student> students = new List<Student>
        //{
        //    new Student() { Id = 1, FirstName = "Adam", LastName = "Lukman", Age = 15, StudentId = 1001 },
        //    new Student() { Id = 1, FirstName = "Frank", LastName = "Addai", Age = 23, StudentId = 1002 },
        //    new Student() { Id = 1, FirstName = "Millicent", LastName = "Leagbe", Age = 24, StudentId = 1003 },
        //    new Student() { Id = 1, FirstName = "Godwin", LastName = "Diaba", Age = 20, StudentId = 1004 },
        //};

        public StudentRepository(StudentDbContext context) {
            _context = context;
        }

        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
    }
}
