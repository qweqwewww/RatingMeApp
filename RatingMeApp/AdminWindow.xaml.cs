using Microsoft.EntityFrameworkCore;
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
        //VisitorContext db = new VisitorContext();
        public AdminWindow()
        {
            InitializeComponent();

            Loaded += AdminWindow_Loaded;
        }

        private void AdminWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //db.Database.EnsureCreated();
            //db.Visitors.Load();
            //DataContext = db.Visitors.Local.ToObservableCollection();
        }

        private void AddTeacher_Click(object sender, RoutedEventArgs e)
        {
            //DialogUserWindow DialogUserWindow = new DialogUserWindow(new Visitor());
            //if (DialogUserWindow.ShowDialog() == true)
            //{
            //    Visitor Visitor = DialogUserWindow.Visitor;
            //    db.Visitors.Add(Visitor);
            //    db.SaveChanges();
            //}
        }

        private void EditTeacher_Click(object sender, RoutedEventArgs e)
        {
            //Visitor? visitor = visitorsList.SelectedItem as Visitor;
            //if (visitor is null) return;

            //DialogUserWindow DialogUserWindow = new DialogUserWindow(new Visitor
            //{
            //    Id = visitor.Id,
            //    Fio = visitor.Fio,
            //    Pas = visitor.Pas
            //});

            //if (DialogUserWindow.ShowDialog() == true)
            //{
            //    visitor = db.Visitors.Find(DialogUserWindow.Visitor.Id);
            //    if (visitor != null)
            //    {
            //        visitor.Fio = DialogUserWindow.Visitor.Fio;
            //        visitor.Pas = DialogUserWindow.Visitor.Pas;
            //        db.SaveChanges();
            //        visitorsList.Items.Refresh();
            //    }
            //}

            //User? user = usersList.SelectedItem as User;
            //// если ни одного объекта не выделено, выходим
            //if (user is null) return;

            //UserWindow UserWindow = new UserWindow(new User
            //{
            //    Id = user.Id,
            //    Age = user.Age,
            //    Name = user.Name
            //});

            //if (UserWindow.ShowDialog() == true)
            //{
            //    // получаем измененный объект
            //    user = db.Users.Find(UserWindow.User.Id);
            //    if (user != null)
            //    {
            //        user.Age = UserWindow.User.Age;
            //        user.Name = UserWindow.User.Name;
            //        db.SaveChanges();
            //        usersList.Items.Refresh();
            //    }
            //}
        }
        // удаление
        private void DeleteTeacher_Click(object sender, RoutedEventArgs e)
        {
            //Visitor? visitor = visitorsList.SelectedItem as Visitor;
            //if (visitor is null) return;
            //db.Visitors.Remove(visitor);
            //db.SaveChanges();
            //// получаем выделенный объект
            //User? user = usersList.SelectedItem as User;
            //// если ни одного объекта не выделено, выходим
            //if (user is null) return;
            //db.Users.Remove(user);
            //db.SaveChanges();
        }
    }
}
