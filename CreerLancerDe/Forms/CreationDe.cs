using CreerLancerDe.Classes;
using CreerLancerDe.Utility_classes;
using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Windows.Forms;
using static CréerLancerUnDé.Log.Logger;
namespace CreerLancerDe.Forms
{
    public partial class CreationDe : Form
    {

        #region Initialisation du form
        public CreationDe()
        {
            InitializeComponent();
            loadListDropdown();
        }
        #endregion

        private void loadListDropdown()
        {

            string sql_string = CEnum.Queries.QueryTypeDe;
            List<TypeDe> types = DatabaseConn.ListReader<TypeDe>(sql_string);
            cmbTypeDe.DataSource = types;
            cmbTypeDe.DisplayMember = "Type";
            cmbTypeDe.ValueMember = "Id";

        }


        #region Gestion combo
        private void cmbTypeDe_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (((TypeDe)cmbTypeDe.SelectedItem).Type == "Dé personnalisés")
                {
                    if (txtNFace.Text.Trim() != "")
                    {
                        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
                        panel1.AutoScroll = true;
                        int parsedValue = validation.IntValidation(txtNFace.Text.Trim(), errorNombreFaces, txtNFace);
                        TextBox[] textBoxes = new TextBox[parsedValue];
                        Label[] labels = new Label[parsedValue];
                        int pointX = 80;
                        int pointY = 150;
                        int pointxL = 20;
                        panel1.Controls.Clear();
                        textGenerate(parsedValue, pointX, pointY, pointxL);
                    }
                }
                else if (((TypeDe)cmbTypeDe.SelectedItem).Type == "Dé Normal")
                {
                    panel1.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                LogThisLine(ex.ToString());
                MessageBox.Show("Problème technique.  Essayer plus tard");
            }
        } 
        #endregion

        #region Générer texte dynamique 
        private void textGenerate(int parsedValue, int pointX, int pointY, int pointxL)
        {
            try
            {
                panel1.Controls.Clear();
                for (int i = 0; i < parsedValue; i++)
                {
                    TextBox a = (new TextBox() { AutoSize = true });
                    Label b = (new Label() { AutoSize = true });
                    b.Text = "Face" + (i + 1).ToString();
                    b.ForeColor = Color.Black;
                    a.Name = "Face" + (i + 1).ToString();
                    a.Location = new Point(pointX, pointY);
                    b.Location = new Point(pointxL, pointY);
                    panel1.Controls.Add(b);
                    panel1.Controls.Add(a);
                    a.Enabled = true;
                    b.Enabled = true;
                    panel1.Show();
                    pointY += 20;
                }
                this.labelSetter(pointX);
            }
            catch (Exception ex)
            {
                LogThisLine(ex.ToString());
                MessageBox.Show("Problème technique.  Essayer plus tard");
            }
        }
        #endregion

        #region Gestion des multiple types de dé
        private void smtCreation_Click(object sender, EventArgs e)
        {

            int parsedValue = validation.IntValidation(txtNFace.Text.Trim(), errorNombreFaces, txtNFace);
            DynamicParameters DeParams = new DynamicParameters();
            try
            {
                if (NomDeTxt.Text.ToString() != "" && cmbTypeDe.SelectedValue.ToString() != "")
                {
                    DeParams.Add("@Nom", NomDeTxt.Text.Trim());
                    DeParams.Add("@Type", cmbTypeDe.SelectedValue.ToString());
                    DeParams.Add("@NFaces", txtNFace.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Tout les dé doit avoir un nom et un nombre de faces");
                    return;
                }

                if (((TypeDe)cmbTypeDe.SelectedItem).Type == "Dé Normal")
                {
                    gestionDeClassic(parsedValue, DeParams);

                }
                else if (((TypeDe)cmbTypeDe.SelectedItem).Type == "Dé personnalisés")
                {
                    gestionDePersonaliser(parsedValue, DeParams);
                }


            }
            catch (Exception ex)
            {
                LogThisLine("Exception Interne" + ex.ToString());
            }
        }
        #endregion

        #region Ajouter dé classique à la base
        private void gestionDeClassic(int parsedValue, DynamicParameters DeParams)
        {
            List<dynamic> dynList = new List<dynamic>();
            DynamicParameters ParamContenuDe = new DynamicParameters();
            bool strJoin = MethodsLancementDe.bouclerList(parsedValue, dynList, ParamContenuDe);
            if (strJoin == true)
            {
                bool insert = insertionBase(ParamContenuDe, DeParams, parsedValue);
                if (insert == true)
                {
                    errorNombreFaces.Clear();
                    MessageBox.Show("Dé sauvegarder");
                }
                else
                {
                    MessageBox.Show("Problème technique.  Essayer plus tard");
                }
            }
            else
            {
                MessageBox.Show("Problème technique.  Essayer plus tard");
            }
        } 
        #endregion
        #region Gestion De Personaliser
        private void gestionDePersonaliser(int parsedValue, DynamicParameters DeParams)
        {
            DynamicParameters ParamContenuDe = new DynamicParameters();
            List<object> listTxtDynamic = new List<object>();
            string strFaces;
            bool loopTxt = customTxtJoin(parsedValue, listTxtDynamic);

            if (loopTxt == true)
            {
                strFaces = String.Join("|", listTxtDynamic.ToArray());
                if (strFaces != "")
                {
                    ParamContenuDe.Add("@strContenu", strFaces);
                    bool insert = insertionBase(ParamContenuDe, DeParams, parsedValue);
                    if (insert == true)
                    {
                        errorNombreFaces.Clear();
                        panel1.Controls.Clear();
                        MessageBox.Show("Dé sauvegarder");
                    }

                }
                else
                {
                    MessageBox.Show("Problème technique.  Essayer plus tard");
                    return;
                }
            }
            else
            {
                ViderChampCreationDe();
                return;
            }


        }
        #endregion

        #region Ajouter chaque valeur du textbox dynamique dans une list
        private bool customTxtJoin(int parsedValue, List<dynamic> listTxtDynamic)
        {
            try
            {
                for (int i = 0; i < parsedValue; i++)
                {
                    TextBox txtCounter = ((TextBox)this.Controls.Find(("Face" + (i + 1)).ToString(), true).FirstOrDefault());
                    if (txtCounter.Text.Trim() != "")
                    {
                        listTxtDynamic.Add(txtCounter.Text);
                    }
                    else
                    {
                        TextBox txtvide = ((TextBox)this.Controls.Find(("Face" + (i)).ToString(), true).FirstOrDefault());
                        MessageBox.Show("Les zones de texte ne peuvent pas être vide");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                LogThisLine(ex.ToString());
                return false;
            }
        }
        #endregion



        #region Vider les champs principaux
        private void ViderChampCreationDe()
        {
            txtNFace.Clear();
            NomDeTxt.Clear();
        }

        #endregion

        #region Retour à la page principale

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            DeFormMain backMain = new DeFormMain();

            backMain.Show();
            this.Hide();
            backMain.Closed += (s, args) => this.Close();
            backMain.Show();
        }

        #endregion
        #region l'instance ou le text du champ nombre faces changent
        private void txtNFace_TextChanged(object sender, EventArgs e)
        {
            int parsedValue = validation.IntValidation(txtNFace.Text.Trim(), errorNombreFaces, txtNFace);
            if (parsedValue > -1)
            {
                cmbTypeDe_SelectedIndexChanged_1(sender, e);
                cmbTypeDe.Enabled = true;
            }
            else
            {
                cmbTypeDe.Enabled = false;
            }
        }
        #endregion
        #region MyRegion
        private void labelSetter(int pointX)
        {
            Label c = (new Label() { AutoSize = true });
            c.ForeColor = Color.DarkBlue;
            c.Location = new Point(pointX + 110, 150);
            c.Text = "Utiliser virgule pour multiples valeur sur une face";
            panel1.Controls.Add(c);
            c.Enabled = true;
            c.Show();
        }
        #endregion

        #region Ajouter le contenu d'un de(classique ou personnaliser)à la base
        public bool insertionBase(DynamicParameters ParamContenuDe, DynamicParameters DeParams, int parsedValue)
        {
            int id;
            int insertion;
            De de;
            try
            {
                id = DatabaseConn.InsertData<ContenuDe>(CEnum.Queries.QueryInsertContenuDe, ParamContenuDe);
                DeParams.Add("@Contenu_de", id);
                if (id > -1)
                {
                    de = new De(parsedValue, Int32.Parse(cmbTypeDe.SelectedValue.ToString()), NomDeTxt.Text.Trim(), id);
                    insertion = DatabaseConn.InsertData<De>(CEnum.Queries.QueryInsertDe, DeParams);
                    if (insertion > -1)
                    {
                        ViderChampCreationDe();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogThisLine("Exception Interne" + ex.ToString());
                return false;
            }
        } 
        #endregion

    }
}
