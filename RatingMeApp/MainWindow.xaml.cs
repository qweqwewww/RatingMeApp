using Microsoft.EntityFrameworkCore;
using RatingMeApp.Windows;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RatingMeApp
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Close_CLick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Admin_Click(object sender, EventArgs e)
        {
            //ShowBaseWindow showBaseWindow = new ShowBaseWindow();
            //showBaseWindow.Show();

            AdminWindow adminWindow = new AdminWindow();
            adminWindow.ShowDialog();

            //DialogUserEditWindow dialogUserEditWindow = new DialogUserEditWindow();
            //dialogUserEditWindow.ShowDialog();

            //DialogUserWindow DialogUserWindow = new DialogUserWindow(new Visitor());
            //if (DialogUserWindow.ShowDialog() == true)
            //{
            //    Visitor Visitor = DialogUserWindow.Visitor;
            //    db.Visitors.Add( Visitor );
            //    db.SaveChanges();
            //}

            //using (AppContext db = new AppContext())
            //{
            //    var users = db.Users.Where(p => p.Fio == FIO.Text);
            //    foreach (User user in users)
            //        if (users != null)
            //        {
            //            ShowBaseWindow showBaseWindow = new ShowBaseWindow();
            //            showBaseWindow.Show();
            //        }
            //}
        }

        public void ClearFio_Click(object sender, EventArgs e)
        {
            FIO.Clear();
        }

        public void ClearPassword_Click(object sender, EventArgs e)
        {
            PAS.Clear();
        }

        public void FocusCheck(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (FIO.Text.Length == 0)
                FIO.Text = "Введите ФИО";
            if (PAS.Text.Length == 0)
                PAS.Text = "Введите пароль";
        }

        public void Info_Click(object sender, EventArgs e)
        {
            InformationWindow informationWindow = new InformationWindow();
            informationWindow.ShowDialog();
        }

        private void StudentEnter_Click(object sender, RoutedEventArgs e)
        {
            StudentWindow studentWindow = new StudentWindow();
            studentWindow.Show();
            this.Close();
        }
    }
}