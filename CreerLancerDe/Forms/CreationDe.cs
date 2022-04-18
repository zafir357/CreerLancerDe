using System;
using System.Windows.Forms;

namespace CreerLancerDe.Forms
{
    public partial class CreationDe : Form
    {
        public CreationDe()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void smtCreationDe_Click(object sender, EventArgs e)
        {
          //  validation.IntValidation(erreurNFaceNormal);
           int parsedValue=validation.IntValidation(txtNFace.Text.Trim(), erreurNFaceNormal, txtNFace);
            try
            {
                if (NomDeTxt != null)
                {
                    DeNormal De = new DeNormal(parsedValue, 3);
                }
            }
            catch(Exception ex) {
                ///   new Logger.Logger().WriteLogError(new Logger.Logger(new Logger.Logger { CallerInfo = MethodBase.GetCurrentMethod().DeclaringType, Ex = ex }));
                throw;
            }
           
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

/*        private int IntValidation(string intTxt)
        {
            int parsedValue;
            if (!int.TryParse(intTxt, out parsedValue))
            {
                erreurNFaceNormal.SetError(txtNFace, CEnum.Erreurs.errNumType);
                return 0;
            }
            else
            {
                return parsedValue;
            }

        }*/
    }
}
