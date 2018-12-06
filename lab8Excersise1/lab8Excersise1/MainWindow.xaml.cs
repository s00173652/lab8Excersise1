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

namespace lab8Excersise1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //Clear All Text Fields
            tblkSNum.Text = "";
            tblkResult.Text = "";

            //Creating the first random number
            int iNum = rand.Next(1, 21);
            tblkINum.Text = iNum.ToString();

        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            //Checking if user selected Bigger or Smaller
            bool userSelectedB = radioBigger.IsChecked.Equals(true);
            bool userSelectedS = radioSmaller.IsChecked.Equals(true);

            //Generating Second Random Number
            int sNum = rand.Next(1, 21);

            //Display it to Screen
            tblkSNum.Text = sNum.ToString();

            //Compare Numbers
            bool numberIsBigger = false, numberIsSmaller = false, numbersAreEqual = false;
            int iNum = Convert.ToInt32(tblkINum.Text);

            if(sNum > iNum)
            {
                numberIsBigger = true;
            }
            else if(sNum < iNum)
            {
                numberIsSmaller = true;
            }
            else
            {
                numbersAreEqual = true;
            }

            //Check if User was Right
            if(userSelectedB && numberIsBigger)
            {
                tblkResult.Text = "You Win";
            }
            else if(userSelectedS && numberIsSmaller)
            {
                tblkResult.Text = "You Win";
            }
            else
            {
                tblkResult.Text = "You Lose";
            }

        }
    }
}
