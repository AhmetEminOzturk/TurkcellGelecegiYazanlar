using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Student_Class.Entities.Abstract;
using Teacher_Student_Class.Entities.Concrete;
using Teacher_Student_Class.Repositories.Abstract;

namespace Teacher_Student_Class.Repositories.Concrete
{
    public class ClassroomRepository : IClassroomRepository
    {
        private readonly List<Classroom> _classroom;

        public ClassroomRepository(List<Classroom> classroom)
        {
            _classroom = classroom;
        }

        public void Insert(Classroom classroom)
        {
            if (_classroom.Any(c => c.ID == classroom.ID))
            {
                Console.WriteLine("Classroom ID already exists.  \n Adding failed!");
                return;
            }
            Console.WriteLine("Classroom added succesfully");
            _classroom.Add(classroom);
        }

        public Classroom GetById(int id)
        {
            var value = _classroom.FirstOrDefault(x => x.ID == id);
            return value;
        }

        public void Delete(int id)
        {
            var value = _classroom.FirstOrDefault(x => x.ID == id);
            _classroom.Remove(value);
        }

        public List<Classroom> GetAll()
        {
            return _classroom;
        }
    }
}
