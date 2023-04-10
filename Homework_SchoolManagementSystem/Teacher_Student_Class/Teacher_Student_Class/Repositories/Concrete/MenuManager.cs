using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Student_Class.Entities.Concrete;

namespace Teacher_Student_Class.Repositories.Concrete
{
    public class MenuManager
    {
        public void StudentOperations(StudentRepository studentRepo, ClassroomRepository classroomRepo, HomeworkRepository homeworkRepo, TeacherRepository teacherRepo, ref bool hasClassroom)
        {
            while (true)
            {
                if (!hasClassroom)
                {
                    Console.WriteLine("Please add a classroom first.(Go To '3. Classroom Operations')");
                    break;
                }
                Console.WriteLine("Student Operations:");
                Console.WriteLine("1. Add a student");
                Console.WriteLine("2. Delete a student");
                Console.WriteLine("3. List students");
                Console.WriteLine("4. Get Student Informations By Id");
                Console.WriteLine("5. Send Homework");
                Console.WriteLine("0. Back to Main Menu");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student ID: ");
                        int studentID;
                        while (!int.TryParse(Console.ReadLine(), out studentID))
                        {
                            Console.WriteLine("Invalid input. Please enter an integer value:");
                        }
                        Console.Write("Enter student name: ");
                        string studentName = Console.ReadLine();
                        Console.Write("Enter student surname: ");
                        string studentSurname = Console.ReadLine();
                        Console.Write("Enter classroom ID: ");
                        int classroomID;
                        while (!int.TryParse(Console.ReadLine(), out classroomID))
                        {
                            Console.WriteLine("Invalid input. Please enter an integer value:");
                        }

                        var studentClassroom = classroomRepo.GetById(classroomID);
                        if (studentClassroom == null)
                        {
                            Console.WriteLine("Classroom not found.");
                            break;
                        }

                        var student = new Student
                        {
                            ID = studentID,
                            Name = studentName,
                            Surname = studentSurname,
                            StudentClassroom = studentClassroom
                        };
                        studentRepo.Insert(student);

                        break;

                    case 2:
                        Console.Write("Enter student ID to delete: ");
                        int deleteStudentID = int.Parse(Console.ReadLine());
                        var studentToDelete = studentRepo.GetById(deleteStudentID);
                        if (studentToDelete == null)
                        {
                            Console.WriteLine("Student not found.");
                            break;
                        }
                        studentRepo.Delete(deleteStudentID);
                        Console.WriteLine("Student deleted successfully.");
                        break;

                    case 3:
                        var students = studentRepo.GetAll();
                        Console.WriteLine("List of Students:");
                        foreach (var item in students)
                        {
                            Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Surname: {item.Surname}, Classroom Name: {item.StudentClassroom.Name}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter student ID to get information: ");
                        int studentInfoID = int.Parse(Console.ReadLine());
                        var studentGet = studentRepo.GetById(studentInfoID);
                        if (studentGet == null)
                        {
                            Console.WriteLine("Student not found.");
                            break;
                        }
                        Console.WriteLine($"ID: {studentGet.ID}, Name: {studentGet.Name}, Surname: {studentGet.Surname}, Classroom Name: {studentGet.StudentClassroom.Name}");
                        break;

                    case 5:
                        Console.Write("Enter student ID: ");
                        int studentIdToSendAssignment = int.Parse(Console.ReadLine());

                        var studentToSendAssignment = studentRepo.GetById(studentIdToSendAssignment);
                        if (studentToSendAssignment == null)
                        {
                            Console.WriteLine($"Student with ID {studentIdToSendAssignment} not found.");
                            break;
                        }

                        Console.Write("Enter teacher ID: ");
                        int teacherIdToSendAssignment = int.Parse(Console.ReadLine());

                        var teacherToSendAssignment = teacherRepo.GetById(teacherIdToSendAssignment);
                        if (teacherToSendAssignment == null)
                        {
                            Console.WriteLine($"Teacher with ID {teacherIdToSendAssignment} not found.");
                            break;
                        }

                        Console.Write("Enter assignment content: ");
                        string assignmentContent = Console.ReadLine();
                        Console.Write("Enter file path: ");
                        string filePath = Console.ReadLine();
                        Console.Write("Enter homework id: ");
                        int homeworkId = int.Parse(Console.ReadLine());
                        Homework newAssignment = new Homework
                        {
                            ID = homeworkId,
                            Content = assignmentContent,
                            FilePath = filePath,
                            Student = studentToSendAssignment,
                            Teacher = teacherToSendAssignment
                        };

                        homeworkRepo.Insert(newAssignment);
                        Console.WriteLine($"Student {newAssignment.Student.Name} sent HomeworkID {newAssignment.ID} to Teacher {newAssignment.Teacher.Name} succesfully! \n File Path: {newAssignment.FilePath}");
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        break;
                }
            }
        }

        public void TeacherOperations(TeacherRepository teacherRepo, ClassroomRepository classroomRepo, ref bool hasClassroom)
        {
            while (true)
            {
                if (!hasClassroom)
                {
                    Console.WriteLine("Please add a classroom first.(Go To '3. Classroom Operations')");
                    break;
                }
                Console.WriteLine("Teacher Operations:");
                Console.WriteLine("1. Add a teacher");
                Console.WriteLine("2. Delete a teacher");
                Console.WriteLine("3. List teachers");
                Console.WriteLine("4. Get Teacher Informations By Id");
                Console.WriteLine("0. Back to Main Menu");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter teacher ID: ");
                        int teacherID;
                        while (!int.TryParse(Console.ReadLine(), out teacherID))
                        {
                            Console.WriteLine("Invalid input. Please enter an integer value:");
                        }
                        Console.Write("Enter teacher name: ");
                        string teacherName = Console.ReadLine();
                        Console.Write("Enter teacher surname: ");
                        string teacherSurname = Console.ReadLine();
                        Console.Write("Enter classroom ID: ");
                        int classroomID;
                        while (!int.TryParse(Console.ReadLine(), out classroomID))
                        {
                            Console.WriteLine("Invalid input. Please enter an integer value:");
                        }

                        var teacherClassroom = classroomRepo.GetById(classroomID);
                        if (teacherClassroom == null)
                        {
                            Console.WriteLine("Classroom not found.");
                            break;
                        }

                        var teacher = new Teacher
                        {
                            ID = teacherID,
                            Name = teacherName,
                            Surname = teacherSurname,
                            TeacherClassroom = teacherClassroom
                        };
                        teacherRepo.Insert(teacher);

                        break;

                    case 2:
                        Console.Write("Enter teacher ID to delete: ");
                        int deleteTeacherID = int.Parse(Console.ReadLine());
                        var teacherToDelete = teacherRepo.GetById(deleteTeacherID);
                        if (teacherToDelete == null)
                        {
                            Console.WriteLine("Teacher not found.");
                            break;
                        }
                        teacherRepo.Delete(deleteTeacherID);
                        Console.WriteLine("Teacher deleted successfully.");
                        break;

                    case 3:
                        var teachers = teacherRepo.GetAll();
                        Console.WriteLine("List of Teachers:");
                        foreach (var item in teachers)
                        {
                            Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Surname: {item.Surname}, Classroom Name: {item.TeacherClassroom.Name}");
                        }
                        break;

                    case 4:
                        Console.Write("Enter teacher ID to get information: ");
                        int teacherInfoID = int.Parse(Console.ReadLine());
                        var teacherGet = teacherRepo.GetById(teacherInfoID);
                        if (teacherGet == null)
                        {
                            Console.WriteLine("Teacher not found.");
                            break;
                        }
                        Console.WriteLine($"ID: {teacherGet.ID}, Name: {teacherGet.Name}, Surname: {teacherGet.Surname}, Classroom Name: {teacherGet.TeacherClassroom.Name}");
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        break;
                }
            }
        }

        public void ClassroomOperations(ClassroomRepository classroomRepo, ref bool hasClassroom)
        {
            while (true)
            {
                Console.WriteLine("Classroom Operations:");
                Console.WriteLine("1. Add a classroom");
                Console.WriteLine("2. Delete a classroom");
                Console.WriteLine("3. List classrooms");
                Console.WriteLine("0. Back to Main Menu");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter classroom ID: ");
                        int classroomID;
                        while (!int.TryParse(Console.ReadLine(), out classroomID))
                        {
                            Console.WriteLine("Invalid input. Please enter an integer value:");
                        }
                        Console.Write("Enter classroom name: ");
                        string classroomName = Console.ReadLine();

                        var classroom = new Classroom
                        {
                            ID = classroomID,
                            Name = classroomName
                        };
                        classroomRepo.Insert(classroom);
                        hasClassroom = true;

                        break;

                    case 2:
                        Console.Write("Enter classroom ID to delete: ");
                        int deleteClassroomID = int.Parse(Console.ReadLine());
                        var classroomToDelete = classroomRepo.GetById(deleteClassroomID);
                        if (classroomToDelete == null)
                        {
                            Console.WriteLine("Classroom not found.");
                            break;
                        }
                        classroomRepo.Delete(deleteClassroomID);
                        Console.WriteLine("Classroom deleted successfully.");
                        break;

                    case 3:
                        var classrooms = classroomRepo.GetAll();
                        Console.WriteLine("List of Classrooms:");
                        foreach (var item in classrooms)
                        {
                            Console.WriteLine($"ID: {item.ID}, Name: {item.Name}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Going back to Main Menu...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;

                }
            }
        }
    }
}
