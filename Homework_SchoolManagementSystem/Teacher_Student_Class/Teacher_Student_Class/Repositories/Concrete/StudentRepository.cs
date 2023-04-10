using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Teacher_Student_Class.Entities.Abstract;
using Teacher_Student_Class.Entities.Concrete;
using Teacher_Student_Class.Repositories.Abstract;

namespace Teacher_Student_Class.Repositories.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _studentList;
        
        public StudentRepository(List<Student> studentList)
        {
            _studentList = studentList;
        }

        public void Insert(Student student)
        {
            if (_studentList.Any(c => c.ID == student.ID))
            {
                Console.WriteLine("Student ID already exists.  \n Adding failed!");
                return;
            }
            Console.WriteLine("Student added succesfully");
            _studentList.Add(student);
        }
      
        public Student GetById(int id)
        {
            var value = _studentList.FirstOrDefault(x => x.ID == id);
            return value;
        }

        public void Delete(int id)
        {
            var value = _studentList.FirstOrDefault(x => x.ID == id);
            _studentList.Remove(value);
        }

        public List<Student> GetAll()
        {
            return _studentList;
        }
    }
}

