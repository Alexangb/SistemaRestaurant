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

namespace SistemaRestaurant.Modulos.Productos
{
    public partial class GrupoDeProductos : Form
    {
        public GrupoDeProductos()
        {
            InitializeComponent();
        }
        string estado_imagen;

        private void GrupoDeProductos_Load(object sender, EventArgs e)
        {
            estado_imagen = "VACIO";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            insertarGrupoDeProductos();
            Dispose();
        }

        private void insertarGrupoDeProductos()
        {
            try
            {
                Conexion.ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("insertar_grupo_de_productos", Conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom_grupo", txtgrupo.Text);
                cmd.Parameters.AddWithValue("@por_defecto", "NO");
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBoximagengrupo.Image.Save(ms, pictureBoximagengrupo.Image.RawFormat);
                cmd.Parameters.AddWithValue("@icono", ms.GetBuffer());
                cmd.Parameters.AddWithValue("@estado", "ACTIVO");
                cmd.Parameters.AddWithValue("@estado_de_icono", estado_imagen);
               

                cmd.ExecuteNonQuery();
                Conexion.ConexionMaestra.cerrar();
            }
            catch (Exception ex)
            {
                Conexion.ConexionMaestra.cerrar();
                MessageBox.Show(ex.Message);
            }
        }
        private void agregarImagen()
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                pictureBoximagengrupo.BackgroundImage = null;
                pictureBoximagengrupo.Image = new Bitmap(dlg.FileName);

                panelagregaricono.Visible = false;
                estado_imagen = "LLENO";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            agregarImagen();
        }

        private void pictureBoxclikicono_Click(object sender, EventArgs e)
        {
            agregarImagen();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
