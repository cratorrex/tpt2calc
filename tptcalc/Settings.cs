using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tptcalc
{
    public partial class Settings : Form
    {
        private Form1 MainForm = null;

        public Settings(Form callingForm)
        {
            MainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.restTab = chkRemTab.Checked;
            if (chkRemTab.Checked) 
            { Properties.Settings.Default.restTabIndex_Main = MainForm.remTab; }
            else /*if (chkRemTab.Checked == false)*/ 
            { Properties.Settings.Default.restTabIndex_Main = default; }

            Properties.Settings.Default.openCalK = chkCalK.Checked;
            Properties.Settings.Default.openBPD = chkBPD.Checked;


            Properties.Settings.Default.Save();
        }        
        
        private void Settings_Load(object sender, EventArgs e)
        {
            //DMT
            if (Properties.Settings.Default.ADark)
            { BackColor = default; ForeColor = default; gbOpen.ForeColor = default; btnSave.BackColor = default; }
            else
            { BackColor = Color.Black; ForeColor = Color.WhiteSmoke; gbOpen.ForeColor = Color.White; btnSave.BackColor = Color.DimGray; }


            chkRemTab.Checked = Properties.Settings.Default.restTab;
            chkCalK.Checked = Properties.Settings.Default.openCalK;
            chkBPD.Checked = Properties.Settings.Default.openBPD;
        }

    }
}
