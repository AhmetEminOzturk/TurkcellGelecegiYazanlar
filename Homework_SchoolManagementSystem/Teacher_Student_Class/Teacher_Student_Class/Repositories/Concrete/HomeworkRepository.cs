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
    public class HomeworkRepository : IHomeworkRepository
    {
        private readonly List<Homework> _homeworkList;

        public HomeworkRepository(List<Homework> homeworkList)
        {
            _homeworkList = homeworkList;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Homework> GetAll()
        {
            throw new NotImplementedException();
        }

        public Homework GetById(int id)
        {
            var value = _homeworkList.FirstOrDefault(x => x.ID == id);
            return value;
        }

        public void Insert(Homework homework)
        {
            if (homework == null)
            {
                throw new ArgumentNullException(nameof(homework));
            }

            if (_homeworkList.Any(c => c.ID == homework.ID))
            {
                Console.WriteLine("Homework ID already exists.  \n Sending failed!");
                return;
            }
            Console.WriteLine("Homework sent succesfully");
            _homeworkList.Add(homework);
        }
    }
}
