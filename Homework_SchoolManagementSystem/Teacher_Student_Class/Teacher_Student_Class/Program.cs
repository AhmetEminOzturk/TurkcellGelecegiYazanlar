using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Student_Class.Entities.Concrete;
using Teacher_Student_Class.Repositories.Abstract;
using Teacher_Student_Class.Repositories.Concrete;

namespace Teacher_Student_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentRepo = new StudentRepository(new List<Student>());
            var teacherRepo = new TeacherRepository(new List<Teacher>());
            var classroomRepo = new ClassroomRepository(new List<Classroom>());
            var homeworkRepo = new HomeworkRepository(new List<Homework>());
            var menuManagement = new MenuManager();

            bool hasClassroom = false;          

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Student Operations");
                Console.WriteLine("2. Teacher Operations");
                Console.WriteLine("3. Classroom Operations");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        menuManagement.StudentOperations(studentRepo, classroomRepo, homeworkRepo, teacherRepo, ref hasClassroom);                       
                        break;

                    case 2:
                        menuManagement.TeacherOperations(teacherRepo, classroomRepo, ref hasClassroom);
                        break;

                    case 3:
                        menuManagement.ClassroomOperations(classroomRepo, ref hasClassroom);
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}