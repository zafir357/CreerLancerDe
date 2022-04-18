
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
            this.TabCreationDe = new System.Windows.Forms.TabControl();
            this.CreationDeNormal = new System.Windows.Forms.TabPage();
            this.CreationDePersonaliser = new System.Windows.Forms.TabPage();
            this.txtNFace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomDeTxt = new System.Windows.Forms.TextBox();
            this.smtCreationDe = new System.Windows.Forms.Button();
            this.erreurNFaceNormal = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabCreationDe.SuspendLayout();
            this.CreationDeNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurNFaceNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCreationDe
            // 
            this.TabCreationDe.Controls.Add(this.CreationDeNormal);
            this.TabCreationDe.Controls.Add(this.CreationDePersonaliser);
            this.TabCreationDe.Location = new System.Drawing.Point(12, 3);
            this.TabCreationDe.Name = "TabCreationDe";
            this.TabCreationDe.SelectedIndex = 0;
            this.TabCreationDe.Size = new System.Drawing.Size(793, 444);
            this.TabCreationDe.TabIndex = 0;
            // 
            // CreationDeNormal
            // 
            this.CreationDeNormal.BackColor = System.Drawing.Color.LightGreen;
            this.CreationDeNormal.Controls.Add(this.smtCreationDe);
            this.CreationDeNormal.Controls.Add(this.NomDeTxt);
            this.CreationDeNormal.Controls.Add(this.label2);
            this.CreationDeNormal.Controls.Add(this.label1);
            this.CreationDeNormal.Controls.Add(this.txtNFace);
            this.CreationDeNormal.Location = new System.Drawing.Point(4, 24);
            this.CreationDeNormal.Name = "CreationDeNormal";
            this.CreationDeNormal.Padding = new System.Windows.Forms.Padding(3);
            this.CreationDeNormal.Size = new System.Drawing.Size(785, 416);
            this.CreationDeNormal.TabIndex = 0;
            this.CreationDeNormal.Text = "Dé Normal";
            // 
            // CreationDePersonaliser
            // 
            this.CreationDePersonaliser.Location = new System.Drawing.Point(4, 24);
            this.CreationDePersonaliser.Name = "CreationDePersonaliser";
            this.CreationDePersonaliser.Padding = new System.Windows.Forms.Padding(3);
            this.CreationDePersonaliser.Size = new System.Drawing.Size(785, 416);
            this.CreationDePersonaliser.TabIndex = 1;
            this.CreationDePersonaliser.Text = "Dé Personaliser";
            this.CreationDePersonaliser.UseVisualStyleBackColor = true;
            // 
            // txtNFace
            // 
            this.txtNFace.Location = new System.Drawing.Point(127, 37);
            this.txtNFace.Name = "txtNFace";
            this.txtNFace.Size = new System.Drawing.Size(75, 23);
            this.txtNFace.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de faces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom du dé";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomDeTxt
            // 
            this.NomDeTxt.Location = new System.Drawing.Point(127, 80);
            this.NomDeTxt.Name = "NomDeTxt";
            this.NomDeTxt.Size = new System.Drawing.Size(75, 23);
            this.NomDeTxt.TabIndex = 3;
            // 
            // smtCreationDe
            // 
            this.smtCreationDe.Location = new System.Drawing.Point(127, 128);
            this.smtCreationDe.Name = "smtCreationDe";
            this.smtCreationDe.Size = new System.Drawing.Size(75, 23);
            this.smtCreationDe.TabIndex = 4;
            this.smtCreationDe.Text = "Submit";
            this.smtCreationDe.UseVisualStyleBackColor = true;
            this.smtCreationDe.Click += new System.EventHandler(this.smtCreationDe_Click);
            // 
            // erreurNFaceNormal
            // 
            this.erreurNFaceNormal.ContainerControl = this;
            // 
            // CreationDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabCreationDe);
            this.Name = "CreationDe";
            this.Text = "CreationDe";
            this.TabCreationDe.ResumeLayout(false);
            this.CreationDeNormal.ResumeLayout(false);
            this.CreationDeNormal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurNFaceNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCreationDe;
        private System.Windows.Forms.TabPage CreationDeNormal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNFace;
        private System.Windows.Forms.TabPage CreationDePersonaliser;
        private System.Windows.Forms.Button smtCreationDe;
        private System.Windows.Forms.TextBox NomDeTxt;
        private System.Windows.Forms.ErrorProvider erreurNFaceNormal;
    }
}