using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace roatProject
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    /// 
    public class Variant
    {
        public string strVar { get; set; }
        public decimal intVar { get; set; }
    }
    public partial class RegWindow : Window
    {
        public Variant coef { get; set; }

        public RegWindow()
        {
            InitializeComponent();
            coef = new Variant
            {
                strVar = "abc",
                intVar = 4
            };

            this.DataContext = coef;
            
        }

        public string Str
        {
            get { return numbBox.Text; }
        }

        private void numbButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
