using System;

namespace Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********STUDENTS**********");
            Console.WriteLine("Enter the number of students:");
            int numberOfStudents;
            while (!int.TryParse(Console.ReadLine(), out numberOfStudents) || numberOfStudents <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of students:");
            }

            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter class:");
                int cls;
                while (!int.TryParse(Console.ReadLine(), out cls))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for the class:");
                }

                Console.WriteLine("Enter section:");
                char section;
                while (!char.TryParse(Console.ReadLine(), out section))
                {
                    Console.WriteLine("Invalid input. Please enter a valid character for the section:");
                }

                students[i] = new Student(name, cls, section);
            }
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("****************PRINTING DETAILS OF STUDENTS********************");
            foreach (var item in students)
            {
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Class : {item.Class}");
                Console.WriteLine($"Section : {item.Section}");
            }
            Console.ReadKey();
        }
    }
}
