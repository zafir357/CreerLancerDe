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
        private static ConnectionStringSettings connectionStringSet = ConfigurationManager.ConnectionStrings["DBConnection"];
        private static string connectionString = connectionStringSet.ConnectionString;
        public LancerDe()
        {
            InitializeComponent();
            loadDe();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        } 

        private void loadDe()
        {
            List<DeModel> des = DatabaseConn.DeContenuDe();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(des);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            var x=dataGridView1.Columns;
/*            int maxAge = des.Max(t => t.Faces);
          //  dataGridView1.ColumnCount = 4 + maxAge;
            dataGridView1.Columns[1].Name = "Nom";
            dataGridView1.Columns[2].Name = "Faces";
            dataGridView1.Columns[3].Name = "Type";
            for(int i = 1; i <= maxAge; i++)
            {
                dataGridView1.Columns[i+3].Name = "Face" + (i);
            }*/



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // I suppose your check box is at column index 0
            // To exclude header cell:  e.RowIndex >= 0  
            // To exclude new row:      celle.RowIndex!=dataGridView1.newRowIndex

            if (e.ColumnIndex == 0 && e.RowIndex >= 0 && e.RowIndex != dataGridView1.NewRowIndex)
            {
                //Put the logic here
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void LancerDe_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> random= new List<object>();
            string message = string.Empty;
            dynamic cellRandom=null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectedDice"].Value);
                if (isSelected)
                {
                    
                    List<object> listCount = new List<object>();

                  /*  row.Cells[0].Visible = false;
                  */
                        foreach (DataGridViewCell dataGridViewCell in row.Cells)
                        {
                        if (dataGridViewCell.ColumnIndex > 3 && dataGridViewCell.FormattedValue.ToString() !="")
                                 {
                                    listCount.Add(dataGridViewCell.Value);
                                 }

                          
                        }
                    cellRandom= (FaceAleatoire(listCount));
             /*       message += Environment.NewLine;
                    message += row.Cells["Name"].Value.ToString();*/
                }

                
                    row.Cells[row.Cells.Count - 1].Value = cellRandom;
                



            }
        }

        private dynamic FaceAleatoire(List<object> listCount)
        {
            Random rnd = new Random();
            dynamic x= listCount.ToArray();
            int index = rnd.Next(listCount.ToArray().Length);
            dynamic returnValue = listCount[index];
            return returnValue;
            //   int index=rnd.Next(listCount.Select(x => x.Name).ToArray();)
        }

        private void retourMain_Click(object sender, EventArgs e)
        {
            DeFormMain backMain = new DeFormMain();
            this.Hide();
            backMain.Closed += (s, args) => this.Close();
            backMain.Show();
            
        }
    }
    }

