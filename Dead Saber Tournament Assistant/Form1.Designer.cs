namespace Dead_Saber_Tournament_Assistant
{
    partial class Form1
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
            this.lblPlayerScores = new System.Windows.Forms.Label();
            this.lblAmountOfNotes = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPrecision = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMapKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMapData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerScores
            // 
            this.lblPlayerScores.AutoSize = true;
            this.lblPlayerScores.Location = new System.Drawing.Point(12, 100);
            this.lblPlayerScores.Name = "lblPlayerScores";
            this.lblPlayerScores.Size = new System.Drawing.Size(72, 13);
            this.lblPlayerScores.TabIndex = 8;
            this.lblPlayerScores.Text = "Player Scores";
            // 
            // lblAmountOfNotes
            // 
            this.lblAmountOfNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountOfNotes.AutoSize = true;
            this.lblAmountOfNotes.Location = new System.Drawing.Point(442, 100);
            this.lblAmountOfNotes.Name = "lblAmountOfNotes";
            this.lblAmountOfNotes.Size = new System.Drawing.Size(84, 13);
            this.lblAmountOfNotes.TabIndex = 9;
            this.lblAmountOfNotes.Text = "Amount of notes";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(15, 238);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(511, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Scores";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Location = new System.Drawing.Point(12, 282);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(65, 13);
            this.lblTotalScore.TabIndex = 11;
            this.lblTotalScore.Text = "Total Score:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(12, 310);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 12;
            this.lblAverage.Text = "Average:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Precision:";
            // 
            // cmbPrecision
            // 
            this.cmbPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrecision.FormattingEnabled = true;
            this.cmbPrecision.Location = new System.Drawing.Point(68, 6);
            this.cmbPrecision.Name = "cmbPrecision";
            this.cmbPrecision.Size = new System.Drawing.Size(121, 21);
            this.cmbPrecision.TabIndex = 15;
            this.cmbPrecision.SelectedValueChanged += new System.EventHandler(this.cmbPrecision_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Decimals";
            // 
            // txtMapKey
            // 
            this.txtMapKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMapKey.Location = new System.Drawing.Point(68, 33);
            this.txtMapKey.Name = "txtMapKey";
            this.txtMapKey.Size = new System.Drawing.Size(458, 20);
            this.txtMapKey.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Map Key:";
            // 
            // btnMapData
            // 
            this.btnMapData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMapData.Location = new System.Drawing.Point(15, 59);
            this.btnMapData.Name = "btnMapData";
            this.btnMapData.Size = new System.Drawing.Size(511, 23);
            this.btnMapData.TabIndex = 19;
            this.btnMapData.Text = "Get Map Data";
            this.btnMapData.UseVisualStyleBackColor = true;
            this.btnMapData.Click += new System.EventHandler(this.btnMapData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 339);
            this.Controls.Add(this.btnMapData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMapKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPrecision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAmountOfNotes);
            this.Controls.Add(this.lblPlayerScores);
            this.Name = "Form1";
            this.Text = "Dead Saber Tournament Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayerScores;
        private System.Windows.Forms.Label lblAmountOfNotes;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbPrecision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMapKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMapData;
    }
}

