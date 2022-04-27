using CreerLancerDe.Classes;
using CreerLancerDe.Model;
using CreerLancerDe.Utility_classes;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreerLancerDe.Forms
{
    public partial class LancerDe : Form
    {
        public LancerDe()
        {
            InitializeComponent();
            loadDe();
            
        }


        #region chargement des dé dans une liste par rapport aux models
        private void loadDe()
        {
            List<DeModel> des = DatabaseConn.DeContenuDe();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(des);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            var x = dataGridView1.Columns;

        } 
        #endregion


        #region Button lancement dé

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> random = new List<object>();
            string message = string.Empty;
            dynamic cellRandom = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectedDice"].Value);
                if (isSelected)
                {

                    List<object> listCount = new List<object>();

                    foreach (DataGridViewCell dataGridViewCell in row.Cells)
                    {
                        if (dataGridViewCell.ColumnIndex > 3 && dataGridViewCell.FormattedValue.ToString() != "")
                        {
                            listCount.Add(dataGridViewCell.Value);
                        }


                    }
                    cellRandom = (FaceAleatoire(listCount));

                    row.Cells[row.Cells.Count - 1].Value = cellRandom;
                }



            }
        }
        #endregion

        #region Logic pour génerer la face aléatoire
        private dynamic FaceAleatoire(List<object> listCount)
        {
            Random rnd = new Random();
            dynamic x = listCount.ToArray();
            int index = rnd.Next(listCount.ToArray().Length);
            dynamic returnValue = listCount[index];
            return returnValue;
        } 
        #endregion

        #region Retour à la page principale
        private void retourMain_Click(object sender, EventArgs e)
        {
            DeFormMain backMain = new DeFormMain();
            this.Hide();
            backMain.Closed += (s, args) => this.Close();
            backMain.Show();

        } 
        #endregion
    }
}

