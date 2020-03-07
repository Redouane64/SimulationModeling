using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Flight
{
    public partial class MainForm : Form
    {
        private readonly Series series;

        public MainForm()
        {
            InitializeComponent();

            // Setup.
            series = flightChart.Series[0];
        }

        private decimal t, x0, y0, v0, cosa, sina;
        private bool isRunning = false;

        private void PauseButton_Click(object sender, EventArgs e)
        {
            pauseButton.Text = (isRunning = !isRunning) ? "Pause" : "Resume";
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (!simulationTime.Enabled)
            {
                series.Points.Clear();
                t = 0;
                x0 = 0;
                y0 = heightNumericUpDown.Value;
                v0 = speedNumericUpDown.Value;

                double a = (double)angelNumericUpDown.Value * Math.PI / 100;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);

                series.Points.AddXY(x0, y0);
                simulationTime.Start();

                isRunning = true;
                launchButton.Enabled = false;
            }
        }

        const decimal g = 9.81M;
        const decimal dt = 0.1M;

        private void SimulationTime_Tick(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                return;
            }

            t += dt;

            timeTextBox.Text = t.ToString("f2");

            decimal x = x0 + v0 * cosa * t;
            decimal y = y0 + v0 * sina * t - g * t * t / 2;
            series.Points.AddXY(x, y);

            if (y <= 0)
            {
                simulationTime.Stop();
                isRunning = false;
                launchButton.Enabled = true;
            }
        }

    }
}
