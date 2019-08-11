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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Calculator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

        }
        public string toDo = string.Empty;
        string a = "0";
        //string b = string.Empty;
        char whatchar = ' ';
        void timer_Tick(object sender, EventArgs e)
        {
            if (a == "0")
                display.Text = toDo;
            else if (whatchar == '=')
            {
                display.Text = a;
            }
            else
                display.Text = a + whatchar + toDo;
        }

        private void Button_Click(object sender, RoutedEventArgs e) //1
        {
            if(toDo.Length<5)
            toDo += "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //2
        {
            if (toDo.Length < 5)
                toDo += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //3
        {
            if (toDo.Length < 5)
                toDo += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //CE
        {
            a = "0";
            //b = string.Empty;
            toDo = string.Empty;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //Del1
        {
            toDo = toDo.Remove(toDo.Length - 1);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //4
        {
            if (toDo.Length < 5)
                toDo += "4";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) //5
        {
            if (toDo.Length < 5)
                toDo += "5";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) //6
        {
            if (toDo.Length < 5)
                toDo += "6";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) //*
        {
            if (!(a == "0"))
            {
                
                a = calc.CharCheck(whatchar, a, toDo);
                toDo = string.Empty;
                whatchar = '*';
            }
            else
            {
                whatchar = '*';
                a = toDo;
                toDo = string.Empty;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) ///
        {
            if (!(a == "0"))
            {
                
                a = calc.CharCheck(whatchar, a, toDo);
                toDo = string.Empty;
                whatchar = '/';

            }
            else
            {
                whatchar = '/';
                a = toDo;
                toDo = string.Empty;
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) //7
        {
            if (toDo.Length < 5)
                toDo += "7";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) //8
        {
            if (toDo.Length < 5)
                toDo += "8";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) //9
        {
            if (toDo.Length < 5)
                toDo += "9";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e) //+
        {
            if (!(a == "0"))
            {
                
                a = calc.CharCheck(whatchar, a, toDo);
                toDo = string.Empty;
                whatchar = '+';

            }
            else
            {
                whatchar = '+';
                a = toDo;
                toDo = string.Empty;
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e) //-
        {
            if (!(a == "0"))
            {
                
                a = calc.CharCheck(whatchar, a, toDo);
                toDo = string.Empty;
                whatchar = '-';

            }
            else
            {
                whatchar = '-';
                a = toDo;
                toDo = string.Empty;
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e) //=
        {
            a = calc.CharCheck(whatchar, a, toDo);
            whatchar = '=';

        }

        private void Button_Click_16(object sender, RoutedEventArgs e) //0
        {
            if (toDo.Length < 5)
                toDo += "0";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e) //,
        {

        }

        private void Button_Click_18(object sender, RoutedEventArgs e) //Freebutton
        {

        }

        private void Button_Click_19(object sender, RoutedEventArgs e) //Freebutton
        {

        }
    }
}
