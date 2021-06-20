using CompanyBook.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class EmployeeControl : UserControl, INotifyPropertyChanged
    {
        private Employee _employee = new Employee();

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Employee Employee
        {
            get { return _employee; }
            set
            {
                _employee = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Department> DepartmentList { get; set; } = new ObservableCollection<Department>();
        public ObservableCollection<Position> PositionList { get; set; } = new ObservableCollection<Position>();

        public EmployeeControl()
        {
            InitializeComponent();

            this.DataContext = this;

            CreateObservableCollection();
        }

        public void CreateObservableCollection()
        {
            foreach (var a in Enum.GetValues(typeof(Department)).Cast<Department>())
            {
                DepartmentList.Add(a);
            }
            foreach (var a in Enum.GetValues(typeof(Position)).Cast<Position>())
            {
                PositionList.Add(a);
            }
        }
    }
}
