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
            int maxAge = des.Max(t => t.Faces);
          //  dataGridView1.ColumnCount = 4 + maxAge;
            dataGridView1.Columns[1].Name = "Nom";
            dataGridView1.Columns[2].Name = "Faces";
            dataGridView1.Columns[3].Name = "Type";
            for(int i = 1; i <= maxAge; i++)
            {
                dataGridView1.Columns[i+3].Name = "Face" + (i);
            }



        }



        private void loadDropDownDe()
        {
            string sql_string = CEnum.Queries.QueryTypeDe;
            List<TypeDe> types = DatabaseConn.ListReader<TypeDe>(sql_string);
            
            comboBox1.DataSource = types;
            comboBox1.DisplayMember = "Type";
            comboBox1.ValueMember = "Id";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LancerDe_Load(object sender, EventArgs e)
        {
             
        }
    }
    }

