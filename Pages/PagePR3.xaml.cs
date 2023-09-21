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
    /// Логика взаимодействия для PagePR3.xaml
    /// </summary>
    public partial class PagePR3 : Page
    {
        public PagePR3()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Add("Выполнил Суханов А. С.");
            lstResult.Items.Add("Вариант-19");
            double X0 = double.Parse(txtX0.Text);
            double Xk = double.Parse(txtXk.Text);
            double Dx = double.Parse(txtDx.Text);

            for (double x = X0; x < Xk; x += Dx)
            {
                double y = Math.Pow(Math.Log10(Math.Sin(Math.Pow(x, 3) + 0.0025)), 1.5) + 0.8 * 10;// с этой формулой не работает, возможно формула указана неккоректно
                //double y = Math.Pow(x, 2);// с этой легкой формулой работает
                lstResult.Items.Add($"X={x}");
                lstResult.Items.Add($"Y={y}");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            txtX0.Clear();
            txtDx.Clear();
            txtXk.Clear();
            lstResult.Items.Clear();
        }
    }
}
