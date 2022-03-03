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
    public partial class Blueprint : Form
    {
        private Form1 MainForm = null;

        public Blueprint(Form callingForm)
        {
            MainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string output;
            output = Base64Decode(rtbInput.Text);
            if (chkFormat.Checked) output = output.Replace(";", "\n");
            else output = output.Replace(";", "  ");
            rtbOutput.Text = output;
        }

        public static string Base64Decode(string base64EncodedData)
        {
            try
            {
                if (base64EncodedData == "") { return "There is no text to decode."; }

                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch
            {
                return "Not a valid Base64 String.";
            }
            
        }

        private void Blueprint_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ADark) //== true
            { BackColor = default; ForeColor = default; btnDecode.BackColor = default; rtbInput.BackColor = default; }
            else
            { BackColor = Color.Black; ForeColor = Color.White; btnDecode.BackColor = Color.DimGray; rtbInput.BackColor = Color.LightGray; }
        }

    }
}
