﻿using RatingMeApp.Bases.ScheduleBase;
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
    public partial class AddDateWindow : Window
    {
        public Date Date { get; private set; }
        public AddDateWindow(Date date)
        {
            InitializeComponent();
            Date = date;
            DataContext = Date;
        }
        public void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
