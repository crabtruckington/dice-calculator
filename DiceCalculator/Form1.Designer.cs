namespace DiceCalculator
{
    partial class diceCalc
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
            this.diceEntryBox = new System.Windows.Forms.NumericUpDown();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.numDiceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diceSidesBox = new System.Windows.Forms.NumericUpDown();
            this.failValLabel = new System.Windows.Forms.Label();
            this.failValBox = new System.Windows.Forms.NumericUpDown();
            this.succValLabel = new System.Windows.Forms.Label();
            this.hitsValBox = new System.Windows.Forms.NumericUpDown();
            this.failThreshLabel = new System.Windows.Forms.Label();
            this.minFailValueBox = new System.Windows.Forms.NumericUpDown();
            this.minSuccValueLabel = new System.Windows.Forms.Label();
            this.minSuccValueBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.diceEntryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceSidesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failValBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitsValBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minFailValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSuccValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // diceEntryBox
            // 
            this.diceEntryBox.Location = new System.Drawing.Point(121, 32);
            this.diceEntryBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.diceEntryBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diceEntryBox.Name = "diceEntryBox";
            this.diceEntryBox.Size = new System.Drawing.Size(142, 20);
            this.diceEntryBox.TabIndex = 0;
            this.diceEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diceEntryBox.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(13, 213);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.resultsTextBox.Size = new System.Drawing.Size(581, 334);
            this.resultsTextBox.TabIndex = 1;
            this.resultsTextBox.Text = "";
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(212, 175);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(188, 32);
            this.rollButton.TabIndex = 2;
            this.rollButton.Text = "Roll \'dem Bones!";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // numDiceLabel
            // 
            this.numDiceLabel.AutoSize = true;
            this.numDiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiceLabel.Location = new System.Drawing.Point(122, 10);
            this.numDiceLabel.Name = "numDiceLabel";
            this.numDiceLabel.Size = new System.Drawing.Size(129, 13);
            this.numDiceLabel.TabIndex = 3;
            this.numDiceLabel.Text = "How many dice to roll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X sided dice";
            // 
            // diceSidesBox
            // 
            this.diceSidesBox.Location = new System.Drawing.Point(121, 80);
            this.diceSidesBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diceSidesBox.Name = "diceSidesBox";
            this.diceSidesBox.Size = new System.Drawing.Size(142, 20);
            this.diceSidesBox.TabIndex = 4;
            this.diceSidesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diceSidesBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.diceSidesBox.ValueChanged += new System.EventHandler(this.diceSidesBox_ValueChanged);
            // 
            // failValLabel
            // 
            this.failValLabel.AutoSize = true;
            this.failValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failValLabel.Location = new System.Drawing.Point(339, 114);
            this.failValLabel.Name = "failValLabel";
            this.failValLabel.Size = new System.Drawing.Size(139, 13);
            this.failValLabel.TabIndex = 9;
            this.failValLabel.Text = "How many \"Hits\" to fail";
            // 
            // failValBox
            // 
            this.failValBox.Location = new System.Drawing.Point(338, 130);
            this.failValBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.failValBox.Name = "failValBox";
            this.failValBox.Size = new System.Drawing.Size(142, 20);
            this.failValBox.TabIndex = 8;
            this.failValBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.failValBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // succValLabel
            // 
            this.succValLabel.AutoSize = true;
            this.succValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.succValLabel.Location = new System.Drawing.Point(310, 10);
            this.succValLabel.Name = "succValLabel";
            this.succValLabel.Size = new System.Drawing.Size(170, 13);
            this.succValLabel.TabIndex = 7;
            this.succValLabel.Text = "How many \"Hits\" to succeed";
            // 
            // hitsValBox
            // 
            this.hitsValBox.Location = new System.Drawing.Point(338, 32);
            this.hitsValBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.hitsValBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hitsValBox.Name = "hitsValBox";
            this.hitsValBox.Size = new System.Drawing.Size(142, 20);
            this.hitsValBox.TabIndex = 6;
            this.hitsValBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hitsValBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // failThreshLabel
            // 
            this.failThreshLabel.AutoSize = true;
            this.failThreshLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failThreshLabel.Location = new System.Drawing.Point(344, 64);
            this.failThreshLabel.Name = "failThreshLabel";
            this.failThreshLabel.Size = new System.Drawing.Size(136, 13);
            this.failThreshLabel.TabIndex = 13;
            this.failThreshLabel.Text = "Maximum Failure Value";
            // 
            // minFailValueBox
            // 
            this.minFailValueBox.Location = new System.Drawing.Point(338, 80);
            this.minFailValueBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minFailValueBox.Name = "minFailValueBox";
            this.minFailValueBox.Size = new System.Drawing.Size(142, 20);
            this.minFailValueBox.TabIndex = 12;
            this.minFailValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minFailValueBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minSuccValueLabel
            // 
            this.minSuccValueLabel.AutoSize = true;
            this.minSuccValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minSuccValueLabel.Location = new System.Drawing.Point(122, 114);
            this.minSuccValueLabel.Name = "minSuccValueLabel";
            this.minSuccValueLabel.Size = new System.Drawing.Size(143, 13);
            this.minSuccValueLabel.TabIndex = 11;
            this.minSuccValueLabel.Text = "Minimum Success Value";
            // 
            // minSuccValueBox
            // 
            this.minSuccValueBox.Location = new System.Drawing.Point(121, 130);
            this.minSuccValueBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minSuccValueBox.Name = "minSuccValueBox";
            this.minSuccValueBox.Size = new System.Drawing.Size(142, 20);
            this.minSuccValueBox.TabIndex = 10;
            this.minSuccValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minSuccValueBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // diceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 559);
            this.Controls.Add(this.failThreshLabel);
            this.Controls.Add(this.minFailValueBox);
            this.Controls.Add(this.minSuccValueLabel);
            this.Controls.Add(this.minSuccValueBox);
            this.Controls.Add(this.failValLabel);
            this.Controls.Add(this.failValBox);
            this.Controls.Add(this.succValLabel);
            this.Controls.Add(this.hitsValBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diceSidesBox);
            this.Controls.Add(this.numDiceLabel);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.diceEntryBox);
            this.Name = "diceCalc";
            this.Text = "Dice Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.diceEntryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceSidesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failValBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitsValBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minFailValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSuccValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown diceEntryBox;
        private System.Windows.Forms.RichTextBox resultsTextBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label numDiceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown diceSidesBox;
        private System.Windows.Forms.Label failValLabel;
        private System.Windows.Forms.NumericUpDown failValBox;
        private System.Windows.Forms.Label succValLabel;
        private System.Windows.Forms.NumericUpDown hitsValBox;
        private System.Windows.Forms.Label failThreshLabel;
        private System.Windows.Forms.NumericUpDown minFailValueBox;
        private System.Windows.Forms.Label minSuccValueLabel;
        private System.Windows.Forms.NumericUpDown minSuccValueBox;
    }
}

