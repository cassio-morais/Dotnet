using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using ExerLinq.Entities;

namespace ExerLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter full file path: ");
            var path = Console.ReadLine();

            Console.Write("Enter Salary: ");
            var limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // List<Employee> employeesList = new List<Employee>();
            var employeesList = new List<Employee>();

            try
            {
                using (var file = File.OpenText(path))
                {
                    while (!file.EndOfStream)
                    {
                        var linha = file.ReadLine().Split(",");
                        var empName = linha[0];
                        var empEmail = linha[1];
                        var empSalary = double.Parse(linha[2], CultureInfo.InvariantCulture);

                        employeesList.Add(new Employee(empName, empEmail, empSalary));

                    }
                }



                var emails = employeesList
                    .Where(emp => emp.Salary > limit)
                    .OrderBy(emp => emp.Email)
                    .Select(emp => emp.Email);

                //(from employee in employeesList
                // where employee.Salary > salary
                // orderby employee.Name
                // select employee.Email);

                foreach (var empEmail in emails)
                {
                    Console.WriteLine(empEmail);
                }



                var salaryNamesStartsWithM = employeesList.Where(emp => emp.Name[0] == 'M').Sum(emp => emp.Salary);

                //(from employee in employeesList
                // where employee.Name[0] == 'M'
                // select employee.Salary)
                //.Sum();

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + salaryNamesStartsWithM.ToString("F2", CultureInfo.InvariantCulture));


            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }








        }
    }
}
