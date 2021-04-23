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
        public int idSalon;
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

        private void insertarMesasVacias()
        {
            for (int i = 0; i <=80; i++)
            {
                try
                {
                    Conexion.ConexionMaestra.abrir();
                    SqlCommand cmd = new SqlCommand("insertar_mesa",Conexion.ConexionMaestra.conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mesa", "NULO");
                    cmd.Parameters.AddWithValue("@idsalon", idSalon);
                    cmd.ExecuteNonQuery();
                    Conexion.ConexionMaestra.cerrar();
                }
                catch (Exception ex)
                {
                    Conexion.ConexionMaestra.cerrar();
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }
        private void MostrarIDsaloningresado()
        {
            SqlCommand cmd = new SqlCommand("mostrar_id_salon_recien_ingresado", Conexion.ConexionMaestra.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@salon", txtsalones.Text);
            try
            {
                Conexion.ConexionMaestra.abrir();
                idSalon = Convert.ToInt32(cmd.ExecuteScalar());
                Conexion.ConexionMaestra.cerrar();
            }
            catch (Exception ex)
            {
                Conexion.ConexionMaestra.cerrar();
                MessageBox.Show(ex.StackTrace);
            }
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
                MostrarIDsaloningresado();
                insertarMesasVacias();
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
