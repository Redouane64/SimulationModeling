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

        private readonly Dictionary<CheckBox, Cell> farm = new Dictionary<CheckBox, Cell>();

        public MainForm()
        {
            InitializeComponent();

            // Attch click handler to CheckBox controls
            var checkBoxes = FourByFourFarm.Controls.OfType<CheckBox>().ToArray();
            foreach (var checkbox in checkBoxes)
            {
                checkbox.Click += new EventHandler(CheckBox_Clicked);
                checkbox.BackColor = Color.White;

                farm.Add(checkbox, new Cell());
            }

        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox_Clicked(object sender, EventArgs e)
        {
            var clickedCheckBox = sender as CheckBox;
            var cell = farm[clickedCheckBox];
            
            if(cell.Status == CellStatus.Empty)
            {
                cell.Plant();
            }
            else
            {
                cell.Harvest();
            }

            clickedCheckBox.BackColor = cell.GetColor();
        }

        private void Time_Tick(object sender, EventArgs e)
        {

        }

    }
}
