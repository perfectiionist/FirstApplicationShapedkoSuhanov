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
    /// Логика взаимодействия для PagePR7.xaml
    /// </summary>
    public partial class PagePR7 : Page
    {
        public PagePR7()
        {
            InitializeComponent();
        }

        private void btnResultMas_Click(object sender, RoutedEventArgs e)
        {
            lstMasResult.Items.Add("Числа, которые дают остаток 1,2,5 при делении на 7");
            for (int i = 0; i < 20; i++)
            {
                if (mas[i] % 7 == 1 || mas[i] % 7 == 2 || mas[i] % 7 == 5)
                {
                    lstMasResult.Items.Add(mas[i]);
                }
            }
        }

        int[] mas = new int[100];
        private void btnMas_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            string i1 = "";
            for (int i = 0; i < 20; i++)
            {
                mas[i] = rnd.Next(101);
                i1 = "mas[" + i.ToString() + "] = " + mas[i].ToString();
                lstMas.Items.Insert(i, i1);
            }
        }
    }
}
