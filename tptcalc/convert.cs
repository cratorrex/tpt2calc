using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tptcalc
{
    class convert
    {
        RichTextBox error;

        public long CheckConvert(TextBox txtInput, RichTextBox rAppend)
        {
            error = rAppend;
            string input = txtInput.Text;
            long output;

            //checks for scientific
            if (input.Contains("e") || input.Contains("E"))
            {
                output = Sci(input);
                //rAppend.AppendText("convert.cs: Input converted to " + output + Environment.NewLine);
                return output;
            }

            //checks for short named (counts up to Trillions, may update with more)
            else if (input.EndsWith("K") || input.EndsWith("k") || input.EndsWith("M") || input.EndsWith("m") || input.EndsWith("B") || input.EndsWith("b") || input.EndsWith("T") || input.EndsWith("t"))
            {
                output = SNamed(input);
                //rAppend.AppendText("convert.cs: Input converted to " + output + Environment.NewLine);
                return output;
            }

            else if (long.TryParse(input, out _) == false)
            {
                rAppend.AppendText("convert.cs: Input could not be recognised." + Environment.NewLine);
                return 0;
            }

            else
            {
                return long.Parse(input);
            }
        }

        private long Sci(string input)
        {
            try {
                long output = long.Parse(input, NumberStyles.Float);
                return output;
            }

            catch
            {
                error.AppendText("convert.cs: Input could not be converted, treated as 0." + Environment.NewLine);
                return 0;
            }

        }

        private long SNamed(string input)
        {
            decimal output = 0;

            try{

                if (input.EndsWith("k") || input.EndsWith("K"))
                    output = Math.Round((Convert.ToDecimal(input.TrimEnd('k', 'K')) * 1000), 0);

                if (input.EndsWith("m") || input.EndsWith("M"))
                    output = Math.Round((Convert.ToDecimal(input.TrimEnd('m', 'M')) * 1000000), 0);

                if (input.EndsWith("b") || input.EndsWith("B"))
                    output = Math.Round((Convert.ToDecimal(input.TrimEnd('b', 'B')) * 1000000000), 0);

                if (input.EndsWith("t") || input.EndsWith("T"))
                    output = Math.Round((Convert.ToDecimal(input.TrimEnd('t', 'T')) * 1000000000000), 0);
            }

            catch
            {
                error.AppendText("convert.cs: Input could not be converted, treated as 0." + Environment.NewLine);
            }

            return long.Parse(output.ToString());
        }
    }
}
