﻿
namespace App_Ropa___Intento_1
{
    partial class BibliotecaPrendas
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
            this.prendasLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBack = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // prendasLayoutPanel
            // 
            this.prendasLayoutPanel.AutoScroll = true;
            this.prendasLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.prendasLayoutPanel.Location = new System.Drawing.Point(74, 70);
            this.prendasLayoutPanel.Name = "prendasLayoutPanel";
            this.prendasLayoutPanel.Size = new System.Drawing.Size(634, 368);
            this.prendasLayoutPanel.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.Image = global::App_Ropa___Intento_1.Properties.Resources.Group_28__1_;
            this.buttonBack.Location = new System.Drawing.Point(706, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 42);
            this.buttonBack.TabIndex = 60;
            this.buttonBack.TabStop = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(16, 5);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(176, 52);
            this.labelTitulo.TabIndex = 64;
            this.labelTitulo.Text = "Prendas";
            // 
            // BibliotecaPrendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_Ropa___Intento_1.Properties.Resources.Captura_1__1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.prendasLayoutPanel);
            this.Name = "BibliotecaPrendas";
            this.Text = "Biblioteca Prendas";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel prendasLayoutPanel;
        private System.Windows.Forms.PictureBox buttonBack;
        private System.Windows.Forms.Label labelTitulo;
    }
}