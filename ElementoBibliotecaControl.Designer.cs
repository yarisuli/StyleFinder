
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    partial class ElementoBiblioteca
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFavorito = new System.Windows.Forms.PictureBox();
            this.buttonEliminar = new System.Windows.Forms.PictureBox();
            this.elementImage = new System.Windows.Forms.PictureBox();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFavorito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFavorito
            // 
            this.buttonFavorito.Image = global::App_Ropa___Intento_1.Properties.Resources.Icono_Favorito;
            this.buttonFavorito.Location = new System.Drawing.Point(13, 153);
            this.buttonFavorito.Name = "buttonFavorito";
            this.buttonFavorito.Size = new System.Drawing.Size(30, 30);
            this.buttonFavorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonFavorito.TabIndex = 2;
            this.buttonFavorito.TabStop = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::App_Ropa___Intento_1.Properties.Resources.Icono_Borrar;
            this.buttonEliminar.Location = new System.Drawing.Point(103, 153);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(30, 30);
            this.buttonEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.TabStop = false;
            // 
            // elementImage
            // 
            this.elementImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elementImage.Location = new System.Drawing.Point(13, 13);
            this.elementImage.Name = "elementImage";
            this.elementImage.Size = new System.Drawing.Size(120, 134);
            this.elementImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elementImage.TabIndex = 0;
            this.elementImage.TabStop = false;
            this.elementImage.Click += new System.EventHandler(this.elementImage_Click_1);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSeleccionar.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionar.Location = new System.Drawing.Point(13, 160);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(120, 23);
            this.buttonSeleccionar.TabIndex = 3;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = false;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // ElementoBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.buttonFavorito);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.elementImage);
            this.Name = "ElementoBiblioteca";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(148, 196);
            ((System.ComponentModel.ISupportInitialize)(this.buttonFavorito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox elementImage;
        private System.Windows.Forms.PictureBox buttonEliminar;
        private System.Windows.Forms.PictureBox buttonFavorito;
        private Button buttonSeleccionar;

        public PictureBox ElementImage { get => elementImage; set => elementImage = value; }
        public PictureBox ButtonFavorito { get => buttonFavorito; set => buttonFavorito = value; }
        public PictureBox ButtonEliminar { get => buttonEliminar; set => buttonEliminar = value; }
    }
}
