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

namespace Mamaev_pr23._06
{
    /// <summary>
    /// Логика взаимодействия для RequestsPartnerPage.xaml
    /// </summary>
    public partial class RequestsPartnerPage : Window
    {
        public RequestsPartnerPage()
        {
            InitializeComponent();
        }

        public class Partner
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Director { get; set; }
            public string Phone { get; set; }
            public int Rating { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public int TotalSales { get; set; } 

           
            public double CalculateDiscount()
            {
                if (TotalSales < 10000) return 0;
                if (TotalSales < 50000) return 0.05;
                if (TotalSales < 300000) return 0.10;
                return 0.15;
            }
        }
        private void DataGridRequest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
