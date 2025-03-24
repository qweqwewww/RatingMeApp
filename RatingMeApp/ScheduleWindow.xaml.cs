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
    public partial class ScheduleWindow : Window
    {
        //ScheduleContext db1 = new ScheduleContext();

        public int colClick = 1;
        public ScheduleWindow()
        {
            InitializeComponent();

            //Loaded += Loadd;
        }

        private void ScheduleWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //db1.Database.EnsureDeleted();
            //db1.Database.EnsureCreated();
            //db1.Schedules.Load();
            //db1.Daus.Load();
            //ChooseList.DataContext = db1.Daus.Local.ToObservableCollection();
            //scList.DataContext = db1.Schedules.Local.ToObservableCollection();
        }

        public void ClickCheck()
        {
            if (colClick == 1)
                ChooseList.Visibility = Visibility.Visible;

            if (colClick > 1)
            {
                ChooseList.Visibility = Visibility.Hidden;
                colClick = 0;
            }
        }

        public void TakeDate_Click(object sender, EventArgs e)
        {
            ClickCheck();

            colClick++;
        }

        public void BaseDate_Click(object sender, EventArgs e)
        {

        }

        public void AddDate_Click(object sender, RoutedEventArgs e)
        {
            //DatAdd DatAdd = new DatAdd(new Dau());
            //if (DatAdd.ShowDialog() == true)
            //{
            //    Dau Dau = DatAdd.Dau;
            //    db1.Daus.Add(Dau);
            //    db1.SaveChanges();
            //}
        }

        public void Close_CLick(object sender, EventArgs e)
        {
            //StudentMainWindow studentMainWindow = new StudentMainWindow();
            //studentMainWindow.Show();
            //this.Close();
        }

        public void AddDay_Click(object sender, EventArgs e)
        {
            //AddWeek AddWeek = new AddWeek(new Schedule());
            //if (AddWeek.ShowDialog() == true)
            //{
            //    Schedule Schedule = AddWeek.Schedule;
            //    db1.Schedules.Add(Schedule);
            //    db1.SaveChanges();
            //}
        }

        public void RemoveDay_Click(object sender, EventArgs e)
        {
            //Schedule? schedule = scList.SelectedItem as Schedule;
            //if (schedule is null) return;
            //db1.Schedules.Remove(schedule);
            //db1.SaveChanges();
            //Visitor? visitor = visitorsList.SelectedItem as Visitor;
            //if (visitor is null) return;
            //db.Visitors.Remove(visitor);
            //db.SaveChanges();
        }
    }
}
