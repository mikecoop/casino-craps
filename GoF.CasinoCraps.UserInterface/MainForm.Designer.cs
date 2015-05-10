namespace GoF.CasinoCraps.UserInterface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.activeBetsGroup = new System.Windows.Forms.GroupBox();
            this.activeBetsListBox = new System.Windows.Forms.ListBox();
            this.completedBetsGroup = new System.Windows.Forms.GroupBox();
            this.completedBetsListBox = new System.Windows.Forms.ListBox();
            this.placeBetButton = new System.Windows.Forms.Button();
            this.betAmountLabel = new System.Windows.Forms.Label();
            this.betComboBox = new System.Windows.Forms.ComboBox();
            this.betLabel = new System.Windows.Forms.Label();
            this.bettingGroup = new System.Windows.Forms.GroupBox();
            this.rollingGroup = new System.Windows.Forms.GroupBox();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.secondDiePictureBox = new System.Windows.Forms.PictureBox();
            this.firstDiePictureBox = new System.Windows.Forms.PictureBox();
            this.currentMoneyLabel = new System.Windows.Forms.Label();
            this.crapsLayoutPictureBox = new System.Windows.Forms.PictureBox();
            this.betAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.roundInfoLabel = new System.Windows.Forms.Label();
            this.activeBetsGroup.SuspendLayout();
            this.completedBetsGroup.SuspendLayout();
            this.bettingGroup.SuspendLayout();
            this.rollingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondDiePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDiePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crapsLayoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // activeBetsGroup
            // 
            this.activeBetsGroup.Controls.Add(this.activeBetsListBox);
            this.activeBetsGroup.Location = new System.Drawing.Point(12, 405);
            this.activeBetsGroup.Name = "activeBetsGroup";
            this.activeBetsGroup.Size = new System.Drawing.Size(144, 292);
            this.activeBetsGroup.TabIndex = 1;
            this.activeBetsGroup.TabStop = false;
            this.activeBetsGroup.Text = "Active Bets";
            // 
            // activeBetsListBox
            // 
            this.activeBetsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeBetsListBox.FormattingEnabled = true;
            this.activeBetsListBox.Location = new System.Drawing.Point(3, 16);
            this.activeBetsListBox.Name = "activeBetsListBox";
            this.activeBetsListBox.Size = new System.Drawing.Size(138, 273);
            this.activeBetsListBox.TabIndex = 0;
            // 
            // completedBetsGroup
            // 
            this.completedBetsGroup.Controls.Add(this.completedBetsListBox);
            this.completedBetsGroup.Location = new System.Drawing.Point(162, 405);
            this.completedBetsGroup.Name = "completedBetsGroup";
            this.completedBetsGroup.Size = new System.Drawing.Size(218, 292);
            this.completedBetsGroup.TabIndex = 2;
            this.completedBetsGroup.TabStop = false;
            this.completedBetsGroup.Text = "Completed Bets";
            // 
            // completedBetsListBox
            // 
            this.completedBetsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completedBetsListBox.FormattingEnabled = true;
            this.completedBetsListBox.Location = new System.Drawing.Point(3, 16);
            this.completedBetsListBox.Name = "completedBetsListBox";
            this.completedBetsListBox.Size = new System.Drawing.Size(212, 273);
            this.completedBetsListBox.TabIndex = 0;
            // 
            // placeBetButton
            // 
            this.placeBetButton.Location = new System.Drawing.Point(199, 67);
            this.placeBetButton.Name = "placeBetButton";
            this.placeBetButton.Size = new System.Drawing.Size(75, 23);
            this.placeBetButton.TabIndex = 3;
            this.placeBetButton.Text = "Place Bet";
            this.placeBetButton.UseVisualStyleBackColor = true;
            this.placeBetButton.Click += new System.EventHandler(this.placeBetButton_Click);
            // 
            // betAmountLabel
            // 
            this.betAmountLabel.AutoSize = true;
            this.betAmountLabel.Location = new System.Drawing.Point(84, 44);
            this.betAmountLabel.Name = "betAmountLabel";
            this.betAmountLabel.Size = new System.Drawing.Size(80, 13);
            this.betAmountLabel.TabIndex = 5;
            this.betAmountLabel.Text = "Bet Amount ($):";
            // 
            // betComboBox
            // 
            this.betComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.betComboBox.FormattingEnabled = true;
            this.betComboBox.Location = new System.Drawing.Point(169, 14);
            this.betComboBox.MaxDropDownItems = 12;
            this.betComboBox.Name = "betComboBox";
            this.betComboBox.Size = new System.Drawing.Size(105, 21);
            this.betComboBox.TabIndex = 6;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(110, 17);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(53, 13);
            this.betLabel.TabIndex = 7;
            this.betLabel.Text = "Bet Type:";
            // 
            // bettingGroup
            // 
            this.bettingGroup.Controls.Add(this.betAmountUpDown);
            this.bettingGroup.Controls.Add(this.betComboBox);
            this.bettingGroup.Controls.Add(this.betLabel);
            this.bettingGroup.Controls.Add(this.placeBetButton);
            this.bettingGroup.Controls.Add(this.betAmountLabel);
            this.bettingGroup.Location = new System.Drawing.Point(386, 440);
            this.bettingGroup.Name = "bettingGroup";
            this.bettingGroup.Size = new System.Drawing.Size(401, 98);
            this.bettingGroup.TabIndex = 8;
            this.bettingGroup.TabStop = false;
            this.bettingGroup.Text = "Betting";
            // 
            // rollingGroup
            // 
            this.rollingGroup.Controls.Add(this.rollDiceButton);
            this.rollingGroup.Controls.Add(this.secondDiePictureBox);
            this.rollingGroup.Controls.Add(this.firstDiePictureBox);
            this.rollingGroup.Location = new System.Drawing.Point(386, 544);
            this.rollingGroup.Name = "rollingGroup";
            this.rollingGroup.Size = new System.Drawing.Size(401, 153);
            this.rollingGroup.TabIndex = 9;
            this.rollingGroup.TabStop = false;
            this.rollingGroup.Text = "Rolling";
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Location = new System.Drawing.Point(294, 65);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(75, 23);
            this.rollDiceButton.TabIndex = 2;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // secondDiePictureBox
            // 
            this.secondDiePictureBox.Location = new System.Drawing.Point(137, 20);
            this.secondDiePictureBox.Name = "secondDiePictureBox";
            this.secondDiePictureBox.Size = new System.Drawing.Size(125, 125);
            this.secondDiePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.secondDiePictureBox.TabIndex = 1;
            this.secondDiePictureBox.TabStop = false;
            // 
            // firstDiePictureBox
            // 
            this.firstDiePictureBox.Location = new System.Drawing.Point(6, 20);
            this.firstDiePictureBox.Name = "firstDiePictureBox";
            this.firstDiePictureBox.Size = new System.Drawing.Size(125, 125);
            this.firstDiePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.firstDiePictureBox.TabIndex = 0;
            this.firstDiePictureBox.TabStop = false;
            // 
            // currentMoneyLabel
            // 
            this.currentMoneyLabel.AutoSize = true;
            this.currentMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMoneyLabel.Location = new System.Drawing.Point(386, 421);
            this.currentMoneyLabel.Name = "currentMoneyLabel";
            this.currentMoneyLabel.Size = new System.Drawing.Size(169, 17);
            this.currentMoneyLabel.TabIndex = 10;
            this.currentMoneyLabel.Text = "Current Money: $5000";
            // 
            // crapsLayoutPictureBox
            // 
            this.crapsLayoutPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.crapsLayoutPictureBox.Image = global::GoF.CasinoCraps.UserInterface.Properties.Resources.CrapsTable;
            this.crapsLayoutPictureBox.Location = new System.Drawing.Point(0, 0);
            this.crapsLayoutPictureBox.Name = "crapsLayoutPictureBox";
            this.crapsLayoutPictureBox.Size = new System.Drawing.Size(799, 399);
            this.crapsLayoutPictureBox.TabIndex = 0;
            this.crapsLayoutPictureBox.TabStop = false;
            // 
            // betAmountUpDown
            // 
            this.betAmountUpDown.Location = new System.Drawing.Point(169, 42);
            this.betAmountUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.betAmountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betAmountUpDown.Name = "betAmountUpDown";
            this.betAmountUpDown.Size = new System.Drawing.Size(105, 20);
            this.betAmountUpDown.TabIndex = 8;
            this.betAmountUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.betAmountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // roundInfoLabel
            // 
            this.roundInfoLabel.AutoSize = true;
            this.roundInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundInfoLabel.Location = new System.Drawing.Point(386, 401);
            this.roundInfoLabel.Name = "roundInfoLabel";
            this.roundInfoLabel.Size = new System.Drawing.Size(215, 17);
            this.roundInfoLabel.TabIndex = 11;
            this.roundInfoLabel.Text = "Round #1 - Come Out Phase";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 709);
            this.Controls.Add(this.roundInfoLabel);
            this.Controls.Add(this.currentMoneyLabel);
            this.Controls.Add(this.rollingGroup);
            this.Controls.Add(this.bettingGroup);
            this.Controls.Add(this.completedBetsGroup);
            this.Controls.Add(this.activeBetsGroup);
            this.Controls.Add(this.crapsLayoutPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Casino Craps";
            this.activeBetsGroup.ResumeLayout(false);
            this.completedBetsGroup.ResumeLayout(false);
            this.bettingGroup.ResumeLayout(false);
            this.bettingGroup.PerformLayout();
            this.rollingGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secondDiePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDiePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crapsLayoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox crapsLayoutPictureBox;
        private System.Windows.Forms.GroupBox activeBetsGroup;
        private System.Windows.Forms.ListBox activeBetsListBox;
        private System.Windows.Forms.GroupBox completedBetsGroup;
        private System.Windows.Forms.ListBox completedBetsListBox;
        private System.Windows.Forms.Button placeBetButton;
        private System.Windows.Forms.Label betAmountLabel;
        private System.Windows.Forms.ComboBox betComboBox;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.GroupBox bettingGroup;
        private System.Windows.Forms.GroupBox rollingGroup;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.PictureBox secondDiePictureBox;
        private System.Windows.Forms.PictureBox firstDiePictureBox;
        private System.Windows.Forms.Label currentMoneyLabel;
        private System.Windows.Forms.NumericUpDown betAmountUpDown;
        private System.Windows.Forms.Label roundInfoLabel;
    }
}

