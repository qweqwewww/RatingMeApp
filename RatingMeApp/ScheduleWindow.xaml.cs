using Microsoft.EntityFrameworkCore;
using RatingMeApp.Bases.ScheduleBase;
using RatingMeApp.Bases.TeacherBase;
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
        ScheduleContext db1 = new ScheduleContext();
        public int numClick = 1;
        public ScheduleWindow()
        {
            InitializeComponent();

            Loaded += ScheduleWindow_Loaded;

        }

        private void ScheduleWindow_Loaded(object sender, RoutedEventArgs e)
        {
            db1.Database.EnsureDeleted();
            db1.Database.EnsureCreated();
            db1.Dates.Load();
            db1.Schedules.Load();
            ChooseList.DataContext = db1.Dates.Local.ToObservableCollection();
            DayList.DataContext = db1.Schedules.Local.ToObservableCollection();
        }

        public void ClickCheck()
        {
            if (numClick == 1)
                ChooseList.Visibility = Visibility.Visible;

            if (numClick > 1)
            {
                ChooseList.Visibility = Visibility.Hidden;
                numClick = 0;
            }
        }

        public void TakeDate_Click(object sender, EventArgs e)
        {
            ClickCheck();

            numClick++;
        }

        public void LoadDate_Click(object sender, EventArgs e)
        {
            //// Загружаем все данные (например, при инициализации контекста)
            //var allSchedules = db1.Schedules.Local.ToObservableCollection();

            //// Создаем представление для коллекции
            //var view = CollectionViewSource.GetDefaultView(allSchedules);

            //// Задаем фильтр: например, выбираем только записи с IsActive == true
            //view.Filter = o =>
            //{
            //    var schedule = o as Schedule;
            //    return schedule != null && schedule.IsActive;
            //};

            //// Привязываем отфильтрованное представление к ListBox
            //DayList.DataContext = view;

            var AllData = db1.Schedules.Local.ToObservableCollection();

            var Viewdata = CollectionViewSource.GetDefaultView(AllData);

            Viewdata.Filter = f =>
            {
                var schedulev = f as Schedule;
                return schedulev != null && schedulev.CheckDate == Convert.ToString(DatePlace.Content);
            };

            DayList.DataContext = Viewdata;


            //db1.Schedules.Where(d => d.CheckDate == Convert.ToString(DatePlace.Content)).Load();
            //using (ScheduleContext db = new ScheduleContext())
            //{
            //    var days = db.Schedules.Where(d => d.CheckDate == Convert.ToString(DatePlace.Content));
            //    foreach (Schedule day in days)
            //    {

            //        //if (day.CheckDate == Convert.ToString(DatePlace.Content))
            //        //{
            //        //    MessageBox.Show(day.CheckDate);


            //        //}

            //    }
            //}
        }

        public void SelectedDate(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("1");
        }

        public void BaseDate_Click(object sender, EventArgs e)
        {
            //Teacher? teacher = teacherList.SelectedItem as Teacher;
            //Date? date = ChooseList.SelectedItem as Date;
            //if (date is null) return;

            //DatePlace.Content = date.SetDate;

            
            //Date? date = ChooseList.SelectedItem as Date;
            //if (date is null) return;
            //DatePlace.Content = date.SetDate;

            //using (TeacherContext db = new TeacherContext())
            //{
            //    var visitors = db.Teachers.Where(p => p.Fio == TeacherFio.Text);
            //    foreach (Teacher visitor in visitors)
            //    {
            //        if (visitors != null)
            //        {
            //            MessageBox.Show("Такой пользователь уже существует!", "Попробуйте снова", MessageBoxButton.OK, MessageBoxImage.Warning);
            //            existUser++;
            //        }
            //    }
            //}


            //db1.Schedules.Load();


            //AddTeacherWindow AddTeacherWindow = new AddTeacherWindow(new Teacher
            //{
            //    TeacherId = teacher.TeacherId,
            //    Fio = teacher.Fio,
            //    Password = teacher.Password
            //});

            //if (AddTeacherWindow.ShowDialog() == true)
            //{
            //    teacher = db.Teachers.Find(AddTeacherWindow.Teacher.TeacherId);
            //    if (teacher != null)
            //    {
            //        teacher.Fio = AddTeacherWindow.Teacher.Fio;
            //        teacher.Password = AddTeacherWindow.Teacher.Password;
            //        db.SaveChanges();
            //        teacherList.Items.Refresh();
            //    }
            //}

        }

        public void AddDate_Click(object sender, RoutedEventArgs e)
        {
            AddDateWindow AddDateWindow = new AddDateWindow(new Date());
            if (AddDateWindow.ShowDialog() == true)
            {
                Date Date = AddDateWindow.Date;
                db1.Dates.Add(Date);
                db1.SaveChanges();
            }
        }

        private void RemoveDate_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Close_CLick(object sender, EventArgs e)
        {
            StudentWindow studentWindow = new StudentWindow();
            studentWindow.Show();
            this.Close();
        }

        public void AddDay_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(DatePlace.Content) != "Дата")
            {
                AddDayWindow AddDayWindow = new AddDayWindow(new Schedule());
                if (AddDayWindow.ShowDialog() == true)
                {
                    Schedule Schedule = AddDayWindow.Schedule;
                    Schedule.CheckDate = Convert.ToString(DatePlace.Content);
                    db1.Schedules.Add(Schedule);
                    db1.SaveChanges();
                }
            }

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
