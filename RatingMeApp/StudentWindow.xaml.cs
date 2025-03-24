using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace RatingMeApp
{
    public partial class StudentWindow : Window
    {
        public int colClick = 1;

        public StudentWindow()
        {
            InitializeComponent();
        }

        public void Close_CLick(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Burger_Click(object sender, RoutedEventArgs e)
        {
            ClickCheck();

            colClick++;
        }

        public void ClickCheck()
        {
            if (colClick == 1)
                ExpandBurger.Visibility = Visibility.Visible;

            if (colClick > 1)
            {
                ExpandBurger.Visibility = Visibility.Hidden;
                colClick = 0;
            }
        }

        private void AddPicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri uri = new Uri(openFileDialog.FileName);
                ProfilePic.Source = new BitmapImage(uri);
            }
        }

        private void EditPassword_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditWin_Click(object sender, RoutedEventArgs e)
        {
            InfoStudent.Visibility = Visibility.Hidden;
            InfoGroup.Visibility = Visibility.Hidden;
            AddPicture.Visibility = Visibility.Visible;
            EditPassword.Visibility = Visibility.Visible;
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            InfoStudent.Visibility = Visibility.Visible;
            InfoGroup.Visibility = Visibility.Visible;
            AddPicture.Visibility = Visibility.Hidden;
            EditPassword.Visibility = Visibility.Hidden;
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            ScheduleWindow scheduleWindow = new ScheduleWindow();
            scheduleWindow.Show();
            this.Close();
        }
    }
}
