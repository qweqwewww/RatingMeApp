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
    public partial class AddTeacherWindow : Window
    {
        //public bool isemptybox = true;
        //public int existUser = 0;
        //public Visitor Visitor { get; private set; }

        //public DialogUserWindow(Visitor visitor)
        public AddTeacherWindow()
        {
            InitializeComponent();
            //Visitor = visitor;
            //DataContext = Visitor;
        }

        public void AcceptDialog_Click(object sender, RoutedEventArgs e)
        {
            //if (VisitorPas.Text.Length == 5)
            //    DialogResult = true;
            //else MessageBox.Show("Неправильно введено ФИО или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            //while (isemptybox)
            //{
            //    if (VisitorPas.Text.Length == 0 || VisitorFio.Text.Length == 0)
            //    {
            //        MessageBox.Show("Поля не могут быть пустыми", "Попробуйте снова", MessageBoxButton.OK, MessageBoxImage.Warning);
            //        break;
            //    }

            //    int zagcheck = 0, spacecheck = 0, fiopasnum = 0;

            //    int[] indexzag = new int[3];
            //    char[] valuezag = new char[3];

            //    string fiocheck = VisitorFio.Text;
            //    string pascheck = VisitorPas.Text;

            //    for (int i = 0; i < fiocheck.Length; i++)
            //    {
            //        if (char.IsUpper(fiocheck[i]))
            //        {
            //            if (zagcheck < 3)
            //            {
            //                indexzag[zagcheck] = i;
            //                valuezag[zagcheck] = fiocheck[i];
            //            }
            //            zagcheck++;
            //        }

            //        if (fiocheck[i] == ' ')
            //            spacecheck++;
            //    }

            //    for (int i = 0; i < 3; i++)
            //    {
            //        if (valuezag[i] == pascheck[i])
            //            fiopasnum++;
            //    }

            //    using (VisitorContext db = new VisitorContext())
            //    {
            //        var visitors = db.Visitors.Where(p => p.Fio == VisitorFio.Text);
            //        foreach (Visitor visitor in visitors)
            //        {
            //            if (visitors != null)
            //            {
            //                MessageBox.Show("Такой пользователь уже существует!", "Попробуйте снова", MessageBoxButton.OK, MessageBoxImage.Warning);
            //                existUser++;
            //            }
            //        }
            //    }

            //    if (existUser > 0)
            //        break;

            //    if (zagcheck == 3 &&
            //        spacecheck == 2 &&
            //        fiopasnum == 3 &&
            //        pascheck.Length == 8)
            //    {
            //        DialogResult = true;
            //        break;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Неправильно введено ФИО или Пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //        break;
            //    }
        }
    }
}

