using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreerLancerDe
{
    class validation
    {
        public static int IntValidation(string intTxt, ErrorProvider errorProvider, TextBox text)
        {
            int parsedValue;
            if (intTxt==CEnum.Variables.empty)
            {
                errorProvider.SetError(text, CEnum.Erreurs.errNumNull);
                return 0;
            }

            else if (!int.TryParse(intTxt, out parsedValue))
            {
                errorProvider.SetError(text,CEnum.Erreurs.errNumType);
                return 0;
            }
            else
            {
                if (parsedValue > 0)
                {
                    return parsedValue;
                }
                else
                {
                    return 0;
                }

            }

        }
    }
}
