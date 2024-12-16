using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Калькулятор;

namespace CalcEX
{
    /// <summary>
    /// Логика взаимодействия для Engineer.xaml
    /// </summary>
    public partial class Engineer : Window
    {
        double firstNum;
        double secondNum;
        string operat;
        double result;
        Int64 factTarget;
        Int64 factorial = 1;
        public Engineer()
        {
            InitializeComponent();
        }
        public SqrEquation Solver { get; set; }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            Owner.Close();
        }

        
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Owner.Show();            
            this.Hide();
            
        }
        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Solver = new SqrEquation();
            Solver.Owner = this;
            Solver.Show();
        }

        
        private void But1Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "1";
        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "2";
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "3";
        }

        private void But4_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "4";
        }

        private void But5_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "5";
        }

        private void But6_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "6";
        }

        private void But7_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "7";
        }

        private void But8_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "8";
        }

        private void But9_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "9";
        }

        private void But0_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + "0";
        }

        private void ButDec_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = Input.Text + ",";
        }

        private void ButPosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                Input.Text = (double.Parse(Input.Text) * (-1)).ToString();
            }
            
        }
        private void ButDate_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = DateTime.Now.ToString();
        }
        private void ButPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                operat = "+";
                firstNum = double.Parse(Input.Text);

                Input.Text = null;
            }


        }

        private void ButMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                operat = "-";
                firstNum = double.Parse(Input.Text);

                Input.Text = null;
            }

        }

        private void ButDivide_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                operat = "/";
                firstNum = double.Parse(Input.Text);

                Input.Text = null;
            }

        }

        private void ButMult_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                operat = "*";
                firstNum = double.Parse(Input.Text);
                Input.Text = null;
            }

        }

        private void ButtClear_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = null;
        }
        private void ButtPow_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                operat = "pow";
                firstNum = double.Parse(Input.Text);
                Input.Text = null;
            }
            
            
        }
        private void ButtSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                firstNum = double.Parse(Input.Text);
                if (firstNum >= 0)
                {
                    result = Math.Sqrt(firstNum);
                    Input.Text = result.ToString();
                    result = 0;
                }
                else
                {
                    Input.Text = "Error";
                }
            }
            
           
        }
        private void ButtPow2_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                firstNum = double.Parse(Input.Text);
                result = Math.Pow(firstNum, 2);
                Input.Text = result.ToString();
                result = 0;
            }
            
        }
        private void CubRtBut_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                firstNum = double.Parse(Input.Text);
                result = Math.Pow(firstNum, (1 / 3));
                Input.Text = result.ToString();
            }
            
        }
        private void ButResult_Click(object sender, RoutedEventArgs e)
        {
            secondNum = double.Parse(Input.Text);
            switch (operat)
            {
                case "+":
                    result = firstNum + secondNum;
                    Input.Text = result.ToString();
                    firstNum = 0;
                    secondNum = 0;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    Input.Text = result.ToString();
                    firstNum = 0;
                    secondNum = 0;
                    break;
                case "/":
                    if (secondNum != 0)
                    {
                        result = firstNum / secondNum;
                        Input.Text = result.ToString();
                        firstNum = 0;
                        secondNum = 0;
                    }
                    else
                    {
                        Input.Text = "Eror: can't divide by 0";
                    }
                    break;
                case "*":
                    result = firstNum * secondNum;
                    Input.Text = result.ToString();
                    firstNum = 0;
                    secondNum = 0;
                    break;
                case "pow":
                    result = Math.Pow(firstNum, secondNum);
                    Input.Text = result.ToString();
                    firstNum = 0;
                    secondNum = 0;
                    break;
                default:
                    Input.Text = "Eror";
                    break;
            }

        }

        private void ButExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Owner.Close();
        }

        private void ButtReverse_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                    firstNum = double.Parse(Input.Text);
                    result = 1 / firstNum;
                    Input.Text = result.ToString();
                    result = 0;
            }
            
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {            
                try
                {
                    Int64 factTarget;
                    Int64 factorial = 1;
                    factTarget = Int64.Parse(Input.Text);
                    for (int i = 1; i <= factTarget; i++)
                    {
                        factorial = factorial * i;
                    }
                    Factorial.Text = factorial.ToString();
                }
                catch (Exception)
                {
                    Factorial.Text = "Can't calculate factorial";

                }
            
        }

    }
}

