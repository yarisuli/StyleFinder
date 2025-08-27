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
    public partial class ElementoCalendario : UserControl
    {
        private int idEvento = -1;
        public ElementoCalendario(DateTime fechaEvento)
        {
            InitializeComponent();

            string diaSemana = "";
            switch (((int)fechaEvento.DayOfWeek))
            {
                case 0:
                    diaSemana = "Domingo";
                    break;
                case 1:
                    diaSemana = "Lunes";
                    break;
                case 2:
                    diaSemana = "Martes";
                    break;
                case 3:
                    diaSemana = "Miercoles";
                    break;
                case 4:
                    diaSemana = "Jueves";
                    break;
                case 5:
                    diaSemana = "Viernes";
                    break;
                case 6:
                    diaSemana = "Sabado";
                    break;
                default:
                    break;
            }

            this.labelDiaSemana.Text = diaSemana;
            this.labelFecha.Text = fechaEvento.ToString("dd/MM/yyyy");

            string sql = "SELECT evento_id, fecha, descripcion, imagen FROM evento " +
                    " INNER JOIN outfit ON outfit.outfit_id = evento.outfit_id " +
                     " WHERE fecha = @fecha_evento AND evento.user_id = @usuario";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
               new OleDbParameter("@fecha_evento", fechaEvento.Date),
               new OleDbParameter("@usuario", LogInfo.UserID),
            };

            DataTable dt = DB.GetDataTable(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                labelEvento.Show();
                pictureBoxOutfit.Show();
                buttonEliminar.Show();
                labelSinEvento.Hide();

                string base64Image = dt.Rows[0].Field<String>("imagen");
                string descripcion = dt.Rows[0].Field<String>("descripcion");
                idEvento = dt.Rows[0].Field<Int32>("evento_id");

                this.labelEvento.Text = descripcion;
                this.pictureBoxOutfit.Image = ImageUtils.Base64ToImage(base64Image);

            } else
            {
                labelEvento.Hide();
                pictureBoxOutfit.Hide();
                buttonEliminar.Hide();
                labelSinEvento.Show();
            }
            
        }

        private void pictureBoxOutfit_Click(object sender, EventArgs e)
        {

            using (Form popUpForm = new Form())
            {
                popUpForm.Text = "Visualizar";
                popUpForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                popUpForm.MaximizeBox = false;
                popUpForm.MinimizeBox = false;

                Image img = ((PictureBox)sender).Image;
                popUpForm.StartPosition = FormStartPosition.CenterParent;
                popUpForm.ClientSize = img.Size;

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = img;
                popUpForm.Controls.Add(pb);

                popUpForm.ShowDialog();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(idEvento != -1)
            {
                string sql = "DELETE FROM evento WHERE evento_id = @idEvento";

                OleDbParameter[] parameters = new OleDbParameter[]
                {
                    new OleDbParameter("@idEvento", idEvento)
                };

                DB.Delete(sql, parameters);

                labelEvento.Hide();
                pictureBoxOutfit.Hide();
                buttonEliminar.Hide();
                labelSinEvento.Show();
                idEvento = -1;

                MessageBox.Show("Se ha eliminado el evento correctamente.");

                //this.Parent.Refresh();
            }

        }

        private void ElementoCalendario_Load(object sender, EventArgs e)
        {

        }
    }
}
