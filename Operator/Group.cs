using System;
using System.Collections.Generic;
using System.Text;

namespace Operator.Models
{
    class Group
    {
        public string No { get; }
        private static int _no = 100;
        private string _No;

        private Student[] students;

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public Student[] GetAllStudents()
        {
            return students;
        }
        public Student[] Sort()
        {
            Student[] students = new Student[students.Length];
            Array.Copy(students, students, students.Length);
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length; j++)
                {
                    if (students[j] > students[j + 1])
                    {
                        Student student = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = student;
                    }
                }
            }
            return students;

        }
        public Group()
        {
            _no++;

            No = "AP" + _no;
            students = new Student[0];
        }
    }
}
