
namespace App_Ropa___Intento_1
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.buttonFecha = new System.Windows.Forms.PictureBox();
            this.buttonCrearEvento = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.listaEventos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCrearEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(119, 97);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Location = new System.Drawing.Point(128, 300);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(33, 13);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Incio:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Location = new System.Drawing.Point(128, 337);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(32, 13);
            this.lblFinal.TabIndex = 4;
            this.lblFinal.Text = "Final:";
            // 
            // buttonFecha
            // 
            this.buttonFecha.BackColor = System.Drawing.Color.Transparent;
            this.buttonFecha.Image = ((System.Drawing.Image)(resources.GetObject("buttonFecha.Image")));
            this.buttonFecha.Location = new System.Drawing.Point(267, 300);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(100, 50);
            this.buttonFecha.TabIndex = 8;
            this.buttonFecha.TabStop = false;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // buttonCrearEvento
            // 
            this.buttonCrearEvento.BackColor = System.Drawing.Color.Transparent;
            this.buttonCrearEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonCrearEvento.Image")));
            this.buttonCrearEvento.Location = new System.Drawing.Point(688, 368);
            this.buttonCrearEvento.Name = "buttonCrearEvento";
            this.buttonCrearEvento.Size = new System.Drawing.Size(100, 70);
            this.buttonCrearEvento.TabIndex = 7;
            this.buttonCrearEvento.TabStop = false;
            this.buttonCrearEvento.Click += new System.EventHandler(this.buttonCrearEvento_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Image = global::App_Ropa___Intento_1.Properties.Resources.Casita;
            this.buttonHome.Location = new System.Drawing.Point(12, 12);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(35, 30);
            this.buttonHome.TabIndex = 6;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // listaEventos
            // 
            this.listaEventos.Image = global::App_Ropa___Intento_1.Properties.Resources.EVENTOS_CUADRICULA__1_;
            this.listaEventos.Location = new System.Drawing.Point(425, 97);
            this.listaEventos.Name = "listaEventos";
            this.listaEventos.Size = new System.Drawing.Size(250, 224);
            this.listaEventos.TabIndex = 11;
            this.listaEventos.TabStop = false;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_Ropa___Intento_1.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaEventos);
            this.Controls.Add(this.buttonFecha);
            this.Controls.Add(this.buttonCrearEvento);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Calendario";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCrearEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.PictureBox buttonCrearEvento;
        private System.Windows.Forms.PictureBox buttonFecha;
        private System.Windows.Forms.PictureBox listaEventos;
    }
}