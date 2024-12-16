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

namespace CalcEX
{
    /// <summary>
    /// Логика взаимодействия для SqrEquation.xaml
    /// </summary>
    public partial class SqrEquation : Window
    {
        public SqrEquation()
        {
            InitializeComponent();
        }

        private void BuildEquationBut_Click(object sender, RoutedEventArgs e)
        {
            if (aCoef.Text != "" && bCoef.Text != "" && cCoef.Text != "")
            {
               if (double.Parse(aCoef.Text) != 0 && double.Parse(bCoef.Text) != 0)
                {
                    double a = double.Parse(aCoef.Text);
                    double b = double.Parse(bCoef.Text);
                    double c = double.Parse(cCoef.Text);
                    double D;
                    double x1;
                    double x2;

                    UserEquation.Text = $"{a}*x^2 + ({b})*x + ({c})";

                    D = (Math.Pow(b, 2) - (4 * a * c));
                    switch (D)
                    {
                        case > 0:
                            x1 = Math.Round((b + Math.Sqrt(D)) / (2 * a), 2);
                            x2 = Math.Round((b - Math.Sqrt(D)) / (2 * a), 2);
                            x1Sol.Text = x1.ToString();
                            x2Sol.Text = x2.ToString();
                            break;
                        case 0:
                            x1 = (-b) / (2 * a);
                            x1Sol.Text = x1.ToString();
                            x2Sol.Text = "-";
                            break;
                        case < 0:
                            break;
                        default:
                            break;
                    }
                } 
            }
            else
            {
                UserEquation.Text = "Please enter a, b and c coefficients";
            }


        }
    }
}
