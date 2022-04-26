using CreerLancerDe.Classes;
using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using static CréerLancerUnDé.Log.Logger;
namespace CreerLancerDe.Forms
{
    public partial class CreationDe : Form
    {
        public CreationDe()
        {
            InitializeComponent();
            loadListDropdown();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

/*        private void smtCreationDe_Click(object sender, EventArgs e)
        {
          //  validation.IntValidation(erreurNFaceNormal);
           int parsedValue=validation.IntValidation(txtNFace.Text.Trim(), errorNombreFaces, txtNFace);
            try
            {


            }
            catch(Exception ex) {
                ///   new Logger.Logger().WriteLogError(new Logger.Logger(new Logger.Logger { CallerInfo = MethodBase.GetCurrentMethod().DeclaringType, Ex = ex }));
                throw;
            }
           
        }*/


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbTypeDe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTypeDe_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            var x = cmbTypeDe.SelectedIndex;
        }

        private void loadListDropdown()
        {
     //       DataTable dt;
            //List<Type> types;
            string sql_string = CEnum.Queries.QueryTypeDe;
            List<TypeDe> types=  DatabaseConn.ListReader<TypeDe>(sql_string);
            cmbTypeDe.DataSource = types;
            cmbTypeDe.DisplayMember = "Type";
            cmbTypeDe.ValueMember = "Id";
                
        }

        private void smtCreation_Click(object sender, EventArgs e)
        {
           
            int parsedValue = validation.IntValidation(txtNFace.Text.Trim(), errorNombreFaces, txtNFace);
            DynamicParameters DeParams = new DynamicParameters();
            try
            {
                if (NomDeTxt.Text.ToString() != "" && cmbTypeDe.SelectedValue.ToString() != "" && NomDeTxt.Text.ToString() != "")
                {
                    DeParams.Add("@Nom", NomDeTxt.Text.Trim());
                    DeParams.Add("@Type", cmbTypeDe.SelectedValue.ToString());
                    DeParams.Add("@NFaces", txtNFace.Text.Trim());
                }
                if (((TypeDe)cmbTypeDe.SelectedItem).Type== "Dé Normal")
                {
                    gestionDeClassic(parsedValue, DeParams);

                }
                else
                {
                    MessageBox.Show("Tout les dé doit avoir un nom");
                }
                
            }
            catch (Exception ex)
            {
                ///   new Logger.Logger().WriteLogError(new Logger.Logger(new Logger.Logger { CallerInfo = MethodBase.GetCurrentMethod().DeclaringType, Ex = ex }));
                LogThisLine("Exception Interne" + ex.ToString());
            }
        }

        private void gestionDeClassic(int parsedValue, DynamicParameters DeParams)
        {
            List<int> dynList = new List<int>();
            DynamicParameters ParamContenuDe = new DynamicParameters();
            int id;
            De de;
            try
            {
                for (int i = 1; i <= parsedValue; i++)
                {
                    dynList.Add(i);
                }
                string strFaces = String.Join("|",dynList.ToArray());
                //string JsonObject = JsonConvert.SerializeObject(dynList);
                ParamContenuDe.Add("@strContenu", strFaces);
                id = DatabaseConn.InsertData<ContenuDe>(CEnum.Queries.QueryInsertContenuDe, ParamContenuDe);
                DeParams.Add("@Contenu_de",id);
                try
                {
                    if (id > -1)
                    {
                         de= new De(parsedValue, Int32.Parse(cmbTypeDe.SelectedValue.ToString()), NomDeTxt.Text.Trim(), id);
                       int insertion= DatabaseConn.InsertData<De>(CEnum.Queries.QueryInsertDe, DeParams);
                        if (insertion >-1)
                        {
                            ViderChampCreationDe();
                            MessageBox.Show("Dé sauvegarder");
                        }
                    }
                }
                catch(Exception ex)
                {
                    LogThisLine("Exception Interne"+ex.ToString());
                    MessageBox.Show("Problème technique.  Essayer plus tard");
                }
            }
            catch (Exception ex)
            {
                LogThisLine(ex.ToString());
            }

        }

        private void ViderChampCreationDe()
        {
            txtNFace.Clear();
            NomDeTxt.Clear();
            txtNFace.Clear();
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            DeFormMain backMain = new DeFormMain();
 
            backMain.Show();
            this.Hide();
            backMain.Closed += (s, args) => this.Close();
            backMain.Show();
        }
    }
}
