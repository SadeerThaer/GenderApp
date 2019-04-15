using System;
using static System.Console;

namespace GenderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            char gender;
            string time;


           time = DateTime.Now.ToShortTimeString(); Title = "Welcome to C# Program";
            Write("Enter Your Name : ");
            name = ReadLine();
            Title = "Logged in by " + name; Write("Enter Your Age : ");
            age = Convert.ToInt16(ReadLine()); Write("Press [m] for Male, [f] for Female : "); gender = Convert.ToChar(ReadLine());

            if (gender == 'm')
            {
                WriteLine("Welcome Mr. " + name);
                WriteLine("Your age is " + age);
            }
            else if (gender == 'f')
            {
                WriteLine("Welcome Mrs. " + name);
                WriteLine("Your age is " + age);
            }
            else
                WriteLine("Error 101..");
            WriteLine("you started the program at " + time); _ = ReadKey();
        }
    }
}
