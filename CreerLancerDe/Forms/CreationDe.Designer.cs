﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreFaces)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTypeDe
            // 
            this.cmbTypeDe.FormattingEnabled = true;
            this.cmbTypeDe.Location = new System.Drawing.Point(105, 112);
            this.cmbTypeDe.Name = "cmbTypeDe";
            this.cmbTypeDe.Size = new System.Drawing.Size(81, 21);
            this.cmbTypeDe.TabIndex = 14;
            this.cmbTypeDe.SelectedIndexChanged += new System.EventHandler(this.cmbTypeDe_SelectedIndexChanged_1);
            // 
            // lblTypeDe
            // 
            this.lblTypeDe.AutoSize = true;
            this.lblTypeDe.Location = new System.Drawing.Point(17, 115);
            this.lblTypeDe.Name = "lblTypeDe";
            this.lblTypeDe.Size = new System.Drawing.Size(46, 13);
            this.lblTypeDe.TabIndex = 13;
            this.lblTypeDe.Text = "Type de";
            // 
            // NomDeTxt
            // 
            this.NomDeTxt.Location = new System.Drawing.Point(105, 75);
            this.NomDeTxt.Name = "NomDeTxt";
            this.NomDeTxt.Size = new System.Drawing.Size(81, 20);
            this.NomDeTxt.TabIndex = 11;
            // 
            // txtNFace
            // 
            this.txtNFace.Location = new System.Drawing.Point(105, 38);
            this.txtNFace.Name = "txtNFace";
            this.txtNFace.Size = new System.Drawing.Size(81, 20);
            this.txtNFace.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom du dé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de faces";
            // 
            // smtCreation
            // 
            this.smtCreation.Location = new System.Drawing.Point(105, 170);
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
            // CreationDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.smtCreation);
            this.Controls.Add(this.cmbTypeDe);
            this.Controls.Add(this.lblTypeDe);
            this.Controls.Add(this.NomDeTxt);
            this.Controls.Add(this.txtNFace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreationDe";
            this.Text = "CreationDe";
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreFaces)).EndInit();
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
    }
}