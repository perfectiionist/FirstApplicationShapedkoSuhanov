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

namespace FirstApplicationShapedkoSuhanov.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR2.xaml
    /// </summary>
    public partial class PagePR2 : Page
    {
        public PagePR2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double p = double.Parse(txtP.Text);
            double l;
            lstResult.Items.Add("Лаб.раб.№2. Выполнил Суханов А.С.");
            lstResult.Items.Add("Вариант-9");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"P={p}");
            int n = 0;
            if (rbtSqrX.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if (x > Math.Abs(p)) l = 2 * Math.Pow(Math.Sin(x), 3) + 3 * Math.Pow(p, 2);
                    else if (x > 3 & x < Math.Abs(p)) l = Math.Abs(Math.Sin(x) - p);
                    else l = Math.Pow(Math.Sin(x) - p, 2);
                    lstResult.Items.Add($"Результат l={Math.Round(l, 3)}");
                    break;
                case 1:
                    if (x > Math.Abs(p)) l = 2 * Math.Pow(x, 6) + 3 * Math.Pow(p, 2);
                    else if (x > 3 & x < Math.Abs(p)) l = Math.Abs(Math.Pow(x, 2) - p);
                    else l = Math.Pow(Math.Pow(x, 2) - p, 2);
                    lstResult.Items.Add($"Результат l={Math.Round(l, 3)}");
                    break;
                case 2:
                    if (x > Math.Abs(p)) l = 2 * Math.Pow(Math.Exp(x), 3) + 3 * Math.Pow(p, 2);
                    else if (x > 3 & x < Math.Abs(p)) l = Math.Abs(Math.Exp(x) - p);
                    else l = Math.Pow(Math.Exp(x) - p, 2);
                    lstResult.Items.Add($"Результат l={Math.Round(l, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;

            }

            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtP.Clear();
            lstResult.Items.Clear();
        }
    }
}
