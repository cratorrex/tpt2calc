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
		public void CXP(int era, NumericUpDown xpmod, TextBox LowX, TextBox HighX, TextBox AveX, RichTextBox error)
		{
			double xpB = 1 + Mod2Bonus(int.Parse(xpmod.Value.ToString()));

			// (0.5 + rand(0,1) + era^0.2) * xpB
			Random random = new Random();
			double rand = random.Next(0, 100)/100; //for simplicity and rounding sake
			
			LowX.Text = ((0.5 + Math.Pow(era, 0.2)) * xpB).ToString();
			HighX.Text = ((1.5 + Math.Pow(era, 0.2)) * xpB).ToString();
			AveX.Text = ((1 + Math.Pow(era, 0.2)) * xpB).ToString();
		}

		private double Mod2Bonus(int mod)
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



		public void CSP(int kills, double time, NumericUpDown regNo, TextBox cspd, RichTextBox error)
		{
			int paths = Reg2Paths(int.Parse(regNo.Value.ToString()));

			double cSpd = kills / (time * paths);

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
				case 2: case 10: case 11: case 12: case 13:
					return 6;
				case 8:
					return 7;
				default: //case 15:
					return 10;
			}
		}


	}
}
