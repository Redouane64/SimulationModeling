using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrowingVegetables.Window
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Attch click handler to CheckBox controls
            foreach(var checkbox in FourByFourFarm.Controls.OfType<CheckBox>())
            {
                checkbox.Click += new EventHandler(CheckBox_Clicked);
            }
        }

        private void CheckBox_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
