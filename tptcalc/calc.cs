using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tptcalc
{
	public class calc
	{
		public void CXP(double era, double dropstat, NumericUpDown xpmod, NumericUpDown awamod, TextBox LowX, TextBox HighX, TextBox AveX, RichTextBox debug,
						CheckBox checkbox2log)
		{
			double xpB = 1 + Mod2Bonus_XPB(int.Parse(xpmod.Value.ToString()));
			double awaB = 1 + Mod2Bonus_AWA(int.Parse(awamod.Value.ToString()));
			double dropStat = 1;

			if (checkbox2log.Checked)
			{ 
				dropStat = Math.Pow(10, (dropstat * 0.05));
			}
			else if (checkbox2log.Checked != true) 
			{ 
				dropStat = Math.Pow(dropstat, 0.05);
			}

			//debug.AppendText(Math.Pow(dropstat, 0.05).ToString() + Environment.NewLine); //(checked as correct)

			// (0.5 + rand(0,1) + era^0.2) * xpB
			//Random random = new Random(); //if you wanna use the random function
			//double rand = random.Next(0, 100)/100; //for simplicity and rounding sake

			LowX.Text = CXPF(0.5).ToString();
			HighX.Text = CXPF(1.5).ToString();
			AveX.Text = CXPF(1).ToString();

			double CXPF(double ave)
			{
				double E = ((ave + Math.Pow(era, 0.2)) * xpB * awaB * dropStat);
				return E;
			}

		}


		private double Mod2Bonus_XPB(int mod)
		{
			switch (mod)
			{
				case 0:
					return 0;
				case 1:
					return 0.2;
				case 2:
					return 0.26;
				case 3:
					return 0.35;
				case 4:
					return 0.5;
				case 5:
					return 0.7;
				default: //between 6 and 25
					return (0.185 + (mod*0.1));
			}
		}

		private double Mod2Bonus_AWA(int mod)
        {
            switch (mod) //120sec cooldown
            {
				case 1:
					return 0.3; //up for 35 sec
				case 2:
					return 0.5; //up for 40 sec
				case 3:
					return 0.7; //up for 45 sec
				case 4:
					return 1.0; //up for 55 sec
				case 5:
					return 1.2; //up for 60 sec

				default: //if 0
					return 0;
			}
        }



		public void CSP(long kills, double time, NumericUpDown regNo, TextBox cspd, CheckBox chkElement, ComboBox cbDifficulty, bool impossible, 
						TextBox kps, CheckBox WC, int spdMod, bool MoreAcc)
		{
			int regions = int.Parse(regNo.Value.ToString());
			int paths = Reg2Paths(regions);
			int elements = 1; //initialised if the checkbox wasn't checked
			double difficulty = cb2Difficulty(cbDifficulty, WC);
			double enemies_wave = EnemiesPerWave(difficulty, paths, MoreAcc);

			if (chkElement.Checked && impossible)
			{
				elements = 10;
			}
			else if (chkElement.Checked && impossible != true)
            {
				elements = Reg2Elements(regions);
            }

			double cSpd = (kills * elements * spdMod) / (time * enemies_wave);
			double KpS = (kills * elements * spdMod) / time;

			cspd.Text = cSpd.ToString() + "  clears/sec";
			kps.Text = KpS.ToString() + "  kills/sec";
		}

		private int Reg2Paths(int regNo)
		{
			switch (regNo)
			{
				case 5:
					return 3;
				case 1: case 3: case 4: case 7:
					return 4;
				case 6: case 9: case 14:
					return 5;
				case 2: case 10: case 11: case 13:
					return 6;
				case 8:
					return 7;
				case 12:
					return 9;
				default: //case 15:
					return 10;
			}
		}

		private int Reg2Elements(int regNo)
        {
			switch (regNo)
            {
				case 11:
					return 2;
				case 1: case 2:
					return 4;
				case 10: case 12:
					return 5;
				case 3:	case 13:
					return 6;
				case 4:	case 5: case 6:	case 7:	case 8:	case 9:
					return 7;
				case 14:
					return 8;
				default: //case 15:
					return 10;

            }
        }

		private double cb2Difficulty(ComboBox c2d, CheckBox wc)
        {
			if (wc.Checked)
			{
				switch (c2d.SelectedIndex)
				{
					case 1:
						return 3;
					case 2:
						return 4;
					case 3:
						return 5;
					case 4:
						return 5;
					default:
						return 2;
				}
			}
            else
            {
				switch (c2d.SelectedIndex)
				{
					case 1:
						return 6;
					case 2:
						return 8;
					case 3:
						return 9;
					case 4:
						return 10;
					default:
						return 4;
				}

			}
		}

		private double EnemiesPerWave(double diff, double paths, bool mAcc)
        {
			double epw;
			if (mAcc)
			{ epw = (diff * paths * 0.9) + (((diff - 1) * paths + 1) * 0.1); }
			else
			{ epw = (diff * paths); }
			return epw;
		}


		public void EDC(double Cost, double n, TextBox D2, TextBox D3, TextBox D4, TextBox D5, TextBox DN)
		{
			D2.Text = Cost2Disable(Cost, 2).ToString();
			D3.Text = Cost2Disable(Cost, 3).ToString();
			D4.Text = Cost2Disable(Cost, 4).ToString();
			D5.Text = Cost2Disable(Cost, 5).ToString();
			DN.Text = Cost2Disable(Cost, n).ToString();
		}

		private double Cost2Disable (double cost, double nth)
		{
			cost = Math.Round(cost / 10) * 10;
			nth = Math.Round(nth / 10) * 10;
			double value = cost*(Math.Pow((cost +(1000-cost)/10),nth-1));//X * ( X + ( ( 1000 - X ) / 10 ) ^ ( n - 1 ) ) 
			return value;
		}

	}
}
