using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Student_Class.Entities.Concrete;

namespace Teacher_Student_Class.Entities.Abstract
{
    public interface IClassroom:IEntity
    {
        string Name { get; set; }
        List<Student> Students { get; set; }
        Teacher Teacher { get; set; }
    }
}
