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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

				calc calc = new calc();

		private void btnCalculateXP_Click(object sender, EventArgs e)
		{
			//validates txtera is between 0 and 100B
			long era;
			if (long.TryParse(txtEra.Text, out era)&&era>=0&&era<100000000000)
			{
				calc.CXP(era, numXPLvl, txtLowXP, txtHighXP, txtAveXP, rtbReturn);
			}
			else
			{
				rtbReturn.AppendText("eraXPCalc: Please make sure that your era is a positive whole number less than 100B (100e9) in full notation." + Environment.NewLine);
				txtEra.Focus();
			}
		}

		private void btnCSpd_Click(object sender, EventArgs e)
		{
			int kills;

			//validating time is > 0 seconds
			double time = double.Parse(numH.Value.ToString()) * 3600 + double.Parse(numM.Value.ToString()) * 60 + double.Parse(numS.Value.ToString());

			if (chkRTcspd.Checked)
			{ time *= 2; }

			if (time == 0)//if time is negative or zero... since you can't divide by 0
			{
				rtbReturn.AppendText("CSpeedCalc: Please make sure time over 0." + Environment.NewLine);
				numH.Focus();
			}
			else if (int.TryParse(txtKills.Text, out kills) && kills > 0) 
			{
				calc.CSP(kills, time, numReg, txtCSpd, rtbReturn);
			}
			else
			{
				rtbReturn.AppendText("CSpeedCalc: Please make sure you have at least 1 kill." + Environment.NewLine);
				txtKills.Focus();
			}

		}

		private void btnDisableCalc_Click(object sender, EventArgs e)
		{
			//nothing to validate here, just numbers
			int baseC = int.Parse(numBaseDC.Value.ToString()),
				nthD = int.Parse(numDisableN.Value.ToString());

			calc.EDC(baseC, nthD, txtIterEDC2, txtIterEDC3, txtIterEDC4, txtIterEDC5, txtIterEDCn);
		}
	}
}
