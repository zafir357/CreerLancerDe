using CreerLancerDe.Classes;
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
   
        public CreationDe()
        {
            InitializeComponent();
            loadListDropdown();
        }

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
            catch(Exception ex)
            {
                LogThisLine(ex.ToString());
                MessageBox.Show("Problème technique.  Essayer plus tard");
            }
        }

        private void textGenerate(int parsedValue, int pointX, int pointY, int pointxL)
        {
            try
            {
                for (int i = 0; i < parsedValue; i++)
                {
                    TextBox a = (new TextBox() { AutoSize = true });
                    Label b = (new Label() { AutoSize = true });
                    b.Text = "Face" + (i + 1).ToString();
                    b.ForeColor = Color.Black;
                    a.Name = "Face" + (i + 1).ToString();
                    a.Text = (i + 1).ToString();
                    a.Location = new Point(pointX, pointY);
                    b.Location = new Point(pointxL, pointY);
                    panel1.Controls.Add(b);
                    panel1.Controls.Add(a);
                    a.Enabled = true;
                    b.Enabled = true;
                    panel1.Show();
                    pointY += 20;
                }
                this.labelSetter(pointX, pointY);
            }
            catch (Exception ex)
            {
                LogThisLine(ex.ToString());
                MessageBox.Show("Problème technique.  Essayer plus tard");
            }
        }

            private void loadListDropdown()
        {

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
                if (NomDeTxt.Text.ToString() != "" && cmbTypeDe.SelectedValue.ToString() != "")
                {
                    DeParams.Add("@Nom", NomDeTxt.Text.Trim());
                    DeParams.Add("@Type", cmbTypeDe.SelectedValue.ToString());
                    DeParams.Add("@NFaces", txtNFace.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Tout les dé doit avoir un nom et un nombre de faces");
                }

                if (((TypeDe)cmbTypeDe.SelectedItem).Type== "Dé Normal")
                {
                    gestionDeClassic(parsedValue, DeParams);

                }
                else if(((TypeDe)cmbTypeDe.SelectedItem).Type == "Dé personnalisés")
                {
                    gestionDePersonaliser(parsedValue, DeParams);
                }
               
                
            }
            catch (Exception ex)
            {
                LogThisLine("Exception Interne" + ex.ToString());
            }
        }

        private void gestionDeClassic(int parsedValue, DynamicParameters DeParams)
        {
            List<int> dynList = new List<int>();
            DynamicParameters ParamContenuDe = new DynamicParameters();
            int id;
            string strFaces;
            try
            {
                for (int i = 1; i <= parsedValue; i++)
                {
                    dynList.Add(i);
                }
                strFaces = String.Join("|",dynList.ToArray());
                ParamContenuDe.Add("@strContenu", strFaces);
                id = DatabaseConn.InsertData<ContenuDe>(CEnum.Queries.QueryInsertContenuDe, ParamContenuDe);
                DeParams.Add("@Contenu_de",id);
                bool insert = insertionBase(ParamContenuDe, DeParams, parsedValue);
                if(insert == true){
                     errorNombreFaces.Clear();
                     MessageBox.Show("Dé sauvegarder");
                }
                else
                {
                    MessageBox.Show("Problème technique.  Essayer plus tard");
                }
            }
            catch (Exception ex)
            {
                LogThisLine(ex.ToString());
                MessageBox.Show("Problème technique.  Essayer plus tard");
            }

        }

        private void gestionDePersonaliser(int parsedValue, DynamicParameters DeParams)
        {
            List<object> listTxtDynamic = new List<object>();
            for (int i = 0; i < parsedValue; i++)
            {
                TextBox txtCounter = ((TextBox)this.Controls.Find(("Face" + (i + 1)).ToString(), true).FirstOrDefault());
                listTxtDynamic.Add(txtCounter.Text);
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

        private void txtNFace_TextChanged(object sender, EventArgs e)
        {
            int parsedValue = validation.IntValidation(txtNFace.Text.Trim(), errorNombreFaces, txtNFace);
            if (parsedValue>-1)
            {
                cmbTypeDe.Enabled = true;
            }
            else
            {
                cmbTypeDe.Enabled = false;
            }
         
        }
        private void labelSetter(int pointX, int pointY)
        {
            Label c = (new Label() { AutoSize = true });
            c.ForeColor = Color.DarkBlue;
            c.Location = new Point(pointX + 110, pointY - 100);
            c.Text = "Utiliser virgule pour multiples valeur sur une face";
            panel1.Controls.Add(c);
            c.Enabled = true;
            c.Show();
        }

        public bool insertionBase(DynamicParameters ParamContenuDe, DynamicParameters DeParams, int parsedValue)
        {
            int id;
            int insertion;
            De de;
            id = DatabaseConn.InsertData<ContenuDe>(CEnum.Queries.QueryInsertContenuDe, ParamContenuDe);
            DeParams.Add("@Contenu_de", id);
            try
            {
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

    }
}
