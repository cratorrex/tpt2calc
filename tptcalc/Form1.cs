﻿using System;
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
		bool im = false;

		//Start EraXPCalc

		private void btnCalculateXP_Click(object sender, EventArgs e)
		{
			//validates txtera is between 0 and 100B
			double era = convert.CheckConvert(txtEra, rtbReturn, true); //Checks if the number requires conversion and converts where needed
			double eraDropStat = convert.CheckConvert(txtEraXPDropStat, rtbReturn, false);

			if (eraDropStat < 1 && chkResDrop.Checked == false) { eraDropStat = 1; } //sets drop stat to 1 (default) if the user doesn't know the value

			if (chkResDrop.Checked && (eraDropStat > 308)) 
				{
					rtbReturn.AppendText("eraXPCalc: Exponent is over infinity, can't compute. Please enter a value less than 308." + Environment.NewLine); //may be cascading
				}
			else if (era >= 0 && era < 100000000000) 
			{
				era = Math.Round(era);//rounding
				calc.CXP(era, eraDropStat, numXPLvl, numAwALvl, txtLowXP, txtHighXP, txtAveXP, rtbReturn, chkResDrop);
			}
			else
			{
				rtbReturn.AppendText("eraXPCalc: Please make sure that your era is a positive whole number less than 100B (100e9)." + Environment.NewLine); //may be cascading
				txtEra.Focus();
			}
		}

		//End EraXPCalc
		//Start CSpdCalc

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
				int spd = SpeedMod();
				calc.CSP(kills, time, numReg, txtCSpd, chkCSPD1Element, cBDifficulty, im, txtKpS, chkWC, spd, chkMAcc.Checked);
			}
			else
			{
				rtbReturn.AppendText("CSpeedCalc: Please make sure you have at least 1 kill." + Environment.NewLine); //will be cascading line
				txtKills.Focus();
			}

		}
		private void btnCalKill_Click(object sender, EventArgs e)
		{
			Calculate_Kills calculate_Kills = new Calculate_Kills(this);
			calculate_Kills.Show();
		}

		public string CSPDKILLS
		{
			get { return txtKills.Text; }
			set { txtKills.Text = value; }
        }
		public bool for_1E
        {
			get { return chkCSPD1Element.Checked; }
			set { chkCSPD1Element.Checked = value; }
        }

        private int SpeedMod()
        {
			if (cbRTorGT.SelectedIndex == 1 && chkIfx3.Checked)
				return 3;
			else if (cbRTorGT.SelectedIndex == 1)
				return 2;
			else
				return 1;
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

        private void cBDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
			Label lb = lblDifficulty;

			{
				switch (cBDifficulty.SelectedIndex)
				{
					case 1:
						lb.Text = "Med/Hard:";
						im = false;
						break;
					case 2:
						lb.Text = "Insane:";
						im = false;
						break;
					case 3:
						lb.Text = "Nightmare:";
						im = false;
						break;
					case 4:
						lb.Text = "Impossible:";
						im = true;
						break;
					default:
						lb.Text = "Easy:";
						im = false;
						break;
				}
			}
        }

		//End CSpdCalc
		//Start DisableCalc

        private void btnDisableCalc_Click(object sender, EventArgs e)
		{
			//nothing to validate here, just numbers
			double baseC = double.Parse(numBaseDC.Value.ToString()),
				nthD = double.Parse(numDisableN.Value.ToString());

			calc.EDC(baseC, nthD, txtIterEDC2, txtIterEDC3, txtIterEDC4, txtIterEDC5, txtIterEDCn);
		}

		//End DisableCalc
		//Start Form Loading and other stuff

        private void Form1_Load(object sender, EventArgs e)
        {
			txtEra.Focus();

			//Managing some tooltips
			ttAWA.AutoPopDelay = 7500;
			ttCV.AutoPopDelay = 30000;
			ttNamedConvert.AutoPopDelay = 20000;

			//EraXPCalc
			ttxpBL.SetToolTip(numXPLvl, "Range between 0 and 25. \nSet to 0 if you do not have the module equipped.");
			ttAWA.SetToolTip(numAwALvl, "Range between 0 and 5. \nSet to 0 if you do not have the module equipped." +
				"\nCalculation assumes Awareness is perpetually on.");
			ttRDrop.SetToolTip(txtEraXPDropStat, "Unrecognised values will be set to 1. \nCan only accept up to e18.");
			ttMAccF.SetToolTip(chkMAcc, "The accurate formula accounts for the fact that less enemies spawn on boss waves. " +
				"\nThis won't be accurate if you are using the wave floor trick to always spawn bosses.");

			//CSpdCalc
			cbRTorGT.SelectedIndex = 0;

			//DisableCalc

			//Misc Tooltips
			ttCV.SetToolTip(lblCV, "0.4XXX \nSmall Fixes, Small Additions." +
				"\nt→Added an extra safeguard when using Calculate_Kills in the case they forgot to uncheck \"Calculate for one Element\"." +
				"\nt→Calculate_Kills now can convert notation numbers." +
				"\nt→Calculate_Kills can now be kept open after calculation." +
				"\n\n0.4XX \nFound a few more bugs and fixed them." +
				"\n\t→ Fixed Resource Dropstat always returning 0 (i forgot why i put the \"show\" variable there for... -_-)." +
				"\n\t→ Fixed UI issue with ClearSpeed Calculator." +
				"\nAdded Log10 calculations for Resource Drop Stat values over 9e18 / 9Qi." +
				"\n\n0.4X \nA lot of Bug Fixes and Calculation stuff with the help of BudEBoy. :D" +
				"\nFixed a lot of bugs, thanks to bud for finding quite a lot of them." +
				"\nAdded a bit more Named Notation Support (q for e15 and Q for e18)." +
				"\nCSpdCalc:" +
				"\n\t→ Added Calculator to help accurately measure kills in the current run. (does not use convert.cs yet, gonna have another release for that one...)" +
				"\n\t→ Added back Real Time to Game Time conversions (default is Real Time), and x3 speed can be factored in (on by default)." +
				"\n\t→ Added Wave Compression toggle (on by default)." +
				"\n\t→ Added Kills/sec calculation." +
				"\n\t→ Added a more accurate formula, courtesy of bud.");

			ttNamedConvert.SetToolTip(lblConvert, "Accepted \"Input Conversions\": " +
				"\n\nScientific Notation (use of \"e\" and \"E\")"
				+ "\n\nK, k: Thousands (e3) \nM, m: Millions (e6) \nB, b: Billions (e9) \nT, t: Trillions (e12) \nq, QA, Qa, qA, qa: Quadrillions (e15) " 
				+ "\nQ, QI, Qi, qI, qi: Quintillions (e18) ");
        }

    }
}
