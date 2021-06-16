using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyBook.Data
{
    public class Employee
    {
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO
        {
            get { return $"{LastName} {FirstName} {SecondName}"; }
        }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Блокировка
        /// </summary>
        public bool Locked { get; set; }

        /// <summary>
        /// Департамент
        /// </summary>
        public Department Department { get; set; } = Department.Defolt;

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public Position Position { get; set; } = Position.Defolt;

        public Employee() { }

        public Employee(string phone, string firstName, string lastName, string secondName, bool locked, Department department, Position position)
        {
            Phone = phone;
            FirstName = firstName;
            LastName = lastName;
            SecondName = secondName;

            Locked = locked;
            Department = department;
            Position = position;
        }

        public override string ToString()
        {
            return $"{Phone} - {LastName} {FirstName} {SecondName}";
        }
    }
}
