
namespace CreerLancerDe
{
    partial class DeFormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreerDe = new System.Windows.Forms.Button();
            this.LancerDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreerDe
            // 
            this.CreerDe.Location = new System.Drawing.Point(283, 112);
            this.CreerDe.Name = "CreerDe";
            this.CreerDe.Size = new System.Drawing.Size(136, 38);
            this.CreerDe.TabIndex = 2;
            this.CreerDe.Text = "Créer un ou plusieurs dé";
            this.CreerDe.UseVisualStyleBackColor = true;
            this.CreerDe.Click += new System.EventHandler(this.button1_Click);
            // 
            // LancerDe
            // 
            this.LancerDe.Location = new System.Drawing.Point(283, 188);
            this.LancerDe.Name = "LancerDe";
            this.LancerDe.Size = new System.Drawing.Size(136, 38);
            this.LancerDe.TabIndex = 3;
            this.LancerDe.Text = "Lancer un ou plusieurs dé";
            this.LancerDe.UseVisualStyleBackColor = true;
            this.LancerDe.Click += new System.EventHandler(this.LancerDe_Click);
            // 
            // DeFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.LancerDe);
            this.Controls.Add(this.CreerDe);
            this.Name = "DeFormMain";
            this.Text = "Jeux de dé dynamic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreerDe;
        private System.Windows.Forms.Button LancerDe;
    }
}

