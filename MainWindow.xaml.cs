using CalcEX;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Калькулятор
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNum;
        double secondNum;
        string operat;
        double result;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        public Engineer Eng1 { get; set; }

        public SqrEquation Solver { get; set; }

        public void ExchangeText1()
        {
            Eng1.Input.Text = this.Input.Text;
        }
        
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            if (Eng1 != null)
            {
                Eng1.Close();
            }
        }

        
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Eng1 = new Engineer();
            Eng1.Owner = this;            
            Eng1.Show();
            ExchangeText1();
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
            if (true)
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
        private void ButResult_Click(object sender, RoutedEventArgs e)
        {
            secondNum = double.Parse(Input.Text);
            switch (operat)
            {
                case "+": result = firstNum + secondNum;
                    Input.Text = result.ToString();
                    firstNum = 0;
                    secondNum = 0;
                    break;
                case "-": result = firstNum - secondNum;
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
                case "*": result = firstNum * secondNum;
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
            if (Eng1 != null)
            {
                Eng1.Close();
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