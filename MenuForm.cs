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
        // Обработка нажатия кнопки "New game" (-> Выбор уровня сложности)
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            RecordTable.Visible = false;
            RecordsLabel.Visible = false;
            ChooseEasyButton.Visible = true;
            ChooseMediumButton.Visible = true;
            ChooseHardButton.Visible = true;
            StartGameButton.Visible = true;
        }

        // Обработка нажатия кнопки "Start game" (Начинается раунд)
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            BattleField battleField = new BattleField(this, difficulty);
            battleField.Show();
            this.Hide();
        }

        // Обработка нажатия кнопки "Exit" (Выход)
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        // Обработка нажатия кнопки "Records"
        // Выбор таблицы рекордов
        private void RecordsButton_Click(object sender, EventArgs e)
        {
            ChooseEasyButton.Visible = false;
            ChooseMediumButton.Visible = false;
            ChooseHardButton.Visible = false;
            StartGameButton.Visible = false;
            RecordTable.Visible = true;
            RecordsLabel.Visible = true;
            RecordTable.Items.Clear();
            string[] lines = File.ReadAllLines("records.txt");
            string text = "";
            for(int i = 0; i < lines.Length; i++)
            {
                int time = Convert.ToInt32(lines[i]);
                string min, sec;
                if ( time / 60 < 10)
                {
                    min = "0" + Convert.ToString(time / 60);
                }
                else
                {
                    min = Convert.ToString(time / 60);
                }

                if (time % 60 < 10)
                {
                    sec = "0" + Convert.ToString(time % 60);
                }
                else
                {
                    sec = Convert.ToString(time % 60);
                }

                lines[i] = "#" + Convert.ToString(i + 1) + " " + min + ":" + sec;
                RecordTable.Items.Add(lines[i]);
            }
            //RecordTable.Text = text;
        }

    }
}
