using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy;

        const decimal g = 9.81m;
        const decimal C = 0.15m;
        const decimal rho = 1.29m;

        const decimal dt = 0.1m;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            t += dt;

            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            chart1.Series[0].Points.AddXY(x, y);

            if (y <= 0)
            {
                timer1.Stop();
            }

            labDistance.Text = string.Format("Distance: {0:f2}", x);
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.Clear();
                t = 0;
                x = 0;
                y = heightNumericUpDown.Value;
                v0 = speedNumericUpDown.Value;

                double a = (double)angleNumericUpDown.Value * Math.PI / 100;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = sizeNumericUpDown.Value;
                m = weightNumericUpDown.Value;
                k = 0.5m * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                chart1.Series[0].Points.AddXY(x, y);
                timer1.Start();
            }
        }

    }
}
