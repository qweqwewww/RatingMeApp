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
    public partial class AddTeacherWindow : Window
    {
        public bool isempty = true;
        public int existUser = 0;
        public Teacher Teacher { get; private set; }

        public AddTeacherWindow(Teacher teacher)
        {
            InitializeComponent();
            Teacher = teacher;
            DataContext = teacher;
        }

        public void AcceptDialog_Click(object sender, RoutedEventArgs e)
        {
            while (isempty)
            {
                if (TeacherPassword.Text.Length == 0 || TeacherFio.Text.Length == 0)
                {
                    MessageBox.Show("Поля не могут быть пустыми", "Попробуйте снова", MessageBoxButton.OK, MessageBoxImage.Warning);
                    break;
                }

                int upCheck = 0, spaceCheck = 0, fioPasswordNum = 0;

                int[] indexUp = new int[3];
                char[] valueUp = new char[3];

                string fiocheck = TeacherFio.Text;
                string pascheck = TeacherPassword.Text;

                for (int i = 0; i < fiocheck.Length; i++)
                {
                    if (char.IsUpper(fiocheck[i]))
                    {
                        if (upCheck < 3)
                        {
                            indexUp[upCheck] = i;
                            valueUp[upCheck] = fiocheck[i];
                        }
                        upCheck++;
                    }

                    if (fiocheck[i] == ' ')
                        spaceCheck++;
                }

                for (int i = 0; i < 3; i++)
                {
                    if (valueUp[i] == pascheck[i])
                        fioPasswordNum++;
                }

                using (TeacherContext db = new TeacherContext())
                {
                    var visitors = db.Teachers.Where(p => p.Fio == TeacherFio.Text);
                    foreach (Teacher visitor in visitors)
                    {
                        if (visitors != null)
                        {
                            MessageBox.Show("Такой пользователь уже существует!", "Попробуйте снова", MessageBoxButton.OK, MessageBoxImage.Warning);
                            existUser++;
                        }
                    }
                }

                if (existUser > 0)
                    break;

                if (upCheck == 3 &&
                    spaceCheck == 2 &&
                    fioPasswordNum == 3 &&
                    pascheck.Length == 8)
                {
                    DialogResult = true;
                    break;
                }
                else
                {
                    MessageBox.Show("Неправильно введено ФИО или Пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                }
            }
        }
    }
}

