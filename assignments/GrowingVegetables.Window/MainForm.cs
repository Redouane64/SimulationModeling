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

        private readonly Dictionary<CheckBox, Cell> items = new Dictionary<CheckBox, Cell>();
        private readonly Game game;

        public MainForm()
        {
            InitializeComponent();

            // Attch click handler to CheckBox controls
            var checkBoxes = Container.Panel2.Controls.OfType<CheckBox>().ToArray();
            foreach (var checkbox in checkBoxes)
            {
                checkbox.Click += new EventHandler(CheckBox_Clicked);
                checkbox.BackColor = Color.White;

                items.Add(checkbox, new Cell());
            }

            // Initialize the game.
            game = new Game();

            // Register handlers to current game status.
            game.OnMoneyValueChanged += new EventHandler<int>(OnGameMoneyValueChanged);

            // Update money textbox with the starting amount.
            moneyTextBox.Text = game.Money.ToString();
        }

        private void OnGameMoneyValueChanged(object sender, int money)
        {
            moneyTextBox.Text = money.ToString();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox_Clicked(object sender, EventArgs e)
        {
            var clickedCheckBox = sender as CheckBox;
            var cell = items[clickedCheckBox];
            
            if(cell.Status == CellStatus.Empty)
            {
                if(!cell.Plant())
                {
                    clickedCheckBox.Checked = false;
                    return;
                }
            }
            else
            {
                cell.Harvest();
            }

            clickedCheckBox.BackColor = cell.GetStatusColor();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            foreach (var item in items)
            {
                var (checkbox, cell) = (item.Key, item.Value);

                if(cell.Status == CellStatus.Empty || cell.Status == CellStatus.Overgrown)
                {
                    continue;
                }

                cell.Grow();
                checkbox.BackColor = cell.GetStatusColor();
            }
        }

    }
}
