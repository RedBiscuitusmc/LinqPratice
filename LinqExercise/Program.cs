using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
     /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sumNum = numbers.Sum(x => x);
            Console.WriteLine(sumNum);
            addSpace();

            //TODO: Print the Average of numbers
            var average = numbers.Average(x => x);
            Console.Write($"{average}\n");
            addSpace();

            //TODO: Order numbers in ascending order and print to the console
            var ascending = numbers.OrderBy(x => x);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            addSpace();

            //TODO: Order numbers in decsending order and print to the console
            var decending = numbers.OrderByDescending(x => x);
            foreach (var number in decending)
            {
                Console.WriteLine($"{number}\n");
            }
            addSpace();

            //TODO: Print to the console only the numbers greater than 6
            var greaterSix = numbers.Where(x => x > 6);
            foreach (var x in greaterSix)
            {
                Console.WriteLine(x);
            }
            addSpace();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var fourOnly = numbers.Take(4);
            foreach (var number in fourOnly)
            {
                Console.WriteLine(number.ToString());
            }
            addSpace();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 30;
            var changeAge = numbers.OrderByDescending(numbers => numbers);
            foreach (var number in changeAge)
            {
                Console.WriteLine(number);
            }
            addSpace();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            var fullCorSname = employees.Where(x => x.FullName.StartsWith("C") || x.FullName.StartsWith("S")).OrderBy(x => x.FirstName);
            foreach (var x in fullCorSname)
            {
                Console.WriteLine(x.FirstName);
            }
            addSpace();
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var nameAge = employees.Where(x => x.Age > 26).OrderBy(x => x.FirstName);
            foreach (var x in nameAge)
            {
                Console.WriteLine($"{x.FirstName}, {x.Age}");
            }
            addSpace();
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            var YOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age < 35).OrderBy(x => x.FirstName);
            foreach (var x in YOE)
            {
                Console.WriteLine($"{x.FirstName}, {x.YearsOfExperience}");
            }
            addSpace();
            //TODO: Add an employee to the end of the list without using employees.Add()
            var addEmployee = employees.Append(new Employee { FirstName = "Jesus", LastName = "Doe", Age = 28, YearsOfExperience = 9 }).Where(x => x.FirstName.StartsWith("J"));
            foreach (var x in addEmployee)
            {
                Console.WriteLine(x.FirstName);
            }
            addSpace();
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion

        public static void addSpace()
        {
            Console.WriteLine("==============================================================================\n");
            Console.WriteLine("==============================================================================\n");
            Console.WriteLine("==============================================================================\n");
        }


    }
}
