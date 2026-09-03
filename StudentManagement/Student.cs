using System;


namespace StudentManagement
{
    class Student
    {
        string _Id;
        string _name;
        double _GPA;

        public string ID
        {
            get
            {
                return _Id;
            }
            set
            {
               if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid ID format!");
                }
                _Id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid name format!");
                }
                _name = value;
            }
        }
        public double GPA
        {
            get
            {
                return _GPA;
            }
            set
            {
                if(value < 0.0)
                {
                    throw new Exception("Invalid value for GPA!");
                }
                _GPA = value;
            }
        }
        public Student(string id, string name, double gpa)
        {
            ID = id;
            Name = name;
            GPA = gpa;
        }
    }
}