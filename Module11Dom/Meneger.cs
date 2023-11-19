using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Dom
{
   public  class Meneger
    {
        private List<Lan> employees = new List<Lan>();

        public void AddEmployee(Lan employee)
        {
            employees.Add(employee);
        }

        public void PrintAllEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        public void PrintEmployeesByPosition(string position)
        {
            var selectedEmployees = employees.Where(e => e.Position == position);
            foreach (var employee in selectedEmployees)
            {
                Console.WriteLine(employee);
            }
        }

        public void PrintManagersAboveAverageClerkSalary()
        {
            decimal averageClerkSalary = employees
                .Where(e => e.Position == "Сотрудник обычный")
                .Average(e => e.Salary);

            var managers = employees
                .Where(e => e.Position == "Мэнеджер " && e.Salary > averageClerkSalary)
                .OrderBy(e => e.LastName);

            foreach (var manager in managers)
            {
                Console.WriteLine(manager);
            }
        }

        public void PrintEmployeesHiredAfterDate(DateTime hireDate)
        {
            var selectedEmployees = employees
                .Where(e => e.CreateDate > hireDate)
                .OrderBy(e => e.LastName);

            foreach (var employee in selectedEmployees)
            {
                Console.WriteLine(employee);
            }
        }

        public void PrintEmployeesByGender(Gender gender)
        {
            var selectedEmployees = employees
                .Where(e => e.Gender == gender || gender == Gender.Unknown);

            foreach (var employee in selectedEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
