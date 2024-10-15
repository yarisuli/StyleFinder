
namespace App_Ropa___Intento_1
{
    partial class LogIn
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.txbcontraseña = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.PictureBox();
            this.buttonIniciar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(314, 371);
            this.txbusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(287, 22);
            this.txbusuario.TabIndex = 4;
            this.txbusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbcontraseña
            // 
            this.txbcontraseña.Location = new System.Drawing.Point(758, 371);
            this.txbcontraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txbcontraseña.Name = "txbcontraseña";
            this.txbcontraseña.Size = new System.Drawing.Size(287, 22);
            this.txbcontraseña.TabIndex = 5;
            this.txbcontraseña.TextChanged += new System.EventHandler(this.txbcontraseña_TextChanged);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.Transparent;
            this.buttonSignUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonSignUp.Image")));
            this.buttonSignUp.Location = new System.Drawing.Point(1134, 13);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(226, 70);
            this.buttonSignUp.TabIndex = 9;
            this.buttonSignUp.TabStop = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.Transparent;
            this.buttonIniciar.Image = ((System.Drawing.Image)(resources.GetObject("buttonIniciar.Image")));
            this.buttonIniciar.Location = new System.Drawing.Point(553, 451);
            this.buttonIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(198, 79);
            this.buttonIniciar.TabIndex = 8;
            this.buttonIniciar.TabStop = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(553, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 182);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::App_Ropa___Intento_1.Properties.Resources.Contraseña1;
            this.pictureBox4.Location = new System.Drawing.Point(758, 332);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 32);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::App_Ropa___Intento_1.Properties.Resources.Usuario;
            this.pictureBox5.Location = new System.Drawing.Point(314, 332);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(76, 32);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_Ropa___Intento_1.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbcontraseña);
            this.Controls.Add(this.txbusuario);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.TextBox txbcontraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttonIniciar;
        private System.Windows.Forms.PictureBox buttonSignUp;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

