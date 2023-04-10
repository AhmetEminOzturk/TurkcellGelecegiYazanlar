using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Student_Class.Entities.Abstract;

namespace Teacher_Student_Class.Entities.Concrete
{
    public class Classroom : IClassroom
    {
        public List<Student> Students { get ; set; }
        public Teacher Teacher { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
