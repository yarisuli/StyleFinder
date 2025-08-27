
namespace App_Ropa___Intento_1
{
    partial class ElementoCalendario
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
            this.labelDiaSemana = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelEvento = new System.Windows.Forms.Label();
            this.pictureBoxOutfit = new System.Windows.Forms.PictureBox();
            this.labelSinEvento = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDiaSemana
            // 
            this.labelDiaSemana.AutoSize = true;
            this.labelDiaSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDiaSemana.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaSemana.Location = new System.Drawing.Point(15, 6);
            this.labelDiaSemana.MinimumSize = new System.Drawing.Size(100, 25);
            this.labelDiaSemana.Name = "labelDiaSemana";
            this.labelDiaSemana.Size = new System.Drawing.Size(100, 27);
            this.labelDiaSemana.TabIndex = 0;
            this.labelDiaSemana.Text = "Dia";
            this.labelDiaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFecha.Font = new System.Drawing.Font("Yu Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(16, 38);
            this.labelFecha.MinimumSize = new System.Drawing.Size(100, 25);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(100, 25);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEvento
            // 
            this.labelEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEvento.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvento.Location = new System.Drawing.Point(3, 74);
            this.labelEvento.MinimumSize = new System.Drawing.Size(100, 50);
            this.labelEvento.Name = "labelEvento";
            this.labelEvento.Size = new System.Drawing.Size(126, 50);
            this.labelEvento.TabIndex = 2;
            this.labelEvento.Text = "Evento";
            // 
            // pictureBoxOutfit
            // 
            this.pictureBoxOutfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutfit.Location = new System.Drawing.Point(3, 131);
            this.pictureBoxOutfit.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxOutfit.Name = "pictureBoxOutfit";
            this.pictureBoxOutfit.Size = new System.Drawing.Size(127, 132);
            this.pictureBoxOutfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOutfit.TabIndex = 3;
            this.pictureBoxOutfit.TabStop = false;
            this.pictureBoxOutfit.Click += new System.EventHandler(this.pictureBoxOutfit_Click);
            // 
            // labelSinEvento
            // 
            this.labelSinEvento.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinEvento.Location = new System.Drawing.Point(2, 74);
            this.labelSinEvento.MinimumSize = new System.Drawing.Size(100, 169);
            this.labelSinEvento.Name = "labelSinEvento";
            this.labelSinEvento.Size = new System.Drawing.Size(100, 202);
            this.labelSinEvento.TabIndex = 4;
            this.labelSinEvento.Text = "Sin evento";
            this.labelSinEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSinEvento.Visible = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::App_Ropa___Intento_1.Properties.Resources.Icono_Borrar;
            this.buttonEliminar.Location = new System.Drawing.Point(50, 270);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(30, 30);
            this.buttonEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.TabStop = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // ElementoCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelEvento);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelDiaSemana);
            this.Controls.Add(this.pictureBoxOutfit);
            this.Controls.Add(this.labelSinEvento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ElementoCalendario";
            this.Size = new System.Drawing.Size(132, 309);
            this.Load += new System.EventHandler(this.ElementoCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDiaSemana;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelEvento;
        private System.Windows.Forms.PictureBox pictureBoxOutfit;
        private System.Windows.Forms.Label labelSinEvento;
        private System.Windows.Forms.PictureBox buttonEliminar;
    }
}
