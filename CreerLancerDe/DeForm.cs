
using CreerLancerDe.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreerLancerDe
{

    public partial class DeDynamic : Form
    {
        public DeDynamic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DatabaseConn.DBConnect();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreationDe creationDe = new CreationDe();
            creationDe.Show();
        }

/*        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddSeq();
            });
        }*/
        }
}
