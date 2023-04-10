using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Student_Class.Entities.Abstract;

namespace Teacher_Student_Class.Entities.Concrete
{
    public class Homework : IHomework
    {
        public string Content { get ; set ; }
        public string FilePath { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public int ID { get; set; }
    }
}
