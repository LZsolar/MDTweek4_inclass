using System;

namespace MDTwork1023
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.UserInput();


            printEverything(userInfo);

        }

        static void printEverything(UserInfo userInfo)
        {
              Class_Grade c = new Class_Grade();
            c.grade = userInfo.Score;

            userInfo.PrintUserInformation(userInfo);
            c.printGrade();
        }
    }
}