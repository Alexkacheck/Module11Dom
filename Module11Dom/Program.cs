using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Dom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сотрудников:");
            int size = int.Parse(Console.ReadLine());

            Meneger employeeManager = new Meneger();

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите данные для сотрудника {i + 1}:");

                var employee = new Lan
                {
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    Position = Console.ReadLine(),
                    CreateDate = DateTime.Parse(Console.ReadLine()),
                    Salary = decimal.Parse(Console.ReadLine()),
                    Gender = ParseGender(Console.ReadLine())
                };

                employeeManager.AddEmployee(employee);
            }

            Console.WriteLine("Cотрудники вск:");
            employeeManager.PrintAllEmployees();

            Console.WriteLine("Введите должность для фильтрации сотрудников:");
            string positionFilter = Console.ReadLine();
            employeeManager.PrintEmployeesByPosition(positionFilter);

            Console.WriteLine("Менеджеры с зарплатой выше средней ");
            employeeManager.PrintManagersAboveAverageClerkSalary();

            Console.WriteLine("Введите дату приема на работу чтобы отфильтровать сотрудников ");
            DateTime hireDateFilter = DateTime.Parse(Console.ReadLine());
            employeeManager.PrintEmployeesHiredAfterDate(hireDateFilter);

            Console.WriteLine("Введите пол для фильтрации сотрудников мужчина , женщина, Неизвестно кто");
            Gender genderFilter = ParseGender(Console.ReadLine());
            employeeManager.PrintEmployeesByGender(genderFilter);
        }

        private static Gender ParseGender(string input)
        {
            if (input.ToLower() == "Мужик")
                return Gender.Male;
            else if (input.ToLower() == "жэнщина")
                return Gender.Female;
            else
                return Gender.Unknown;
        }


    }
}


