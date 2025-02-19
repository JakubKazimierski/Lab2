﻿namespace JakubKazimierskiGame
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBackground = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.LeftTimer = new System.Windows.Forms.Timer(this.components);
            this.RightTimer = new System.Windows.Forms.Timer(this.components);
            this.MunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.EndButton = new System.Windows.Forms.Button();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.BulletsLabel = new System.Windows.Forms.Label();
            this.SpeedLvlLabel = new System.Windows.Forms.Label();
            this.GroupBoxMenu = new System.Windows.Forms.GroupBox();
            this.ShieldLabel = new System.Windows.Forms.Label();
            this.LifeLabel = new System.Windows.Forms.Label();
            this.HardModeRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumModeRadioButton = new System.Windows.Forms.RadioButton();
            this.EasyModeRadioButton = new System.Windows.Forms.RadioButton();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.ScoresButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.GroupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoveBackground
            // 
            this.MoveBackground.Interval = 10;
            this.MoveBackground.Tick += new System.EventHandler(this.MoveBackground_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::JakubKazimierskiGame.Properties.Resources.Spaceship_PNG_File___Kopia;
            this.Player.Location = new System.Drawing.Point(298, 453);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // LeftTimer
            // 
            this.LeftTimer.Interval = 5;
            this.LeftTimer.Tick += new System.EventHandler(this.LeftTimer_Tick);
            // 
            // RightTimer
            // 
            this.RightTimer.Interval = 5;
            this.RightTimer.Tick += new System.EventHandler(this.RightTimer_Tick);
            // 
            // MunitionTimer
            // 
            this.MunitionTimer.Interval = 31;
            this.MunitionTimer.Tick += new System.EventHandler(this.MunitionTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // EnemiesMunitionTimer
            // 
            this.EnemiesMunitionTimer.Interval = 20;
            this.EnemiesMunitionTimer.Tick += new System.EventHandler(this.EnemiesMunitionTimer_Tick);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndButton.Location = new System.Drawing.Point(225, 279);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(210, 43);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Visible = false;
            this.EndButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReplayButton
            // 
            this.ReplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReplayButton.Location = new System.Drawing.Point(225, 205);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(210, 43);
            this.ReplayButton.TabIndex = 2;
            this.ReplayButton.Text = "Play";
            this.ReplayButton.UseVisualStyleBackColor = true;
            this.ReplayButton.Visible = false;
            this.ReplayButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(222, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "StarBattle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Silver;
            this.scoreLabel.Location = new System.Drawing.Point(6, 16);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(94, 33);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "SCORE: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // levelLabel
            // 
            this.levelLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelLabel.ForeColor = System.Drawing.Color.Silver;
            this.levelLabel.Location = new System.Drawing.Point(6, 67);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(90, 23);
            this.levelLabel.TabIndex = 5;
            this.levelLabel.Text = "LEVEL: 0";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoneyLabel.ForeColor = System.Drawing.Color.Silver;
            this.MoneyLabel.Location = new System.Drawing.Point(6, 108);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(96, 23);
            this.MoneyLabel.TabIndex = 6;
            this.MoneyLabel.Text = "MONEY: 0";
            this.MoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BulletsLabel
            // 
            this.BulletsLabel.BackColor = System.Drawing.Color.Transparent;
            this.BulletsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BulletsLabel.ForeColor = System.Drawing.Color.Silver;
            this.BulletsLabel.Location = new System.Drawing.Point(6, 149);
            this.BulletsLabel.Name = "BulletsLabel";
            this.BulletsLabel.Size = new System.Drawing.Size(108, 23);
            this.BulletsLabel.TabIndex = 7;
            this.BulletsLabel.Text = "BULLETS: 1";
            this.BulletsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SpeedLvlLabel
            // 
            this.SpeedLvlLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpeedLvlLabel.ForeColor = System.Drawing.Color.Silver;
            this.SpeedLvlLabel.Location = new System.Drawing.Point(8, 193);
            this.SpeedLvlLabel.Name = "SpeedLvlLabel";
            this.SpeedLvlLabel.Size = new System.Drawing.Size(94, 23);
            this.SpeedLvlLabel.TabIndex = 8;
            this.SpeedLvlLabel.Text = "SPEED LVL: 1";
            this.SpeedLvlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBoxMenu
            // 
            this.GroupBoxMenu.Controls.Add(this.ScoresButton);
            this.GroupBoxMenu.Controls.Add(this.ShieldLabel);
            this.GroupBoxMenu.Controls.Add(this.LifeLabel);
            this.GroupBoxMenu.Controls.Add(this.HardModeRadioButton);
            this.GroupBoxMenu.Controls.Add(this.MediumModeRadioButton);
            this.GroupBoxMenu.Controls.Add(this.EasyModeRadioButton);
            this.GroupBoxMenu.Controls.Add(this.DifficultyLabel);
            this.GroupBoxMenu.Controls.Add(this.scoreLabel);
            this.GroupBoxMenu.Controls.Add(this.SpeedLvlLabel);
            this.GroupBoxMenu.Controls.Add(this.levelLabel);
            this.GroupBoxMenu.Controls.Add(this.BulletsLabel);
            this.GroupBoxMenu.Controls.Add(this.MoneyLabel);
            this.GroupBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBoxMenu.ForeColor = System.Drawing.Color.Silver;
            this.GroupBoxMenu.Location = new System.Drawing.Point(630, 12);
            this.GroupBoxMenu.Name = "GroupBoxMenu";
            this.GroupBoxMenu.Size = new System.Drawing.Size(153, 491);
            this.GroupBoxMenu.TabIndex = 9;
            this.GroupBoxMenu.TabStop = false;
            this.GroupBoxMenu.Text = "OptionsMenu";
            // 
            // ShieldLabel
            // 
            this.ShieldLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShieldLabel.ForeColor = System.Drawing.Color.Silver;
            this.ShieldLabel.Location = new System.Drawing.Point(8, 277);
            this.ShieldLabel.Name = "ShieldLabel";
            this.ShieldLabel.Size = new System.Drawing.Size(94, 23);
            this.ShieldLabel.TabIndex = 14;
            this.ShieldLabel.Text = "SHIELD:";
            this.ShieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LifeLabel
            // 
            this.LifeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LifeLabel.ForeColor = System.Drawing.Color.Silver;
            this.LifeLabel.Location = new System.Drawing.Point(8, 242);
            this.LifeLabel.Name = "LifeLabel";
            this.LifeLabel.Size = new System.Drawing.Size(94, 23);
            this.LifeLabel.TabIndex = 13;
            this.LifeLabel.Text = "LIFE:";
            this.LifeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HardModeRadioButton
            // 
            this.HardModeRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.HardModeRadioButton.AllowDrop = true;
            this.HardModeRadioButton.AutoCheck = false;
            this.HardModeRadioButton.AutoSize = true;
            this.HardModeRadioButton.Location = new System.Drawing.Point(17, 456);
            this.HardModeRadioButton.Name = "HardModeRadioButton";
            this.HardModeRadioButton.Size = new System.Drawing.Size(48, 18);
            this.HardModeRadioButton.TabIndex = 12;
            this.HardModeRadioButton.Text = "Hard";
            this.HardModeRadioButton.UseCompatibleTextRendering = true;
            this.HardModeRadioButton.UseVisualStyleBackColor = true;
            this.HardModeRadioButton.Click += new System.EventHandler(this.HardModeRadioButton_Click);
            // 
            // MediumModeRadioButton
            // 
            this.MediumModeRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MediumModeRadioButton.AllowDrop = true;
            this.MediumModeRadioButton.AutoCheck = false;
            this.MediumModeRadioButton.AutoSize = true;
            this.MediumModeRadioButton.Location = new System.Drawing.Point(17, 423);
            this.MediumModeRadioButton.Name = "MediumModeRadioButton";
            this.MediumModeRadioButton.Size = new System.Drawing.Size(64, 18);
            this.MediumModeRadioButton.TabIndex = 11;
            this.MediumModeRadioButton.Text = "Medium";
            this.MediumModeRadioButton.UseCompatibleTextRendering = true;
            this.MediumModeRadioButton.UseVisualStyleBackColor = true;
            this.MediumModeRadioButton.Click += new System.EventHandler(this.MediumModeRadioButton_Click);
            // 
            // EasyModeRadioButton
            // 
            this.EasyModeRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EasyModeRadioButton.AllowDrop = true;
            this.EasyModeRadioButton.AutoSize = true;
            this.EasyModeRadioButton.Location = new System.Drawing.Point(17, 386);
            this.EasyModeRadioButton.Name = "EasyModeRadioButton";
            this.EasyModeRadioButton.Size = new System.Drawing.Size(48, 18);
            this.EasyModeRadioButton.TabIndex = 10;
            this.EasyModeRadioButton.Text = "Easy";
            this.EasyModeRadioButton.UseCompatibleTextRendering = true;
            this.EasyModeRadioButton.UseVisualStyleBackColor = true;
            this.EasyModeRadioButton.Click += new System.EventHandler(this.EasyModeRadioButton_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.Location = new System.Drawing.Point(14, 346);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(124, 27);
            this.DifficultyLabel.TabIndex = 9;
            this.DifficultyLabel.Text = "DifficulyMode";
            this.DifficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoresButton
            // 
            this.ScoresButton.Enabled = false;
            this.ScoresButton.ForeColor = System.Drawing.Color.Maroon;
            this.ScoresButton.Location = new System.Drawing.Point(34, 320);
            this.ScoresButton.Name = "ScoresButton";
            this.ScoresButton.Size = new System.Drawing.Size(80, 23);
            this.ScoresButton.TabIndex = 15;
            this.ScoresButton.Text = "BestScores";
            this.ScoresButton.UseVisualStyleBackColor = true;
            this.ScoresButton.Visible = false;
            this.ScoresButton.Click += new System.EventHandler(this.ScoresButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(795, 515);
            this.Controls.Add(this.GroupBoxMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(855, 553);
            this.MinimumSize = new System.Drawing.Size(655, 553);
            this.Name = "Form1";
            this.Text = "StarBattle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.GroupBoxMenu.ResumeLayout(false);
            this.GroupBoxMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MoveBackground;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer LeftTimer;
        private System.Windows.Forms.Timer RightTimer;
        private System.Windows.Forms.Timer MunitionTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label BulletsLabel;
        private System.Windows.Forms.Label SpeedLvlLabel;
        private System.Windows.Forms.GroupBox GroupBoxMenu;
        private System.Windows.Forms.RadioButton HardModeRadioButton;
        private System.Windows.Forms.RadioButton MediumModeRadioButton;
        private System.Windows.Forms.RadioButton EasyModeRadioButton;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label ShieldLabel;
        private System.Windows.Forms.Label LifeLabel;
        private System.Windows.Forms.Button ScoresButton;
    }
}

