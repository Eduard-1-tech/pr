using System;
using System.Collections.Generic;
using System.Data;
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
using yk1.yk1DataSetTableAdapters;
namespace yk1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        stuffTableAdapter stuff = new stuffTableAdapter();





        public MainWindow()
        {
            InitializeComponent();
            datagrid.ItemsSource = stuff.GetData();
           
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            second window = new second();
            window.ShowDialog();
        }

        

        

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var sel =datagrid.SelectedItem as DataRowView;
            stuff.DeleteQuery((int)sel.Row[0]);
            datagrid.ItemsSource = stuff.GetData();
        }

        private void dobavl_Click(object sender, RoutedEventArgs e)
        {
            
            if (name.Text != "" && surname.Text != "" && last.Text != "")
            {
                stuff.InsertQuery(name.Text, surname.Text, last.Text);
                datagrid.ItemsSource = stuff.GetData();
                name.Text = "";
                surname.Text = "";
                last.Text = "";
               
            }
        }
    }
}
