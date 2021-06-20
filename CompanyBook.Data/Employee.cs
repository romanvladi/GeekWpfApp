using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CompanyBook.Data
{
    public class Employee : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _phone;
        private string _firstName;
        private string _lastName;
        private string _secondName;
        private string _comment;
        private bool _locked;
        private string _email;
        private Department _department = Department.Defolt;
        private Position _position = Position.Defolt;

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone 
        {
            get { return _phone; }
            set 
            { 
                _phone = value;
                NotifyPropertyChanged();
            } 
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get { return _firstName; ; }
            set
            {
                _firstName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Отчество
        /// </summary>
        public string SecondName
        {
            get { return _secondName; }
            set
            {
                _secondName = value;
                NotifyPropertyChanged();
            }
        }

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
        public string Comment
        {
            get { return _comment; }
            set
            {
                _comment = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Блокировка
        /// </summary>
        public bool Locked
        {
            get { return _locked; }
            set
            {
                _locked = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Департамент
        /// </summary>
        public Department Department
        {
            get { return _department; }
            set
            {
                _department = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Должность
        /// </summary>
        public Position Position
        {
            get { return _position; }
            set
            {
                _position = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Employee() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="secondName"></param>
        /// <param name="locked"></param>
        /// <param name="department"></param>
        /// <param name="position"></param>
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

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
