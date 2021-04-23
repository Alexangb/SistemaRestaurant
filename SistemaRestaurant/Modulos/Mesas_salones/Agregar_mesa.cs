using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
 
namespace SistemaRestaurant.Modulos.Mesas_salones
{
    public partial class Agregar_mesa : Form
    {
        public Agregar_mesa()
        {
            InitializeComponent();
        }

        private void Agregar_mesa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            txtmesaedicion.Text = Configuracion_mesas.nombre_mesa;
        }

        private void btnguardarmesa_Click(object sender, EventArgs e)
        {
            if (txtmesaedicion.Text !="")
            {
                editarMesa();
            }
            
        }

        private void editarMesa()
        {
            try
            {
                Conexion.ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("editar_mesa", Conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mesa", txtmesaedicion.Text);
                cmd.Parameters.AddWithValue("@id_mesa", Configuracion_mesas.id_mesa);
                cmd.ExecuteNonQuery();
                Conexion.ConexionMaestra.cerrar();
                Close();
            }
            catch (Exception ex)
            {
                Conexion.ConexionMaestra.cerrar();
                MessageBox.Show(ex.Message);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
