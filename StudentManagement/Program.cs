using System;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManagement management = new StudentManagement();
            Console.WriteLine("STUDENT MANAGEMENT PROGRAM:");
            int choice = 0;
            try
            {
                while (true)
                {
                    management.PrintMenu();
                    Console.Write("Enter your choice: ");
                    if(!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid value for choice, please enter again!");
                        continue;
                    }
                    if(choice == 8)
                    {
                        Console.WriteLine("EXITED PROGRAM!");
                        break;
                    }
                    switch (choice)
                    {
                        case 1:
                            management.AddStudent();
                            break;
                        case 2:
                            management.ShowStudents();
                            break;
                        case 3:
                            string findid = "";
                            while (true)
                            {
                                Console.Write("Enter student's ID you want to find: ");
                                findid = Console.ReadLine();
                                if(string.IsNullOrEmpty(findid) || string.IsNullOrWhiteSpace(findid))
                                {
                                    Console.WriteLine("Invaid format for student's ID, please enter again!");
                                    continue;
                                }
                                break;
                            }
                            Console.WriteLine(management.FindStudentByID(findid));
                            break;
                        case 4:
                            string deleteid = "";
                            while (true)
                            {
                                Console.Write("Enter student's ID you want to delete: ");
                                deleteid = Console.ReadLine();
                                if(string.IsNullOrEmpty(deleteid) || string.IsNullOrWhiteSpace(deleteid))
                                {
                                    Console.WriteLine("Invaid format for student's ID, please enter again!");
                                    continue;
                                }
                                break;
                            }
                            management.DeleteStudent(deleteid);
                            break;
                        case 5:
                            string updateid = "";
                            while (true)
                            {
                                Console.Write("Enter student's ID you want to update: ");
                                updateid = Console.ReadLine();
                                if(string.IsNullOrEmpty(updateid) || string.IsNullOrWhiteSpace(updateid))
                                {
                                    Console.WriteLine("Invaid format for student's ID, please enter again!");
                                    continue;
                                }
                                break;
                            }
                            management.UpdateStudent(updateid);
                            break;
                        case 6:
                            Console.WriteLine($"The highest GPA: {management.FindHighestGPA()}");
                            break;
                        case 7:
                            Console.WriteLine($"The number of students: {management.CountStudents()}");
                            break;
                        default:
                            Console.WriteLine("Your choice is not in menu, please try again!");
                            continue;
                    }    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}