﻿
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

    public partial class DeFormMain : Form
    {
        public DeFormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //DatabaseConn.DBConnect();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            CreationDe creationDe = new CreationDe();
            
            creationDe.Show();
            this.Hide();
            creationDe.Closed += (s, args) => this.Close();
            creationDe.Show();
        }

        private void LancerDe_Click(object sender, EventArgs e)
        {
            LancerDe runDice = new LancerDe();
            this.Hide();
            runDice.Closed += (s, args) => this.Close();
            runDice.Show();
         //   this.Close();
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
