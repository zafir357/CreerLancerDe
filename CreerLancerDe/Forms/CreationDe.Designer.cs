
namespace CreerLancerDe.Forms
{
    partial class CreationDe
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
            this.components = new System.ComponentModel.Container();
            this.cmbTypeDe = new System.Windows.Forms.ComboBox();
            this.lblTypeDe = new System.Windows.Forms.Label();
            this.NomDeTxt = new System.Windows.Forms.TextBox();
            this.txtNFace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.smtCreation = new System.Windows.Forms.Button();
            this.errorNombreFaces = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBackMain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreFaces)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTypeDe
            // 
            this.cmbTypeDe.Enabled = false;
            this.cmbTypeDe.FormattingEnabled = true;
            this.cmbTypeDe.Location = new System.Drawing.Point(105, 84);
            this.cmbTypeDe.Name = "cmbTypeDe";
            this.cmbTypeDe.Size = new System.Drawing.Size(81, 21);
            this.cmbTypeDe.TabIndex = 14;
            this.cmbTypeDe.SelectedIndexChanged += new System.EventHandler(this.cmbTypeDe_SelectedIndexChanged_1);
            // 
            // lblTypeDe
            // 
            this.lblTypeDe.AutoSize = true;
            this.lblTypeDe.Location = new System.Drawing.Point(17, 87);
            this.lblTypeDe.Name = "lblTypeDe";
            this.lblTypeDe.Size = new System.Drawing.Size(46, 13);
            this.lblTypeDe.TabIndex = 13;
            this.lblTypeDe.Text = "Type de";
            // 
            // NomDeTxt
            // 
            this.NomDeTxt.Location = new System.Drawing.Point(105, 47);
            this.NomDeTxt.Name = "NomDeTxt";
            this.NomDeTxt.Size = new System.Drawing.Size(81, 20);
            this.NomDeTxt.TabIndex = 11;
            // 
            // txtNFace
            // 
            this.txtNFace.Location = new System.Drawing.Point(105, 10);
            this.txtNFace.Name = "txtNFace";
            this.txtNFace.Size = new System.Drawing.Size(81, 20);
            this.txtNFace.TabIndex = 8;
            this.txtNFace.TextChanged += new System.EventHandler(this.txtNFace_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom du dé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de faces";
            // 
            // smtCreation
            // 
            this.smtCreation.Location = new System.Drawing.Point(328, 108);
            this.smtCreation.Name = "smtCreation";
            this.smtCreation.Size = new System.Drawing.Size(75, 23);
            this.smtCreation.TabIndex = 15;
            this.smtCreation.Text = "Submit";
            this.smtCreation.UseVisualStyleBackColor = true;
            this.smtCreation.Click += new System.EventHandler(this.smtCreation_Click);
            // 
            // errorNombreFaces
            // 
            this.errorNombreFaces.ContainerControl = this;
            // 
            // btnBackMain
            // 
            this.btnBackMain.Location = new System.Drawing.Point(210, 108);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(94, 23);
            this.btnBackMain.TabIndex = 16;
            this.btnBackMain.Text = "Retour";
            this.btnBackMain.UseVisualStyleBackColor = true;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Location = new System.Drawing.Point(1, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 264);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBackMain);
            this.panel2.Controls.Add(this.txtNFace);
            this.panel2.Controls.Add(this.NomDeTxt);
            this.panel2.Controls.Add(this.smtCreation);
            this.panel2.Controls.Add(this.lblTypeDe);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbTypeDe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 144);
            this.panel2.TabIndex = 18;
            // 
            // CreationDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(686, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreationDe";
            this.Text = "CreationDe";
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreFaces)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTypeDe;
        private System.Windows.Forms.Label lblTypeDe;
        private System.Windows.Forms.TextBox NomDeTxt;
        private System.Windows.Forms.TextBox txtNFace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button smtCreation;
        private System.Windows.Forms.ErrorProvider errorNombreFaces;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}