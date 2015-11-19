namespace Jednostki
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
            this.gpcTypeUnits = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblSecondUnit = new System.Windows.Forms.Label();
            this.cmbSecond = new System.Windows.Forms.ComboBox();
            this.cmbFirst = new System.Windows.Forms.ComboBox();
            this.gpcUnits = new System.Windows.Forms.GroupBox();
            this.rbtnElectricCulomb = new System.Windows.Forms.RadioButton();
            this.rbtnVoltage = new System.Windows.Forms.RadioButton();
            this.rbtnLenght = new System.Windows.Forms.RadioButton();
            this.gpcTypeUnits.SuspendLayout();
            this.gpcUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpcTypeUnits
            // 
            this.gpcTypeUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpcTypeUnits.Controls.Add(this.lblType);
            this.gpcTypeUnits.Controls.Add(this.txtValue);
            this.gpcTypeUnits.Controls.Add(this.lblScore);
            this.gpcTypeUnits.Controls.Add(this.btnScore);
            this.gpcTypeUnits.Controls.Add(this.txtScore);
            this.gpcTypeUnits.Controls.Add(this.lblSecondUnit);
            this.gpcTypeUnits.Controls.Add(this.cmbSecond);
            this.gpcTypeUnits.Controls.Add(this.cmbFirst);
            this.gpcTypeUnits.Location = new System.Drawing.Point(210, 12);
            this.gpcTypeUnits.Name = "gpcTypeUnits";
            this.gpcTypeUnits.Size = new System.Drawing.Size(336, 178);
            this.gpcTypeUnits.TabIndex = 6;
            this.gpcTypeUnits.TabStop = false;
            this.gpcTypeUnits.Text = "Wartość do przeliczenia";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(14, 110);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(102, 17);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Wpisz wartość:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(122, 110);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(115, 22);
            this.txtValue.TabIndex = 7;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(14, 141);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(50, 17);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Wynik:";
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(252, 119);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(75, 23);
            this.btnScore.TabIndex = 5;
            this.btnScore.Text = "Przelicz";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(122, 136);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(115, 22);
            this.txtScore.TabIndex = 4;
            // 
            // lblSecondUnit
            // 
            this.lblSecondUnit.AutoSize = true;
            this.lblSecondUnit.Location = new System.Drawing.Point(117, 40);
            this.lblSecondUnit.Name = "lblSecondUnit";
            this.lblSecondUnit.Size = new System.Drawing.Size(81, 17);
            this.lblSecondUnit.TabIndex = 3;
            this.lblSecondUnit.Text = "Przelicz na:";
            // 
            // cmbSecond
            // 
            this.cmbSecond.FormattingEnabled = true;
            this.cmbSecond.Location = new System.Drawing.Point(197, 70);
            this.cmbSecond.Name = "cmbSecond";
            this.cmbSecond.Size = new System.Drawing.Size(121, 24);
            this.cmbSecond.TabIndex = 1;
            // 
            // cmbFirst
            // 
            this.cmbFirst.FormattingEnabled = true;
            this.cmbFirst.Location = new System.Drawing.Point(17, 70);
            this.cmbFirst.Name = "cmbFirst";
            this.cmbFirst.Size = new System.Drawing.Size(115, 24);
            this.cmbFirst.TabIndex = 0;
            // 
            // gpcUnits
            // 
            this.gpcUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpcUnits.Controls.Add(this.rbtnElectricCulomb);
            this.gpcUnits.Controls.Add(this.rbtnVoltage);
            this.gpcUnits.Controls.Add(this.rbtnLenght);
            this.gpcUnits.Location = new System.Drawing.Point(12, 12);
            this.gpcUnits.Name = "gpcUnits";
            this.gpcUnits.Size = new System.Drawing.Size(187, 178);
            this.gpcUnits.TabIndex = 5;
            this.gpcUnits.TabStop = false;
            this.gpcUnits.Text = "Wybierz jednostke";
            // 
            // rbtnElectricCulomb
            // 
            this.rbtnElectricCulomb.AutoSize = true;
            this.rbtnElectricCulomb.Location = new System.Drawing.Point(20, 100);
            this.rbtnElectricCulomb.Name = "rbtnElectricCulomb";
            this.rbtnElectricCulomb.Size = new System.Drawing.Size(159, 21);
            this.rbtnElectricCulomb.TabIndex = 1;
            this.rbtnElectricCulomb.TabStop = true;
            this.rbtnElectricCulomb.Text = "Ładunek elektryczny";
            this.rbtnElectricCulomb.UseVisualStyleBackColor = true;
            this.rbtnElectricCulomb.Click += new System.EventHandler(this.rbtnElectricCulomb_Click);
            // 
            // rbtnVoltage
            // 
            this.rbtnVoltage.AutoSize = true;
            this.rbtnVoltage.Location = new System.Drawing.Point(20, 70);
            this.rbtnVoltage.Name = "rbtnVoltage";
            this.rbtnVoltage.Size = new System.Drawing.Size(160, 21);
            this.rbtnVoltage.TabIndex = 2;
            this.rbtnVoltage.TabStop = true;
            this.rbtnVoltage.Text = "Napięcie elektryczne";
            this.rbtnVoltage.UseVisualStyleBackColor = true;
            this.rbtnVoltage.Click += new System.EventHandler(this.rbtnVoltage_Click);
            // 
            // rbtnLenght
            // 
            this.rbtnLenght.AutoSize = true;
            this.rbtnLenght.Location = new System.Drawing.Point(20, 40);
            this.rbtnLenght.Name = "rbtnLenght";
            this.rbtnLenght.Size = new System.Drawing.Size(80, 21);
            this.rbtnLenght.TabIndex = 0;
            this.rbtnLenght.TabStop = true;
            this.rbtnLenght.Text = "Długość";
            this.rbtnLenght.UseVisualStyleBackColor = true;
            this.rbtnLenght.Click += new System.EventHandler(this.rbtnLenght_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 198);
            this.Controls.Add(this.gpcTypeUnits);
            this.Controls.Add(this.gpcUnits);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Zamiana jednostek";
            this.gpcTypeUnits.ResumeLayout(false);
            this.gpcTypeUnits.PerformLayout();
            this.gpcUnits.ResumeLayout(false);
            this.gpcUnits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gpcTypeUnits;
        private System.Windows.Forms.Label lblScore;
        internal System.Windows.Forms.Button btnScore;
        internal System.Windows.Forms.TextBox txtScore;
        internal System.Windows.Forms.Label lblSecondUnit;
        internal System.Windows.Forms.ComboBox cmbSecond;
        internal System.Windows.Forms.ComboBox cmbFirst;
        internal System.Windows.Forms.GroupBox gpcUnits;
        internal System.Windows.Forms.RadioButton rbtnElectricCulomb;
        internal System.Windows.Forms.RadioButton rbtnVoltage;
        internal System.Windows.Forms.RadioButton rbtnLenght;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtValue;
    }
}

