
namespace tptcalc
{
    partial class Blueprint
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFormat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 25);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(566, 156);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert code here";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(503, 187);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 237);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(566, 230);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // chkFormat
            // 
            this.chkFormat.AutoSize = true;
            this.chkFormat.Location = new System.Drawing.Point(12, 191);
            this.chkFormat.Name = "chkFormat";
            this.chkFormat.Size = new System.Drawing.Size(155, 17);
            this.chkFormat.TabIndex = 6;
            this.chkFormat.Text = "Format Result with new line";
            this.chkFormat.UseVisualStyleBackColor = true;
            // 
            // Blueprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 479);
            this.Controls.Add(this.chkFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInput);
            this.Name = "Blueprint";
            this.Text = "Base64_Utility";
            this.Load += new System.EventHandler(this.Blueprint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFormat;
    }
}