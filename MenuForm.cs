using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            ChooseEasyButton.Visible = true;
            ChooseMediumButton.Visible = true;
            ChooseHardButton.Visible = true;
            StartGameButton.Visible = true;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            BattleField battleField = new BattleField(this, difficulty);
            battleField.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ChooseEasyButton_Click(object sender, EventArgs e)
        {
            ChooseEasyButton.BackColor = Color.Wheat;
            ChooseMediumButton.BackColor = Color.White;
            ChooseHardButton.BackColor = Color.White;
            difficulty = DifficultyLevel.Easy;
            StartGameButton.Enabled = true;
        }

        private void ChooseMediumButton_Click(object sender, EventArgs e)
        {
            ChooseEasyButton.BackColor = Color.White;
            ChooseMediumButton.BackColor = Color.Wheat;
            ChooseHardButton.BackColor = Color.White;
            difficulty = DifficultyLevel.Normal;
            StartGameButton.Enabled = true;
        }

        private void ChooseHardButton_Click(object sender, EventArgs e)
        {
            ChooseEasyButton.BackColor = Color.White;
            ChooseMediumButton.BackColor = Color.White;
            ChooseHardButton.BackColor = Color.Wheat;
            difficulty = DifficultyLevel.Hard;
            StartGameButton.Enabled = true;
        }
    }
}
