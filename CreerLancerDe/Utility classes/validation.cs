


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CréerLancerUnDé.Log.Logger;
namespace CreerLancerDe
{
    class validation
    {
        #region Validation champ nombre de faces
        public static int IntValidation(string intTxt, ErrorProvider errorProvider, TextBox text)
        {
            int parsedValue;

            try
            {
                errorProvider.Clear();
                if (intTxt == CEnum.Variables.empty)
                {
                    errorProvider.SetError(text, CEnum.Erreurs.errNumNull);
                    return -1;
                }

                else if (!int.TryParse(intTxt, out parsedValue))
                {
                    errorProvider.SetError(text, CEnum.Erreurs.errNumType);
                    return -1;
                }
                else
                {
                    if (parsedValue > 0)
                    {
                        return parsedValue;
                    }
                    else
                    {
                        return -1;
                    }

                }
            }
            catch (Exception ex)
            {
                LogThisLine("Exception Interne" + ex.ToString());
                MessageBox.Show("Problème technique.  Essayer plus tard");
                return 0;
            }



        } 
        #endregion


    }
}
