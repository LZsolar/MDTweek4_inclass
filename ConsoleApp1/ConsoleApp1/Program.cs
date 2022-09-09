using System;

namespace MDTwork1023
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = InputName();
            string score = InputScore();
            string grade = GetGrade(score);

            PrintGrade(name, score, grade);
        }
    }
}