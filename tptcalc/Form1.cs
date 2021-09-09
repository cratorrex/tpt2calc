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

		readonly calc calc = new calc();
		readonly convert convert = new convert();

		private void btnCalculateXP_Click(object sender, EventArgs e)
		{
			//validates txtera is between 0 and 100B
			long era = convert.CheckConvert(txtEra, rtbReturn, true); //Checks if the number requires conversion and converts where needed
			long eraDropStat = convert.CheckConvert(txtEraXPDropStat, rtbReturn, false);

			if (eraDropStat < 1) { eraDropStat = 1; } //sets drop stat to 1 (default) if the user doesn't know the value

			if (era >= 0 && era < 100000000000) 
			{
				calc.CXP(era, eraDropStat, numXPLvl, txtLowXP, txtHighXP, txtAveXP, rtbReturn);
			}
			else
			{
				rtbReturn.AppendText("eraXPCalc: Please make sure that your era is a positive whole number less than 100B (100e9)." + Environment.NewLine); //may be cascading
				txtEra.Focus();
			}
		}

		private void btnCSpd_Click(object sender, EventArgs e)
		{
			long kills = convert.CheckConvert(txtKills, rtbReturn, true); //Checks if the number requires conversion and converts where needed

			//validating time is > 0 seconds
			double time = double.Parse(numH.Value.ToString()) * 3600 + double.Parse(numM.Value.ToString()) * 60 + double.Parse(numS.Value.ToString());

			if (time == 0)//if time is negative or zero... since you can't divide by 0
			{
				rtbReturn.AppendText("CSpeedCalc: Please make sure time over 0." + Environment.NewLine);
				numH.Focus();
			}
			else if (kills > 0) 
			{
				calc.CSP(kills, time, numReg, txtCSpd, chkCSPD1Element);
			}
			else
			{
				rtbReturn.AppendText("CSpeedCalc: Please make sure you have at least 1 kill." + Environment.NewLine); //will be cascading line
				txtKills.Focus();
			}

		}
        private void chkCSPD1Element_CheckedChanged(object sender, EventArgs e) //checking for stuff. label changes.
        {
			if (chkCSPD1Element.Checked == true)
			{
				lblEnemiesKilledCSPD.Text = "Enemies killed for one element \nGo to [Settings > Enemies] \nand enter the kills for one element";
			}
			else if (chkCSPD1Element.Checked == false)
            {
				lblEnemiesKilledCSPD.Text = "Total enemies killed           \nGo to [Settings > Enemies] \nand add up all the numbers";
            }
		}



        private void btnDisableCalc_Click(object sender, EventArgs e)
		{
			//nothing to validate here, just numbers
			int baseC = int.Parse(numBaseDC.Value.ToString()),
				nthD = int.Parse(numDisableN.Value.ToString());

			calc.EDC(baseC, nthD, txtIterEDC2, txtIterEDC3, txtIterEDC4, txtIterEDC5, txtIterEDCn);
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			txtEra.Focus();

			//Managing some tooltips
			ttCV.AutoPopDelay = 25000;
			ttNamedConvert.AutoPopDelay = 20000;

			//EraXPCalc
			ttxpBL.SetToolTip(numXPLvl, "Range between 0 and 25. \nSet to 0 if you do not have the module equipped.");
			ttRDrop.SetToolTip(txtEraXPDropStat, "Unrecognised values will be set to 1.");




			//Misc Tooltips
			ttCV.SetToolTip(lblCV, "0.3MPA.1 \nChanged up the UI a bit and added ToolTips for some things!" +
				"\n\nExtended Named Notation support up to Quintillions (e18)." +
				"\n\n Added Combat Surveillance Military Perk support to eraXPCalc." +
				"\n\n0.3MPA" +
				"\nRemoved \"Real time\" to \"Game time\" conversion. \n\nAdded convert.cs" +
				"\n\t→ This allows for Scientific Notation and Limited Named Notation(up to Trillions) conversions." +
				"\n\t→ Also checks for numbers \n\t→ Most invalid inputs parsed will be treated as 0." +
				"\n\nAdded method Reg2Elements" +
				"\n\t→This estimates the total kills based on a single element instead of having to count them yourself." +
				"\n\t\t→ based off region" +
				"\n\nYet to add Combat Surveillance Military Perk support to eraXPCalc.");

			ttNamedConvert.SetToolTip(lblConvert, "Accepted \"Input Conversions\" as of current version: \n\nScientific Notation (use of \"e\" and \"E\")"
				+ "\n\n"+"K, k: Thousands (e3) \nM, m: Millions (e6) \nB, b: Billions (e9) \nT, t: Trillions (e12) \nQA, Qa, qA, qa: Quadrillions (e15) " 
				+ "\nQI, Qi, qI, qi: Quintillions (e18) ");
        }
    }
}
