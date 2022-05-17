    using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window , INotifyPropertyChanged
    {

        public string MainCaptionText { get; set; }
        public List<Person> ExpenseDataSource { get; set; }

        private DateTime lastChecked;
        public DateTime LastChecked { get { return lastChecked; } 
            set {
                lastChecked = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("LastChecked"));
                }
                } 
        }

        public ObservableCollection<string> PersonsChecked
        { get; set; }

        public ExpenseItHome()
        {
            InitializeComponent();
            LastChecked = DateTime.Now;
            PersonsChecked = new ObservableCollection<string>();
            this.DataContext = this;
            ExpenseDataSource = new List<Person>()
            {

                new Person()
                    {
                    Name="Mike",
                    Department ="Legal",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Lunch", ExpenseAmount =50 },
                        new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
                    }
                },
                new Person()
                    {
                    Name="Lisa",
                    Department ="Marketing",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Document Printing", ExpenseAmount =50 },
                        new Expense() { ExpenseType="Gift", ExpenseAmount=125 }
                    }
                },
                new Person()
                    {
                    Name="John",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Magazine Subscription  ", ExpenseAmount =50 },
                        new Expense() { ExpenseType="New machine", ExpenseAmount =600 },
                        new Expense() { ExpenseType="Software", ExpenseAmount=500 }
                    }
                },
                new Person()
                    {
                    Name="Mary",
                    Department ="Finance",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Dinner", ExpenseAmount =100 }
                    }
                },
                new Person()
                    {
                    Name="Theo",
                    Department ="Marketing",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Lunch", ExpenseAmount =100 }
                    }
                },
                new Person()
                    {
                    Name="James",
                    Department ="Dealership",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType=" New car", ExpenseAmount =500 },
                        new Expense() { ExpenseType="Gift", ExpenseAmount=125 }
                    }
                },
                 new Person()
                    {
                    Name="David",
                    Department ="Finance",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Dinner", ExpenseAmount =100 }
                    }
                }
            };  
            MainCaptionText = "View Expense Report";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            LastChecked = DateTime.Now;
            string b = ((Person)peopleListBox.SelectedItem).Name;
            PersonsChecked.Add(b);

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport report = new ExpenseReport();
            ExpenseReport rep = new ExpenseReport(peopleListBox.SelectedItem);
            rep.Show();

        }
    }
}
