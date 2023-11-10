
namespace App_Ropa___Intento_1
{
    partial class Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca));
            this.buttonOutfits = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.buttonPrendas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOutfits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrendas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOutfits
            // 
            this.buttonOutfits.BackColor = System.Drawing.Color.Transparent;
            this.buttonOutfits.Image = ((System.Drawing.Image)(resources.GetObject("buttonOutfits.Image")));
            this.buttonOutfits.Location = new System.Drawing.Point(129, 245);
            this.buttonOutfits.Name = "buttonOutfits";
            this.buttonOutfits.Size = new System.Drawing.Size(541, 101);
            this.buttonOutfits.TabIndex = 1;
            this.buttonOutfits.TabStop = false;
            this.buttonOutfits.Click += new System.EventHandler(this.buttonOutfits_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.Image = global::App_Ropa___Intento_1.Properties.Resources.Casita;
            this.buttonHome.Location = new System.Drawing.Point(12, 12);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(35, 30);
            this.buttonHome.TabIndex = 63;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonPrendas
            // 
            this.buttonPrendas.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrendas.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrendas.Image")));
            this.buttonPrendas.Location = new System.Drawing.Point(129, 105);
            this.buttonPrendas.Name = "buttonPrendas";
            this.buttonPrendas.Size = new System.Drawing.Size(541, 101);
            this.buttonPrendas.TabIndex = 2;
            this.buttonPrendas.TabStop = false;
            this.buttonPrendas.Click += new System.EventHandler(this.buttonPrendas_Click);
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_Ropa___Intento_1.Properties.Resources.Captura_1__1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonPrendas);
            this.Controls.Add(this.buttonOutfits);
            this.Name = "Biblioteca";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Biblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonOutfits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonOutfits;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.PictureBox buttonPrendas;
    }
}