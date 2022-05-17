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

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";

            ListBoxItem david = new ListBoxItem();
            james.Content = "David";
            peopleListBox.Items.Add(james);
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {

            //     string s = "";
            //    foreach (var item in myGrid.Children) {
            //       if (item is TextBox) {
            //           s += ((TextBox)item).Text + Environment.NewLine;
            //       }
            //   }
            //       MessageBox.Show("Здрасти " +s);

            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
        }

        private void greetingButton_Click(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}
