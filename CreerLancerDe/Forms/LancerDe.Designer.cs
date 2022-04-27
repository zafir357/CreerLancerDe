
namespace CreerLancerDe.Forms
{
    partial class LancerDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectedDice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnLancer = new System.Windows.Forms.Button();
            this.retourMain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedDice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 365);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SelectedDice
            // 
            this.SelectedDice.HeaderText = "Dé selectioner";
            this.SelectedDice.Name = "SelectedDice";
            this.SelectedDice.Width = 81;
            // 
            // btnLancer
            // 
            this.btnLancer.Location = new System.Drawing.Point(102, 3);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(98, 27);
            this.btnLancer.TabIndex = 2;
            this.btnLancer.Text = "Lancer";
            this.btnLancer.UseVisualStyleBackColor = true;
            this.btnLancer.Click += new System.EventHandler(this.button1_Click);
            // 
            // retourMain
            // 
            this.retourMain.Location = new System.Drawing.Point(3, 3);
            this.retourMain.Name = "retourMain";
            this.retourMain.Size = new System.Drawing.Size(93, 27);
            this.retourMain.TabIndex = 3;
            this.retourMain.Text = "Retour";
            this.retourMain.UseVisualStyleBackColor = true;
            this.retourMain.Click += new System.EventHandler(this.retourMain_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.retourMain);
            this.panel1.Controls.Add(this.btnLancer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 4;
            // 
            // LancerDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LancerDe";
            this.Text = "LancerDe";
            this.Load += new System.EventHandler(this.LancerDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedDice;
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.Button retourMain;
        private System.Windows.Forms.Panel panel1;
    }
}