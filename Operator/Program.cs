using Operator.Models;
using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student_1 = new Student("aaaaaa", "bbbbbbb", 50);
            student_1.ShowInfo();

            Student student_2 = new Student("Kermit", "The Frog", 66);
            student_2.ShowInfo();
            Console.WriteLine($" {student_1 > student_2}");

            Group qr_1 = new Group();
            Group qr_2 = new Group();
        }
    }
}
