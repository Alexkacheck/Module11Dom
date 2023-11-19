using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Dom
{
    public struct Lan : ILan
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Position}, Нанятый : {CreateDate}, Зарплата: {Salary}, Пол: {Gender}";
        }
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }


}
