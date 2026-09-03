using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace StudentManagement
{
    class StudentManagement
    {
        private List<Student> _studentList;

        public StudentManagement()
        {
            _studentList = new List<Student>();
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Find student by ID");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Update Student");
            Console.WriteLine("6. Find highest GPA");
            Console.WriteLine("7. Count Students");
            Console.WriteLine("8. Exit");
        }

        public void AddStudent()
        {
            string id = "";
            while (true)
            {
                Console.Write("Enter new student's id: ");
                id = Console.ReadLine();
                if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
                {
                    Console.WriteLine("Invalid format for Student's ID, please enter again!");
                    continue;
                }
                if(FindStudentByID(id) != "Can't find out")
                {
                    Console.WriteLine("This ID is aldready in student list, please enter again!");
                    continue;
                }
                break;
            }
            string name = "";
            while (true)
            {
                Console.Write("Enter new student's name: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name)||string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Invalid format for Student's name, please enter again!");
                    continue;
                }
                break;
            }
            double gpa = 0.0;
            while (true)
            {
                Console.Write("Enter new student's GPA (0.0 - 4.0): ");
                if(!double.TryParse(Console.ReadLine(), out gpa) || gpa < 0.0 || gpa > 4.0)
                {
                    Console.WriteLine("Invalid format for Student's GPA, please enter again");
                    continue;
                }            
                break;
            }
            _studentList.Add(new Student(id, name, gpa));
            Console.WriteLine("Add student sucessfully");
        }

        public string FindStudentByID(string Id)
        {
            foreach(Student student in _studentList)
            {
                if(student.ID == Id)
                {
                    return $"ID: {student.ID}, name: {student.Name}, GPA: {student.GPA}";
                }
            }
            return "Can't find out";
        }
        public void ShowStudents()
        {
            if(_studentList.Count == 0)
            {
                Console.WriteLine("Empty list");
            }
            foreach (Student student in _studentList)
            {
                Console.WriteLine($"ID: {student.ID}, name: {student.Name}, GPA: {student.GPA}");
            }
        }
        public int CountStudents()
        {
            return _studentList.Count;
        }
        public double FindHighestGPA()
        {
            double maxGPA = 0.0;
            foreach (Student student in _studentList)
            {
                if(student.GPA > maxGPA)
                {
                    maxGPA = student.GPA;
                }
            }
            return maxGPA;
        }
        public void DeleteStudent(string id)
        {
            int index = _studentList.FindIndex(s => s.ID == id);
            if(index != -1)
            {
                _studentList.RemoveAt(index);
                Console.WriteLine($"Delete student with ID: {id} sucessfully!");
            }
            else
            {
                Console.WriteLine($"Can't find out student with ID: {id} => Can't delete!");
            }
        }
        public void UpdateStudent(string id)
        {
            int index = _studentList.FindIndex(s => s.ID == id);
            if(index == -1)
            {
                Console.WriteLine($"Can't find out student with ID: {id} => Can't update!");
                return;
            }
            string newID = "";
            while (true)
            {
                Console.Write("Enter new student's id: ");
                newID = Console.ReadLine();
                if (string.IsNullOrEmpty(newID) || string.IsNullOrWhiteSpace(newID))
                {
                    Console.WriteLine("Invalid format for Student's ID, please enter again!");
                    continue;
                }
                if(FindStudentByID(newID) != "Can't find out")
                {
                    Console.WriteLine("This ID is aldready in student list, please enter again!");
                    continue;
                }
                break;
            }
            string newName = "";
            while (true)
            {
                Console.Write("Enter new student's name: ");
                newName = Console.ReadLine();
                if (string.IsNullOrEmpty(newName)||string.IsNullOrWhiteSpace(newName))
                {
                    Console.WriteLine("Invalid format for Student's name, please enter again!");
                    continue;
                }
                break;
            }
            double newGPA = 0.0;
            while (true)
            {
                Console.Write("Enter new student's GPA (0.0 - 4.0): ");
                if(!double.TryParse(Console.ReadLine(), out newGPA) || newGPA < 0.0 || newGPA > 4.0)
                {
                    Console.WriteLine("Invalid format for Student's GPA, please enter again");
                    continue;
                }            
                break;
            }
            _studentList[index].ID = newID;
            _studentList[index].Name = newName;
            _studentList[index].GPA = newGPA;
        }
    }
}