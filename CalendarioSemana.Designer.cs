
namespace App_Ropa___Intento_1
{
    partial class CalendarioSemana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioSemana));
            this.layoutPanelSemana = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.buttonCrearEvento = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSemanaSiguiente = new System.Windows.Forms.PictureBox();
            this.labelSemana = new System.Windows.Forms.Label();
            this.buttonSemanaAnterior = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCrearEvento)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSemanaSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSemanaAnterior)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPanelSemana
            // 
            this.layoutPanelSemana.Location = new System.Drawing.Point(126, 185);
            this.layoutPanelSemana.Margin = new System.Windows.Forms.Padding(4);
            this.layoutPanelSemana.Name = "layoutPanelSemana";
            this.layoutPanelSemana.Size = new System.Drawing.Size(1027, 359);
            this.layoutPanelSemana.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(13, 13);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(57, 62);
            this.buttonHome.TabIndex = 7;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonCrearEvento
            // 
            this.buttonCrearEvento.BackColor = System.Drawing.Color.Transparent;
            this.buttonCrearEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonCrearEvento.Image")));
            this.buttonCrearEvento.Location = new System.Drawing.Point(1140, 573);
            this.buttonCrearEvento.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrearEvento.Name = "buttonCrearEvento";
            this.buttonCrearEvento.Size = new System.Drawing.Size(195, 135);
            this.buttonCrearEvento.TabIndex = 8;
            this.buttonCrearEvento.TabStop = false;
            this.buttonCrearEvento.Click += new System.EventHandler(this.buttonCrearEvento_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSemanaSiguiente);
            this.panel1.Controls.Add(this.labelSemana);
            this.panel1.Controls.Add(this.buttonSemanaAnterior);
            this.panel1.Location = new System.Drawing.Point(410, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 48);
            this.panel1.TabIndex = 9;
            // 
            // buttonSemanaSiguiente
            // 
            this.buttonSemanaSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.buttonSemanaSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("buttonSemanaSiguiente.Image")));
            this.buttonSemanaSiguiente.Location = new System.Drawing.Point(426, 0);
            this.buttonSemanaSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSemanaSiguiente.Name = "buttonSemanaSiguiente";
            this.buttonSemanaSiguiente.Size = new System.Drawing.Size(56, 48);
            this.buttonSemanaSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSemanaSiguiente.TabIndex = 23;
            this.buttonSemanaSiguiente.TabStop = false;
            this.buttonSemanaSiguiente.Click += new System.EventHandler(this.buttonSemanaSiguiente_Click);
            // 
            // labelSemana
            // 
            this.labelSemana.AutoSize = true;
            this.labelSemana.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemana.Location = new System.Drawing.Point(63, 0);
            this.labelSemana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemana.MaximumSize = new System.Drawing.Size(333, 39);
            this.labelSemana.MinimumSize = new System.Drawing.Size(333, 39);
            this.labelSemana.Name = "labelSemana";
            this.labelSemana.Size = new System.Drawing.Size(333, 39);
            this.labelSemana.TabIndex = 0;
            this.labelSemana.Text = "Semana";
            this.labelSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSemana.Click += new System.EventHandler(this.labelSemana_Click);
            // 
            // buttonSemanaAnterior
            // 
            this.buttonSemanaAnterior.BackColor = System.Drawing.Color.Transparent;
            this.buttonSemanaAnterior.Image = ((System.Drawing.Image)(resources.GetObject("buttonSemanaAnterior.Image")));
            this.buttonSemanaAnterior.Location = new System.Drawing.Point(-1, 0);
            this.buttonSemanaAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSemanaAnterior.Name = "buttonSemanaAnterior";
            this.buttonSemanaAnterior.Size = new System.Drawing.Size(56, 48);
            this.buttonSemanaAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSemanaAnterior.TabIndex = 22;
            this.buttonSemanaAnterior.TabStop = false;
            this.buttonSemanaAnterior.Click += new System.EventHandler(this.buttonSemanaAnterior_Click);
            // 
            // CalendarioSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_Ropa___Intento_1.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCrearEvento);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.layoutPanelSemana);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalendarioSemana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendario";
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCrearEvento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSemanaSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSemanaAnterior)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanelSemana;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.PictureBox buttonCrearEvento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSemana;
        private System.Windows.Forms.PictureBox buttonSemanaAnterior;
        private System.Windows.Forms.PictureBox buttonSemanaSiguiente;
    }
}