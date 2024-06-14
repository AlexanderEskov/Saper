namespace Saper
{
    partial class BattleField
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleField));
            GameTimer = new System.Windows.Forms.Timer(components);
            TimerMinLabel = new Label();
            groupBox1 = new GroupBox();
            TimerSecLabel = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ResultLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Tick += GameTimer_Tick;
            // 
            // TimerMinLabel
            // 
            TimerMinLabel.AutoSize = true;
            TimerMinLabel.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerMinLabel.Location = new Point(6, 33);
            TimerMinLabel.Name = "TimerMinLabel";
            TimerMinLabel.Size = new Size(41, 30);
            TimerMinLabel.TabIndex = 0;
            TimerMinLabel.Text = "00";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            groupBox1.Controls.Add(TimerSecLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TimerMinLabel);
            groupBox1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(21, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(104, 74);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Timer";
            // 
            // TimerSecLabel
            // 
            TimerSecLabel.AutoSize = true;
            TimerSecLabel.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerSecLabel.Location = new Point(53, 33);
            TimerSecLabel.Name = "TimerSecLabel";
            TimerSecLabel.Size = new Size(41, 30);
            TimerSecLabel.TabIndex = 4;
            TimerSecLabel.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 33);
            label3.Name = "label3";
            label3.Size = new Size(21, 30);
            label3.TabIndex = 3;
            label3.Text = ":";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 101);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultLabel.Location = new Point(24, 136);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(94, 22);
            ResultLabel.TabIndex = 5;
            ResultLabel.Text = "ResultLabel";
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BattleField
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 229, 158);
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(804, 521);
            Controls.Add(ResultLabel);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BattleField";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sapper";
            FormClosing += BattleField_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        public void BattleField_FormClosing(object sender, EventArgs e)
        {
            MainForm.Show();
        }
        private MenuForm MainForm;
        private System.Windows.Forms.Timer GameTimer;
        private Label TimerMinLabel;
        private GroupBox groupBox1;
        private Label TimerSecLabel;
        private Label label3;
        private PictureBox pictureBox1;
        private Label ResultLabel;
    }
}
