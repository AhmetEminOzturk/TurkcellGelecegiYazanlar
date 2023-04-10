using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Student_Class.Entities.Abstract;

namespace Teacher_Student_Class.Entities.Concrete
{
    public class Teacher : ITeacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ID { get; set; }
        public Classroom TeacherClassroom { get; set; }
        
    }
}
