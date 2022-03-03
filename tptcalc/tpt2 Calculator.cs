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
        bool im = false;

        //settings
        bool dark = Properties.Settings.Default.ADark;
        bool rTab = Properties.Settings.Default.restTab;

        private void btnDMT_Click(object sender, EventArgs e)
        { DMT(dark); }

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
                calc.CSP(kills, time, numReg, txtCSpd, chkCSPD1Element, cBDiffCS, im, txtKpS, chkWC, spd, chkMAcc.Checked);
            }
            else
            {
                rtbReturn.AppendText("CSpeedCalc: Please make sure you have at least 1 kill." + Environment.NewLine); //will be cascading line
                txtKills.Focus();
            }
        }

        private void btnCalKill_Click(object sender, EventArgs e)
        { CalKills(); }

        private void CalKills()
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
            switch (cBDiffCS.SelectedIndex)
            {
                case 1:
                    lb.Text = "Medium:";
                    im = false;
                    break;
                case 2:
                    lb.Text = "Hard/Ins:";
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

        //Start DisableCalc

        private void btnDisableCalc_Click(object sender, EventArgs e)
        {
            //nothing to validate here, just numbers
            double baseC = double.Parse(numBaseDC.Value.ToString()),
                nthD = double.Parse(numDisableN.Value.ToString());

            calc.EDC(baseC, nthD, txtIterEDC2, txtIterEDC3, txtIterEDC4, txtIterEDC5, txtIterEDCn);
        }

        //Start Essential Utilities

        private void btnMDC_Click(object sender, EventArgs e)
        {
            if (cbModW.SelectedIndex < 0) { cbModW.SelectedIndex = 0; }
            if (cbModDM.SelectedIndex < 0) { cbModDM.SelectedIndex = 0; }

            double iW, iB, iP;
            //Validation for filled boxes
            if (txtModW.Text == "" || double.TryParse(txtModW.Text, out iW) == false || iW <= 0)
            {
                rtbReturn.AppendText("Please enter wave number greater than 0 (limited to a double).\n");
                txtModW.Focus();
            }
            else if (txtBMDC.Text == "" || double.TryParse(txtBMDC.Text, out iB) == false || iB <= 0)
            {
                rtbReturn.AppendText("Please enter the module's base drop chance.\n");
                txtBMDC.Focus();
            }
            else
            {
                if(txtPMDC.Text == "" || double.TryParse(txtPMDC.Text, out iP) == false || iP < 0) { txtPMDC.Text = "0"; iP = 0; }
                calc.MDC(iW, cbModW.SelectedIndex, iP, iB, cbModDM.SelectedIndex, txtMDC, txtMDCEst);
            }
        }



        private void btnBlueprintD_Click(object sender, EventArgs e)
        { BluePrintD(); }
        private void BluePrintD()
        {
            Blueprint blueprint = new Blueprint(this);
            blueprint.Show();
        }



        // // // // // // //
        //                //
        //    Settings    //
        //                //
        // // // // // // //

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.Show();
        }

        private void DMT(bool Dark)
        {
            TabPage[] tpcontrol = { tabPage1, tabPage2, tabPage3, tabPage4, tabPage5 };
            GroupBox[] gbcontrol = { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7 };
            Button[] btncontrol = { btnDMT, btnCalKill, btnCSpd, btnMDC, btnBlueprintD, btnSettings };
            RichTextBox[] rtbcontrol = { rtbReturn };

            if (Dark == false)
            {
                BackColor = Color.Black; ForeColor = Color.White;

                foreach (TabPage tp in tpcontrol)
                { tp.BackColor = ColorTranslator.FromHtml("#444"); }

                foreach (Button btn in btncontrol)
                { btn.BackColor = Color.DimGray; }

                foreach (GroupBox gb in gbcontrol)
                { gb.ForeColor = Color.White; }

                foreach (RichTextBox rtb in rtbcontrol) 
                { rtb.BackColor = Color.DarkGray; }

                dark = true; Properties.Settings.Default.ADark = false;
            }
            else /*if (Dark)*/
            {
                BackColor = default; ForeColor = default;

                foreach (TabPage tp in tpcontrol)
                { tp.BackColor = default; }

                foreach (Button btn in btncontrol)
                { btn.BackColor = default; }

                foreach (GroupBox gb in gbcontrol)
                { gb.ForeColor = default; }

                foreach (RichTextBox rtb in rtbcontrol)
                { rtb.BackColor = default; }

                dark = false; Properties.Settings.Default.ADark = true;
            }

            Save();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        { Properties.Settings.Default.restTabIndex_Main = remTab; Save(); }


        //get set go
        public int remTab { get => tcMain.SelectedIndex; }

        //Save
        public void Save()
        {
            Properties.Settings.Default.Save();
        }

        // // // // // // // //
        //                   //
        //   Form Loading    //
        //                   //
        // // // // // // // //

        private void Form1_Load(object sender, EventArgs e)
        {
            //settings
            DMT(dark);
            if (rTab == true) { tcMain.SelectedIndex = Properties.Settings.Default.restTabIndex_Main; }
            if (Properties.Settings.Default.openCalK)
            {
                CalKills();
                rtbReturn.AppendText("Start-up: Calculate Kills Form has been opened. Please check the Task Bar if you don't see it.\n");
            }
            if (Properties.Settings.Default.openBPD)
            {
                BluePrintD();
                rtbReturn.AppendText("Start-up: Blueprint Decoder Form has been opened. Please check the Task Bar if you don't see it.\n");
            }
            //

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
            ttCV.SetToolTip(lblCV, "0.5!!! A more General Utility!" +
                "\nA lot of time has passed between the last update and now, so some of the changes here may not be reflected." +
                "\n\nNew Utilities!" +
                "\n\tEssential Utilities: Module Drop Chance Calculator (MDCcalc)" +
                "\n\t\t→ Calculates a module's drop chance based on a player's input." +
                "\n\t\t→ Estimates how many rounds, on average it would take to get the module." +
                "\n\t\t→ A future update to this may add a new output that estimates a round time based off clearspeed." +
                "\n\tEssential Utilities: Blueprint Decoder" +
                "\n\nChanges" +
                "\n\t→ A friendlier dark mode suggested by Rak." +
                "\n\t→ Renamed Form1 to tpt Calculator, also suggested by Rak." +
                "\n\t→ Added \"math_ext.cs\" to facilitate some future stuff... :eyes:" +
                "\n\nSome new settings" +
                "\n\t→ Remember tab" +
                "\n\t→ Open Utilities on Startup");

            ttNamedConvert.SetToolTip(lblConvert, "Accepted \"Input Conversions\": " +
                "\n\nScientific Notation (use of \"e\" and \"E\")"
                + "\n\nK, k: Thousands (e3) \nM, m: Millions (e6) \nB, b: Billions (e9) \nT, t: Trillions (e12) \nq, QA, Qa, qA, qa: Quadrillions (e15) "
                + "\nQ, QI, Qi, qI, qi: Quintillions (e18) ");
        }

    }
}
