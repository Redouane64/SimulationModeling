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

        private FlyingObjectSimulator sim;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(!sim.MoveNext())
            {
                timer1.Stop();
            }

            PointF current = sim.Current;

            chart1.Series[0].Points.AddXY(current.X, current.Y);

            labDistance.Text = string.Format("Distance: {0:f2}", current.X);

        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.Clear();

                sim = new FlyingObjectSimulator(heightNumericUpDown.Value, weightNumericUpDown.Value, angleNumericUpDown.Value, speedNumericUpDown.Value, sizeNumericUpDown.Value);
                PointF start = sim.Current;

                chart1.Series[0].Points.AddXY(start.X, start.Y);
                timer1.Start();
            }
        }

    }
}
