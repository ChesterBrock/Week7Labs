/// Chapter No. 7		Exercise No. 1
/// File Name: MainWindow.xaml.cs
/// @author: Chester Brock 
/// Date:  Oct 15, 2021
///
/// Problem Statement: Create a simple GUI that accepts a left hand value and a right hand value.
/// 
/// 
/// 
/// Overall Plan:
/// 1) Place three text boxes, one for right number, left number, and result 
/// 2) place a list box that holds +,-,*,/,%
/// 3) place a button that will convert the answer when clicked 
/// 4) in a switch statement, calculate the results for each selection 
/// 5) display the answer in the result text box.
///

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

namespace Lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Operation = ListBox.SelectedIndex;
                decimal leftHand = Convert.ToDecimal(leftTextBox.Text);
                decimal rightHand = Convert.ToDecimal(rightTextBox.Text);
                decimal result = 0;
                switch (Operation)
                {
                    case 0:
                        result = leftHand + rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 1:
                        result = leftHand - rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 2:
                        result = leftHand * rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 3:
                        result = leftHand / rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 4:
                        result = leftHand % rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("No Operation selected");
                        break;
                }

            }// try block 
            catch (DivideByZeroException)
            {
                MessageBox.Show("error: Can not devide by zero");
            }


     

        }
    }
}
