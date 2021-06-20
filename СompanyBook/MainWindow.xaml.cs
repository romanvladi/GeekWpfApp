using CompanyBook.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace СompanyBook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CompanyBookDatabase database = new CompanyBookDatabase();
        public ObservableCollection<Employee> EmployeeList { get; set; }
        public Employee SelectedEmployee { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            EmployeeList = database.Employees;
        }

        private void companyBookListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                employeeControl.Employee = (Employee)SelectedEmployee.Clone();
            }
        }      

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if (companyBookListView.SelectedItems.Count < 1)
            {
                return;
            }
            else
            {
                EmployeeList[EmployeeList.IndexOf(SelectedEmployee)] = employeeControl.Employee;
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (companyBookListView.SelectedItems.Count < 1)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Удалить выделенный контакт?", "Удаление контакта", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    database.Employees.Remove((Employee)companyBookListView.SelectedItems[0]);
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Employee empl = new Employee();

            empl = employeeControl.Employee;

            database.Employees.Add(empl);
            companyBookListView.SelectedItem = empl;
            companyBookListView.ScrollIntoView(empl);

        }
    }
}