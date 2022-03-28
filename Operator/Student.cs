using System;
using System.Collections.Generic;
using System.Text;

namespace Operator.Models
{
    class Student
    {
        private int _id;
        private static object student_1;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }

        public Student(string Name, string Surname, int Age, int Point)
        {
            _id++;
            Id = _id;
            Name = Name;
            Surname = Surname;
            Age = Age;
            Point = Point;
        }
        public Student(string v1, string v2, int v3)
        {
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}- Surname{Surname}-Point{Point}-Age{Age}");
        }

        public static bool operator >(Student student_1, Student student_2)
        {
            return student_1.Point > student_2.Point;
        }

        public static bool operator <(Student student_1, Student student_2)
        {
            return student_1.Point < student_2.Point;

        }

    }
   
}
