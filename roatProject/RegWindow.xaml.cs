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
        //нужно переделать под номер варианта и цифры студака
        public string strVar { get; set; }
        public decimal intVar { get; set; }

        public float Conversion()
        {
            //для преобразования номера студака в кперсональный коэффициент
            return (float)0.8 * (float)intVar;
        }
    }
    public partial class RegWindow : Window
    {
        public Variant coef { get; set; }

        public RegWindow()
        {
            InitializeComponent();
            ((MainWindow)System.Windows.Application.Current.MainWindow).varLabel.Content = "Вариант ";

            coef = new Variant
            {
                strVar = "abc",
                intVar = 0001
            };

            this.DataContext = coef;
            
        }

        public string Str
        {
            get { return numbBox.Text; }
        }

        private void numbButton_Click(object sender, RoutedEventArgs e)
        {
            string name = numbBox.Text;
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).varLabel.Content += coef.intVar.ToString();
        }
    }
}
