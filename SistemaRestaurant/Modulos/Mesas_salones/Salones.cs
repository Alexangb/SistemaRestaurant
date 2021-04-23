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
    public partial class Salones : Form
    {
        public Salones()
        {
            InitializeComponent();
        }

        private void Salones_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            txtsalones.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarSalon();
        }
        private void MostrarIDsaloningresado()
        {

        }
        private void InsertarSalon()
        {
            try
            {
                Conexion.ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("insertar_salon", Conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salon", txtsalones.Text);
                cmd.ExecuteNonQuery();
                Conexion.ConexionMaestra.cerrar();
                Close();
            }
            catch (Exception ex)
            {
                Conexion.ConexionMaestra.conectar.Close();

                MessageBox.Show(ex.Message);
            }
        }
    }
}
