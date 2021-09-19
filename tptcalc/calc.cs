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
		public void CXP(long era, long dropstat, NumericUpDown xpmod, NumericUpDown awamod, TextBox LowX, TextBox HighX, TextBox AveX, RichTextBox debug)
		{
			double xpB = 1 + Mod2Bonus_XPB(int.Parse(xpmod.Value.ToString()));
			double awaB = 1 + Mod2Bonus_AWA(int.Parse(awamod.Value.ToString()));
			//debug.AppendText(Math.Pow(dropstat, 0.05).ToString() + Environment.NewLine); //(checked as correct)

			// (0.5 + rand(0,1) + era^0.2) * xpB
			//Random random = new Random(); //if you wanna use the random function
			//double rand = random.Next(0, 100)/100; //for simplicity and rounding sake
			
			LowX.Text = CXPF(0.5).ToString();
			HighX.Text = CXPF(1.5).ToString();
			AveX.Text = CXPF(1).ToString();

			double CXPF(double ave)
			{
				double E = ((ave + Math.Pow(era, 0.2)) * xpB * awaB * Math.Pow(dropstat, 0.05));
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



		public void CSP(long kills, double time, NumericUpDown regNo, TextBox cspd, CheckBox chkElement)
		{
			int regions = int.Parse(regNo.Value.ToString());
			int paths = Reg2Paths(regions);
			int elements = 1; //initialised if the checkbox wasn't checked

            if (chkElement.Checked)
            {
				elements = Reg2Elements(regions);
            }

			double cSpd = (kills*elements) / (time * paths);

			cspd.Text = cSpd.ToString() + "  clears/sec";
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


		public void EDC(int Cost, int n, TextBox D2, TextBox D3, TextBox D4, TextBox D5, TextBox DN)
		{
			D2.Text = Cost2Disable(Cost, 2).ToString();
			D3.Text = Cost2Disable(Cost, 3).ToString();
			D4.Text = Cost2Disable(Cost, 4).ToString();
			D5.Text = Cost2Disable(Cost, 5).ToString();
			DN.Text = Cost2Disable(Cost, n).ToString();
		}

		private double Cost2Disable (int cost, int nth)
		{
			double value = cost*(Math.Pow((cost +(1000-cost)/10),nth-1));//X * ( X + ( ( 1000 - X ) / 10 ) ^ ( n - 1 ) ) 
			return value;
		}

	}
}
