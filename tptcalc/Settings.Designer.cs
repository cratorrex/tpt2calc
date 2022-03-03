
namespace tptcalc
{
    partial class Settings
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
            this.chkRemTab = new System.Windows.Forms.CheckBox();
            this.gbOpen = new System.Windows.Forms.GroupBox();
            this.chkCalK = new System.Windows.Forms.CheckBox();
            this.chkBPD = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRemTab
            // 
            this.chkRemTab.AutoSize = true;
            this.chkRemTab.Location = new System.Drawing.Point(12, 12);
            this.chkRemTab.Name = "chkRemTab";
            this.chkRemTab.Size = new System.Drawing.Size(217, 17);
            this.chkRemTab.TabIndex = 0;
            this.chkRemTab.Text = "Remember selected tab in Main Window";
            this.chkRemTab.UseVisualStyleBackColor = true;
            // 
            // gbOpen
            // 
            this.gbOpen.Controls.Add(this.chkCalK);
            this.gbOpen.Controls.Add(this.chkBPD);
            this.gbOpen.Location = new System.Drawing.Point(12, 35);
            this.gbOpen.Name = "gbOpen";
            this.gbOpen.Size = new System.Drawing.Size(268, 126);
            this.gbOpen.TabIndex = 1;
            this.gbOpen.TabStop = false;
            this.gbOpen.Text = "Open these utilities on start";
            // 
            // chkCalK
            // 
            this.chkCalK.AutoSize = true;
            this.chkCalK.Location = new System.Drawing.Point(6, 42);
            this.chkCalK.Name = "chkCalK";
            this.chkCalK.Size = new System.Drawing.Size(91, 17);
            this.chkCalK.TabIndex = 1;
            this.chkCalK.Text = "Calculate Kills";
            this.chkCalK.UseVisualStyleBackColor = true;
            // 
            // chkBPD
            // 
            this.chkBPD.AutoSize = true;
            this.chkBPD.Location = new System.Drawing.Point(6, 19);
            this.chkBPD.Name = "chkBPD";
            this.chkBPD.Size = new System.Drawing.Size(111, 17);
            this.chkBPD.TabIndex = 0;
            this.chkBPD.Text = "Blueprint Decoder";
            this.chkBPD.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 229);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbOpen);
            this.Controls.Add(this.chkRemTab);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gbOpen.ResumeLayout(false);
            this.gbOpen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRemTab;
        private System.Windows.Forms.GroupBox gbOpen;
        private System.Windows.Forms.CheckBox chkCalK;
        private System.Windows.Forms.CheckBox chkBPD;
        private System.Windows.Forms.Button btnSave;
    }
}