using Microsoft.EntityFrameworkCore;
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

namespace RatingMeApp.Windows
{
    public partial class AdminWindow : Window
    {
        TeacherContext db = new TeacherContext();
        public AdminWindow()
        {
            InitializeComponent();

            Loaded += AdminWindow_Loaded;
        }

        private void AdminWindow_Loaded(object sender, RoutedEventArgs e)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            db.Teachers.Load();
            DataContext = db.Teachers.Local.ToObservableCollection();
        }

        private void AddTeacher_Click(object sender, RoutedEventArgs e)
        {
            AddTeacherWindow AddTeacherWindow = new AddTeacherWindow(new Teacher());
            if (AddTeacherWindow.ShowDialog() == true)
            {
                Teacher Teacher = AddTeacherWindow.Teacher;
                db.Teachers.Add(Teacher);
                db.SaveChanges();
            }
        }

        private void EditTeacher_Click(object sender, RoutedEventArgs e)
        {
            Teacher? teacher = teacherList.SelectedItem as Teacher;
            if (teacher is null) return;

            AddTeacherWindow AddTeacherWindow = new AddTeacherWindow(new Teacher
            {
                TeacherId = teacher.TeacherId,
                Fio = teacher.Fio,
                Password = teacher.Password
            });

            if (AddTeacherWindow.ShowDialog() == true)
            {
                teacher = db.Teachers.Find(AddTeacherWindow.Teacher.TeacherId);
                if (teacher != null)
                {
                    teacher.Fio = AddTeacherWindow.Teacher.Fio;
                    teacher.Password = AddTeacherWindow.Teacher.Password;
                    db.SaveChanges();
                    teacherList.Items.Refresh();
                }
            }
        }

        private void DeleteTeacher_Click(object sender, RoutedEventArgs e)
        {
            Teacher? teacher = teacherList.SelectedItem as Teacher;
            if (teacher is null) return;
            db.Teachers.Remove(teacher);
            db.SaveChanges();
        }
    }
}
