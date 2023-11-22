using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ropa___Intento_1
{
    public partial class CrearEvento : Form
    {
        private DateTime fechaEvento = DateTime.Now.Date;
        private string descripcionEvento = string.Empty;

        public CrearEvento()
        {
            InitializeComponent();

            flowLayoutPanel.HorizontalScroll.Visible = true;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.AutoSize = false;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.AutoScroll = true;

            string sql = "SELECT outfit_id, imagen FROM outfit WHERE user_id = @usuario";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
              new OleDbParameter("@usuario", LogInfo.UserID),
            };

            DataTable dt = DB.GetDataTable(sql, parameters);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string base64Image = dt.Rows[i].Field<String>("imagen");
                int outfitId = dt.Rows[i].Field<Int32>("outfit_id");

                ElementoBiblioteca elemento = new ElementoBiblioteca(outfitId);
                elemento.ElementImage.Image = ImageUtils.Base64ToImage(base64Image);
                flowLayoutPanel.Controls.Add(elemento);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(descripcionEvento))
            {
                MessageBox.Show("Debe ingresar una descripcion para el evento.");
            }
            else {
                string sql = "SELECT FROM evento WHERE fecha = @fecha AND user_id = @userId";
                
                OleDbParameter[] parameters = new OleDbParameter[]
                       {
                        new OleDbParameter("@fecha", fechaEvento),
                        new OleDbParameter("@userId", LogInfo.UserID),
                       };
                
               DataTable dt = DB.GetDataTable(sql, parameters);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un evento para esta fecha.");
                }
                else
                {
                    ElementoBiblioteca elementoSeleccionado = flowLayoutPanel.Controls.Cast<ElementoBiblioteca>().FirstOrDefault(el => el.EstaSeleccionado);
                    int selectedOutFit = elementoSeleccionado.IdElemento;
                    
                    if (elementoSeleccionado != null)
                    {

                       sql = "INSERT INTO evento (fecha, descripcion, outfit_id, user_id) VALUES (@fecha, @descripcion, @outfitId, @userId)";

                       parameters = new OleDbParameter[]
                        {
                        new OleDbParameter("@fecha", fechaEvento),
                        new OleDbParameter("@descripcion", descripcionEvento),
                        new OleDbParameter("@outfitId", selectedOutFit),
                        new OleDbParameter("@userId", LogInfo.UserID),
                        };

                        DB.Insert(sql, parameters);

                        this.Hide();
                        var calendario = new CalendarioSemana(fechaEvento);
                        calendario.Show();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un Outfit para el evento.");
                    }
                }
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var calendario = new CalendarioSemana();
            calendario.Show();
        }

        private void txtBoxEvento_TextChanged(object sender, EventArgs e)
        {
            descripcionEvento = txtBoxEvento.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaEvento = SeleccionFecha.Value.Date;

        }
    }
}
