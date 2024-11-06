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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CompanyEntities db = new CompanyEntities();
        public MainWindow()
        {
            InitializeComponent();
            ListDG.ItemsSource = db.Employee.ToList();
        }

        private void Insert(object sender, RoutedEventArgs e)
        {
            Employee rec = new Employee();
            rec.EmpName = NText.Text;
            rec.EmpPostion = STXT.Text;
            db.Employee.Add(rec);
            db.SaveChanges();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            ListDG.ItemsSource = db.Employee.ToList();
        }

    }
}
