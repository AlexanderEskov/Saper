﻿namespace Saper
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            NewGameButton = new Button();
            RecordsButton = new Button();
            ExitGameButton = new Button();
            ChooseEasyButton = new Button();
            ChooseMediumButton = new Button();
            ChooseHardButton = new Button();
            StartGameButton = new Button();
            RecordTable = new ListBox();
            RecordsLabel = new Label();
            SuspendLayout();
            // 
            // NewGameButton
            // 
            NewGameButton.BackColor = Color.Wheat;
            NewGameButton.FlatStyle = FlatStyle.Flat;
            NewGameButton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewGameButton.Location = new Point(26, 146);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(172, 37);
            NewGameButton.TabIndex = 0;
            NewGameButton.Text = "NEW GAME";
            NewGameButton.UseVisualStyleBackColor = false;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // RecordsButton
            // 
            RecordsButton.BackColor = Color.Wheat;
            RecordsButton.FlatStyle = FlatStyle.Flat;
            RecordsButton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordsButton.Location = new Point(26, 189);
            RecordsButton.Name = "RecordsButton";
            RecordsButton.Size = new Size(172, 37);
            RecordsButton.TabIndex = 2;
            RecordsButton.Text = "RECORDS";
            RecordsButton.UseVisualStyleBackColor = false;
            RecordsButton.Click += RecordsButton_Click;
            // 
            // ExitGameButton
            // 
            ExitGameButton.BackColor = Color.Wheat;
            ExitGameButton.FlatStyle = FlatStyle.Flat;
            ExitGameButton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitGameButton.Location = new Point(26, 272);
            ExitGameButton.Name = "ExitGameButton";
            ExitGameButton.Size = new Size(172, 37);
            ExitGameButton.TabIndex = 3;
            ExitGameButton.Text = "EXIT";
            ExitGameButton.UseVisualStyleBackColor = false;
            ExitGameButton.Click += ExitButton_Click;
            // 
            // ChooseEasyButton
            // 
            ChooseEasyButton.BackColor = Color.Wheat;
            ChooseEasyButton.FlatStyle = FlatStyle.Flat;
            ChooseEasyButton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseEasyButton.ForeColor = SystemColors.ControlText;
            ChooseEasyButton.Location = new Point(225, 102);
            ChooseEasyButton.Name = "ChooseEasyButton";
            ChooseEasyButton.Size = new Size(172, 37);
            ChooseEasyButton.TabIndex = 4;
            ChooseEasyButton.Text = "Easy";
            ChooseEasyButton.UseVisualStyleBackColor = false;
            ChooseEasyButton.Visible = false;
            ChooseEasyButton.Click += ChooseEasyButton_Click;
            // 
            // ChooseMediumButton
            // 
            ChooseMediumButton.BackColor = Color.Wheat;
            ChooseMediumButton.FlatStyle = FlatStyle.Flat;
            ChooseMediumButton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseMediumButton.Location = new Point(225, 146);
            ChooseMediumButton.Name = "ChooseMediumButton";
            ChooseMediumButton.Size = new Size(172, 37);
            ChooseMediumButton.TabIndex = 5;
            ChooseMediumButton.Text = "Medium";
            ChooseMediumButton.UseVisualStyleBackColor = false;
            ChooseMediumButton.Visible = false;
            ChooseMediumButton.Click += ChooseMediumButton_Click;
            // 
            // ChooseHardButton
            // 
            ChooseHardButton.BackColor = Color.Wheat;
            ChooseHardButton.FlatStyle = FlatStyle.Flat;
            ChooseHardButton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseHardButton.Location = new Point(225, 189);
            ChooseHardButton.Name = "ChooseHardButton";
            ChooseHardButton.Size = new Size(172, 37);
            ChooseHardButton.TabIndex = 6;
            ChooseHardButton.Text = "Hard";
            ChooseHardButton.UseVisualStyleBackColor = false;
            ChooseHardButton.Visible = false;
            ChooseHardButton.Click += ChooseHardButton_Click;
            // 
            // StartGameButton
            // 
            StartGameButton.BackColor = Color.Wheat;
            StartGameButton.Enabled = false;
            StartGameButton.FlatStyle = FlatStyle.Flat;
            StartGameButton.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartGameButton.Location = new Point(225, 272);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(172, 37);
            StartGameButton.TabIndex = 7;
            StartGameButton.Text = "START GAME";
            StartGameButton.UseVisualStyleBackColor = false;
            StartGameButton.Visible = false;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // RecordTable
            // 
            RecordTable.BackColor = Color.Wheat;
            RecordTable.BorderStyle = BorderStyle.FixedSingle;
            RecordTable.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordTable.FormattingEnabled = true;
            RecordTable.ItemHeight = 22;
            RecordTable.Location = new Point(226, 102);
            RecordTable.Name = "RecordTable";
            RecordTable.SelectionMode = SelectionMode.None;
            RecordTable.Size = new Size(172, 244);
            RecordTable.TabIndex = 8;
            RecordTable.Visible = false;
            // 
            // RecordsLabel
            // 
            RecordsLabel.AutoSize = true;
            RecordsLabel.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordsLabel.Location = new Point(225, 71);
            RecordsLabel.Name = "RecordsLabel";
            RecordsLabel.Size = new Size(125, 28);
            RecordsLabel.TabIndex = 9;
            RecordsLabel.Text = "BEST SCORES";
            RecordsLabel.Visible = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(423, 424);
            Controls.Add(RecordsLabel);
            Controls.Add(RecordTable);
            Controls.Add(StartGameButton);
            Controls.Add(ChooseHardButton);
            Controls.Add(ChooseMediumButton);
            Controls.Add(ChooseEasyButton);
            Controls.Add(ExitGameButton);
            Controls.Add(RecordsButton);
            Controls.Add(NewGameButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sapper";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewGameButton;
        private Button RecordsButton;
        private Button ExitGameButton;
        private Button ChooseEasyButton;
        private Button ChooseMediumButton;
        private Button ChooseHardButton;
        private Button StartGameButton;

        private DifficultyLevel difficulty;
        private ListBox RecordTable;
        private Label RecordsLabel;
    }
}