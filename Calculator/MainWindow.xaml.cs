using System;
using System.Data;
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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement element in Calculator.Children)
            {
                if(element is Button)
                {
                   ((Button)element).Click += Button_Click;
                }
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Stroka = (String)((Button)e.OriginalSource).Content;

            if (Stroka == "Clear")
                textLabel.Text = "";
            else if(Stroka == "=")
            {
                string Math = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = Math;
            }
            
            
            else
            textLabel.Text += Stroka;


        }
    }
}
