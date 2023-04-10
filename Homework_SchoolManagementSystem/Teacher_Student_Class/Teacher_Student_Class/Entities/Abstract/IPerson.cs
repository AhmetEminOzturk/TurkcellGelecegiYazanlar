using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student_Class.Entities.Abstract
{
    public interface IPerson: IEntity
    {
        string Name { get; set; }
        string Surname { get; set; }
    }
}
