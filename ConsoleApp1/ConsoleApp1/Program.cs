using System;

namespace MDTwork1023
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_Grade c = new Class_Grade();
            c.grade = Console.ReadLine();
            c.printScore();
            c.printGrade();
        }
    }
}