using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace dtDobie
{
    public partial class MainWindow : Window
    {
        private Vehicle vehicle;

        public MainWindow()
        {
            InitializeComponent();
            vehicle = new Vehicle();
        }

        private void CalculateProfit(object sender, RoutedEventArgs e)
        {
            vehicle.Make = MakeTextBox.Text;
            vehicle.Model = ModelTextBox.Text;
            vehicle.EngineNumber = EngineNumberTextBox.Text;
            vehicle.SalePrice = decimal.Parse(SalePriceTextBox.Text);

            decimal profit = vehicle.GetProfit();
            ProfitTextBlock.Text = $"Profit: {profit:C}";
        }
    }
}
