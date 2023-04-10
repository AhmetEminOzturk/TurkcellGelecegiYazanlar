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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly List<Teacher> _teacherList;

        public TeacherRepository(List<Teacher> teacherList)
        {
            _teacherList = teacherList;
        }

        public void Insert(Teacher teacher)
        {
            if (_teacherList.Any(c => c.ID == teacher.ID))
            {
                Console.WriteLine("Teacher ID already exists. \n Adding failed!");
                return;
            }
            Console.WriteLine("Teacher added succesfully");
            _teacherList.Add(teacher);
        }

        public Teacher GetById(int id)
        {
            return _teacherList.FirstOrDefault(x => x.ID == id);

        }

        public void Delete(int id)
        {
            var values = _teacherList.FirstOrDefault(x => x.ID == id);
            _teacherList.Remove(values);
        }

        public List<Teacher> GetAll()
        {
            return _teacherList;
        }
    }   
}
