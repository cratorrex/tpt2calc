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
    public partial class Calculate_Kills : Form
    {           
        private Form1 MainForm = null;
        readonly convert convert = new convert();


        public Calculate_Kills(Form callingForm)
        {
            MainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int kills = 0;
            TextBox[] textboxes = { txtAir, txtDar, txtEar, txtEle, txtFir, txtLig, txtNat, txtNeu, txtUni, txtWat };

            for (int i = 0; i < 10; i++) 
            {
                if (int.TryParse(convert.CheckConvert(textboxes[i], rtbF2_Return, false).ToString(), out int j)) 
                {
                    kills += j;
                }
            }
            this.MainForm.CSPDKILLS = kills.ToString();
            this.MainForm.for_1E = false;

            if (chkKeep.Checked == false)
            { this.Close(); }
        }
    }
}
