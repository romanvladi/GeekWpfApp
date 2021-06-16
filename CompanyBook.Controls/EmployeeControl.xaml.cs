using CompanyBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompanyBook.Controls
{
    /// <summary>
    /// Логика взаимодействия для EmployeeControl.xaml
    /// </summary>
    public partial class EmployeeControl : UserControl
    {
        private Employee employee;
        public EmployeeControl()
        {
            InitializeComponent();

            cbDepartment.ItemsSource = Enum.GetValues(typeof(Department)).Cast<Department>();
            cbPosition.ItemsSource = Enum.GetValues(typeof(Position)).Cast<Position>();
        }

        /// <summary>
        /// Вывод сотрудника на форму контроллера
        /// </summary>
        /// <param name="employee"></param>
        public void SetEmployee(Employee employee)
        {
            this.employee = employee;

            tbPhone.Text = employee.Phone;
            tbFirstName.Text = employee.FirstName;
            tbLastName.Text = employee.LastName;
            tbSecondName.Text = employee.SecondName;
            cbLocked.IsChecked = employee.Locked;
            cbDepartment.SelectedItem = employee.Department;
            tbComment.Text = employee.Comment;
            tbEmail.Text = employee.Email;
            cbPosition.SelectedItem = employee.Position;
        }

        /// <summary>
        /// Обновление сотрудника с формы контроллера
        /// </summary>
        public void UpdateEmployee()
        {
            employee.Phone = tbPhone.Text;
            employee.FirstName = tbFirstName.Text;
            employee.LastName = tbLastName.Text;
            employee.SecondName = tbSecondName.Text;
            employee.Locked = (bool)cbLocked.IsChecked;
            employee.Department = (Department)cbDepartment.SelectedItem;
            employee.Comment = tbComment.Text;
            employee.Email = tbEmail.Text;
            employee.Position = (Position)cbPosition.SelectedItem;
        }

        /// <summary>
        /// Зпись нового сотрудника с контроллера в "пустышку"
        /// </summary>
        /// <param name="empl"></param>
        public void CreateEmployee(Employee empl)
        {
            empl.Phone = tbPhone.Text;
            empl.FirstName = tbFirstName.Text;
            empl.LastName = tbLastName.Text;
            empl.SecondName = tbSecondName.Text;
            empl.Locked = (bool)cbLocked.IsChecked;
            empl.Department = (Department)cbDepartment.SelectedItem;
            empl.Comment = tbComment.Text;
            empl.Email = tbEmail.Text;
            empl.Position = (Position)cbPosition.SelectedItem;
        }
    }
}
