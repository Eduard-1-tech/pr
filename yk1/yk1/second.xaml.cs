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
using System.Windows.Shapes;
using System.Xml.Linq;
using yk1.yk1DataSetTableAdapters;

namespace yk1
{
    /// <summary>
    /// Логика взаимодействия для second.xaml
    /// </summary>
    public partial class second : Window
    {

        shopTableAdapter shop = new shopTableAdapter();
        stuffTableAdapter stuff = new stuffTableAdapter();
        public second()
        {
            InitializeComponent();

            datagrid2.ItemsSource = shop.GetData();

           // box.ItemsSource = shop.GetData();

            //box.DisplayMemberPath = "adress";

            stid.ItemsSource = stuff.GetData();
            stid.DisplayMemberPath = "stuff_id";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void dobavl_Click(object sender, RoutedEventArgs e)
        {
            string inputString3 = stid.Text;
            string inputString1 =start.Text; // получаем введенную строку от пользователя
            string inputString2 =end.Text; // получаем введенную строку от пользователя
            string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d$"; // задаем регулярное выражение
            string pattern2 = @"^[1-9][0-9]*$";

            if (System.Text.RegularExpressions.Regex.IsMatch(inputString1, pattern) && System.Text.RegularExpressions.Regex.IsMatch(inputString2, pattern) && System.Text.RegularExpressions.Regex.IsMatch(inputString3, pattern2))
            {
                if (box.Text != "" && start.Text != "" && end.Text != "" && stid.Text != "")
                {

                    shop.InsertQuery(box.Text, start.Text, end.Text, Convert.ToInt32(stid.Text));
                    datagrid2.ItemsSource = shop.GetData();
                    start.Text = "";
                    end.Text = "";
                    stid.Text = "";
                }

            }


            
        }

        

        private void box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
        }

        private void q_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid2.SelectedItem != null)
            {
                var sel = datagrid2.SelectedItem as DataRowView;
                shop.DeleteQuery((int)sel.Row[0]);
                datagrid2.ItemsSource = shop.GetData();
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            string inputString3 = stid.Text;
            string inputString1 = start.Text; // получаем введенную строку от пользователя
            string inputString2 = end.Text; // получаем введенную строку от пользователя
            string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d$"; // задаем регулярное выражение
            string pattern2 = @"^[1-9][0-9]*$";
            if (datagrid2.SelectedItem != null)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(inputString1, pattern) && System.Text.RegularExpressions.Regex.IsMatch(inputString2, pattern) && System.Text.RegularExpressions.Regex.IsMatch(inputString3, pattern2))
                {
                    if (box.Text != "" && start.Text != "" && end.Text != "" && stid.Text != "")
                    {
                        object id = (datagrid2.SelectedItem as DataRowView).Row[0];
                        shop.UpdateQuery(box.Text, start.Text, end.Text, Convert.ToInt32(stid.Text), Convert.ToInt32(id));
                        datagrid2.ItemsSource = shop.GetData();
                    }
                }
                box.Text = "";
                start.Text = "";
                end.Text = "";
                stid.Text = "";
            }
        }

        private void datagrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datagrid2.SelectedItem != null)
            {
                box.Text = ((datagrid2.SelectedItem as DataRowView).Row[1]).ToString();
                start.Text = ((datagrid2.SelectedItem as DataRowView).Row[2]).ToString();
                end.Text = ((datagrid2.SelectedItem as DataRowView).Row[3]).ToString();
                stid.Text= ((datagrid2.SelectedItem as DataRowView).Row[4]).ToString();

            }
        }
    }
}
