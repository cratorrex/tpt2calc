namespace tptcalc
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCalculateXP = new System.Windows.Forms.Button();
			this.txtLowXP = new System.Windows.Forms.TextBox();
			this.txtHighXP = new System.Windows.Forms.TextBox();
			this.txtAveXP = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEra = new System.Windows.Forms.TextBox();
			this.numXPLvl = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rtbReturn = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtKills = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.numReg = new System.Windows.Forms.NumericUpDown();
			this.txtCSpd = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnCSpd = new System.Windows.Forms.Button();
			this.numH = new System.Windows.Forms.NumericUpDown();
			this.numM = new System.Windows.Forms.NumericUpDown();
			this.numS = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numXPLvl)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numReg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numS)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(92, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "era#:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "XP Bonus Module Level:";
			// 
			// btnCalculateXP
			// 
			this.btnCalculateXP.Location = new System.Drawing.Point(125, 151);
			this.btnCalculateXP.Name = "btnCalculateXP";
			this.btnCalculateXP.Size = new System.Drawing.Size(75, 23);
			this.btnCalculateXP.TabIndex = 2;
			this.btnCalculateXP.Text = "Calculate";
			this.btnCalculateXP.UseVisualStyleBackColor = true;
			this.btnCalculateXP.Click += new System.EventHandler(this.btnCalculateXP_Click);
			// 
			// txtLowXP
			// 
			this.txtLowXP.Location = new System.Drawing.Point(6, 235);
			this.txtLowXP.Name = "txtLowXP";
			this.txtLowXP.ReadOnly = true;
			this.txtLowXP.Size = new System.Drawing.Size(100, 20);
			this.txtLowXP.TabIndex = 99;
			// 
			// txtHighXP
			// 
			this.txtHighXP.Location = new System.Drawing.Point(218, 235);
			this.txtHighXP.Name = "txtHighXP";
			this.txtHighXP.ReadOnly = true;
			this.txtHighXP.Size = new System.Drawing.Size(100, 20);
			this.txtHighXP.TabIndex = 99;
			// 
			// txtAveXP
			// 
			this.txtAveXP.Location = new System.Drawing.Point(112, 235);
			this.txtAveXP.Name = "txtAveXP";
			this.txtAveXP.ReadOnly = true;
			this.txtAveXP.Size = new System.Drawing.Size(100, 20);
			this.txtAveXP.TabIndex = 99;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtEra);
			this.groupBox1.Controls.Add(this.numXPLvl);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtAveXP);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnCalculateXP);
			this.groupBox1.Controls.Add(this.txtHighXP);
			this.groupBox1.Controls.Add(this.txtLowXP);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(324, 261);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "EnemyXPCalculator";
			// 
			// txtEra
			// 
			this.txtEra.Location = new System.Drawing.Point(134, 51);
			this.txtEra.Name = "txtEra";
			this.txtEra.Size = new System.Drawing.Size(100, 20);
			this.txtEra.TabIndex = 0;
			// 
			// numXPLvl
			// 
			this.numXPLvl.Location = new System.Drawing.Point(189, 95);
			this.numXPLvl.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.numXPLvl.Name = "numXPLvl";
			this.numXPLvl.Size = new System.Drawing.Size(73, 20);
			this.numXPLvl.TabIndex = 1;
			this.numXPLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(109, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Average";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(215, 219);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Highest possible";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 219);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Lowest possible";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numS);
			this.groupBox2.Controls.Add(this.numM);
			this.groupBox2.Controls.Add(this.numH);
			this.groupBox2.Controls.Add(this.btnCSpd);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.txtCSpd);
			this.groupBox2.Controls.Add(this.numReg);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtKills);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(342, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(343, 261);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ClearSpeedCalculator (CSpeedCalc)";
			// 
			// rtbReturn
			// 
			this.rtbReturn.Location = new System.Drawing.Point(12, 302);
			this.rtbReturn.Name = "rtbReturn";
			this.rtbReturn.Size = new System.Drawing.Size(673, 85);
			this.rtbReturn.TabIndex = 99;
			this.rtbReturn.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(18, 286);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Error Pane";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(45, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(243, 39);
			this.label7.TabIndex = 0;
			this.label7.Text = "Total enemies killed\r\nGo to [Settings > Enemies] \r\nand add up all the numbers    " +
    "   [Use Full Notation]";
			// 
			// txtKills
			// 
			this.txtKills.Location = new System.Drawing.Point(186, 40);
			this.txtKills.Name = "txtKills";
			this.txtKills.Size = new System.Drawing.Size(111, 20);
			this.txtKills.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(60, 97);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(228, 26);
			this.label8.TabIndex = 7;
			this.label8.Text = "Game time in current run in Hours and Minutes \r\n(Optional for seconds)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(132, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(10, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = ":";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(204, 138);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(10, 13);
			this.label10.TabIndex = 12;
			this.label10.Text = ":";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(108, 171);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 13);
			this.label11.TabIndex = 13;
			this.label11.Text = "Current Region";
			// 
			// numReg
			// 
			this.numReg.Location = new System.Drawing.Point(192, 169);
			this.numReg.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.numReg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numReg.Name = "numReg";
			this.numReg.Size = new System.Drawing.Size(48, 20);
			this.numReg.TabIndex = 7;
			this.numReg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtCSpd
			// 
			this.txtCSpd.Location = new System.Drawing.Point(146, 235);
			this.txtCSpd.Name = "txtCSpd";
			this.txtCSpd.ReadOnly = true;
			this.txtCSpd.Size = new System.Drawing.Size(162, 20);
			this.txtCSpd.TabIndex = 99;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(33, 238);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(106, 13);
			this.label12.TabIndex = 16;
			this.label12.Text = "ClearSpeed on Easy:";
			// 
			// btnCSpd
			// 
			this.btnCSpd.Location = new System.Drawing.Point(137, 200);
			this.btnCSpd.Name = "btnCSpd";
			this.btnCSpd.Size = new System.Drawing.Size(75, 23);
			this.btnCSpd.TabIndex = 8;
			this.btnCSpd.Text = "Calculate";
			this.btnCSpd.UseVisualStyleBackColor = true;
			this.btnCSpd.Click += new System.EventHandler(this.btnCSpd_Click);
			// 
			// numH
			// 
			this.numH.Location = new System.Drawing.Point(74, 136);
			this.numH.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numH.Name = "numH";
			this.numH.Size = new System.Drawing.Size(52, 20);
			this.numH.TabIndex = 4;
			// 
			// numM
			// 
			this.numM.Location = new System.Drawing.Point(148, 136);
			this.numM.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.numM.Name = "numM";
			this.numM.Size = new System.Drawing.Size(52, 20);
			this.numM.TabIndex = 5;
			// 
			// numS
			// 
			this.numS.Location = new System.Drawing.Point(220, 136);
			this.numS.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.numS.Name = "numS";
			this.numS.Size = new System.Drawing.Size(52, 20);
			this.numS.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 399);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.rtbReturn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numXPLvl)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numReg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numS)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCalculateXP;
		private System.Windows.Forms.TextBox txtLowXP;
		private System.Windows.Forms.TextBox txtHighXP;
		private System.Windows.Forms.TextBox txtAveXP;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEra;
		private System.Windows.Forms.NumericUpDown numXPLvl;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox rtbReturn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCSpd;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtCSpd;
		private System.Windows.Forms.NumericUpDown numReg;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtKills;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numS;
		private System.Windows.Forms.NumericUpDown numM;
		private System.Windows.Forms.NumericUpDown numH;
	}
}

