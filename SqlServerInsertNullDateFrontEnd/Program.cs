using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlServerInsertNullDate;
using SqlServerInsertNullDate.Entities;
using static SqlServerInsertNullDateFrontEnd.Helpers.ConsoleHelpers;

namespace SqlServerInsertNullDateFrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalForeColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Insert employee without hire date");
            Console.ForegroundColor = originalForeColor;

            var newEmployee = new Employee() {FirstName = "Mary", LastName = "Smith"};

            var results = Operations.InsertEmployeeRow(newEmployee);

            Console.WriteLine(results
                ? $"Added new employee with id {newEmployee.Id}"
                : "Failed to add new employee, see error log");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Insert employee with hire date");
            Console.ForegroundColor = originalForeColor;

            newEmployee.FirstName = "Ken";
            newEmployee.LastName = "Jones";
            newEmployee.HiredDate = DateTime.Now;

            results = Operations.InsertEmployeeRow(newEmployee);

            Console.WriteLine(results
                ? $"Added new employee with id {newEmployee.Id}"
                : "Failed to add new employee, see error log");


            ConsoleReadLineWithTimeout(TimeSpan.FromSeconds(2.5));

        }
    }
}
