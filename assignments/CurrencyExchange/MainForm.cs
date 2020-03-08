using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, initialPriceInput.Value);

            var calculator = new CurrencyExchangeCalculator((double)initialPriceInput.Value, (int)daysInput.Value);

            foreach (var value in calculator.Start())
            {
                chart1.Series[0].Points.AddXY(value.day, value.price);
            }
        }
    }

    public class CurrencyExchangeCalculator
    {

        const double k = 0.02;

        private readonly Random rnd = new Random();

        private double price;
        private readonly int days;

        public CurrencyExchangeCalculator(double initialPrice, int days)
        {
            this.price = initialPrice;
            this.days = days;
        }

        public IEnumerable<(int day, double price)> Start()
        {
            for (int i = 1; i <= this.days; i++)
            {
                price = price * (1 + k * (rnd.NextDouble() - 0.5));
                yield return (i, price);
            }
        }
    }
}
