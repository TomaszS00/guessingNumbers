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

namespace guessingNumbers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txt.Text = string.Empty;
            
           

        }

        private void draw_button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int rightNum = rnd.Next(0, 10);
            var UserNum;

            //try catch przechwytuje wyjątki jeśli user poda np litere zamiast cyfry
            try
            {
                UserNum = Int32.Parse(txt.Text);
                Console.WriteLine("Conversion succeeded.");
            }
            catch(InvalidCastException)
            {
                Console.WriteLine("Conversion failed.");
            }
            

            if(UserNum >= 0 && UserNum < 10)
            {
                UserAnswer.Text = "Your answer is " + UserNum;

                if(UserNum == rightNum)
                    answer.Text = "Correct answer";
                else
                    answer.Text = "Correct answer is " + rightNum + "\ntry again!";
            }
            else
            {
                answer.Text = "Incorrect number, try again";
            }
            
        }
    }
}
