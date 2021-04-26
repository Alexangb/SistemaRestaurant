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
    public partial class Configuracion_mesas : Form
    {
        int id_salon;
        string estado;
       public static string nombre_mesa;
       public static int id_mesa;
        public Configuracion_mesas()
        {
            InitializeComponent();
        }

        private void Configuracion_mesas_Load(object sender, EventArgs e)
        {
            panelbienvenidad.Dock = DockStyle.Fill;
            dibujarsalones();
        }
        private void dibujarMesas()
        {
            try
            {
                panelmesas.Controls.Clear();
                Conexion.ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("mostrar_mesas_por_salon", Conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_salon", id_salon);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Button b = new Button();
                    Panel panel = new Panel();
                    int alto = Convert.ToInt32(rdr["y"].ToString());
                    int ancho = Convert.ToInt32(rdr["x"].ToString());
                    int tamanio_letra = Convert.ToInt32(rdr["tamanio_letra"].ToString());

                    Point tamnio = new Point(ancho, alto);
                    panel.BackgroundImage = Properties.Resources.mesa_vacia;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    panel.Cursor = Cursors.Hand;
                    panel.Tag = rdr["id_mesa"].ToString();
                    panel.Size = new System.Drawing.Size(tamnio);

                    b.Text = rdr["num_mesa"].ToString();
                    b.Name = rdr["id_mesa"].ToString();

                    if (b.Text!="NULO")
                    {
                        b.Size = new System.Drawing.Size(tamnio);
                        b.BackColor = Color.FromArgb(5, 179, 90);
                        b.Font = new System.Drawing.Font("Microsoft Sans Serif", tamanio_letra);
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderSize = 0;
                        b.ForeColor = Color.White;
                        panelmesas.Controls.Add(b);
                    }
                    else
                    {
                        panelmesas.Controls.Add(panel);
                    }
                    b.Click += new EventHandler(mievento);
                    panel.Click += new EventHandler(mievento_panel_click);
                }
                Conexion.ConexionMaestra.cerrar();
            }
            catch (Exception ex)
            {
                Conexion.ConexionMaestra.cerrar();
                MessageBox.Show(ex.StackTrace);
            }
           
        }
        private void mievento(System.Object sender,EventArgs e)
        {
            nombre_mesa = ((Button)sender).Text;
            id_mesa =Convert.ToInt32( ((Button)sender).Name);
            Agregar_mesa frm = new Agregar_mesa();
            frm.FormClosed += new FormClosedEventHandler(frm_agregar_mesa_FormClosed);
            frm.ShowDialog();

        }
        private void mievento_panel_click(System.Object sender, EventArgs e)
        {
            id_mesa = Convert.ToInt32(((Panel)sender).Tag);
            Agregar_mesa frm = new Agregar_mesa();
            frm.FormClosed += new FormClosedEventHandler(frm_agregar_mesa_FormClosed);
            frm.ShowDialog();
        }
        private void frm_agregar_mesa_FormClosed(Object sender, FormClosedEventArgs e)
        {
            dibujarMesas();
        }
        private void dibujarsalones()
        {
            try
            {
                flowLayoutPanelsalones.Controls.Clear();
                Conexion.ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("mostrar_salon",Conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", txtbuscar.Text) ;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Button b = new Button();
                    Panel panelc1 = new Panel();
                    b.Text = rdr["num_salon"].ToString();
                    b.Name = rdr["id_salon"].ToString();
                    b.Dock = DockStyle.Fill;
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 255, 87);
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 41, 107);
                    b.TextAlign = ContentAlignment.MiddleLeft;
                    b.Tag = rdr["estado"].ToString();

                    panelc1.Size = new Size(290, 58);
                    panelc1.Name = rdr["id_salon"].ToString();
                    string estado;
                    estado = rdr["estado"].ToString();
                    if (estado == "ELIMINADO")
                    {
                        b.Text = rdr["salon"].ToString() + "Eliminado";
                        b.ForeColor = Color.FromArgb(218, 37, 23);
                    }
                    else
                    {
                        b.ForeColor = Color.Black;
                    }
                    panelc1.Controls.Add(b);
                    flowLayoutPanelsalones.Controls.Add(panelc1);
                    b.Click += new EventHandler(miEvento_salon_button);
                }
                Conexion.ConexionMaestra.cerrar();
            }
            catch (Exception ex)
            {
                Conexion.ConexionMaestra.cerrar();
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void miEvento_salon_button(System.Object sender,EventArgs e)
        {
            panelbienvenidad.Visible = false;
            panelbienvenidad.Dock = DockStyle.None;
            panelmesas.Visible = true;
            panelmesas.Dock = DockStyle.Fill;
            id_salon = Convert.ToInt32(((Button)sender).Name);
            estado = Convert.ToString(((Button)sender).Tag);
            dibujarMesas();
            foreach (Panel Panelc1 in flowLayoutPanelsalones.Controls )  
            {
                if(Panelc1 is Panel)
                {
                    foreach (Button butto in Panelc1.Controls )
                    {
                        if (butto is Button)
                        {
                            butto.BackColor = Color.Transparent;
                            break;
                        }
                    }
                }
            }

            string NOMBRE = Convert.ToString(((Button)sender).Name);
            foreach (Panel Panelc1 in flowLayoutPanelsalones.Controls)
            {
                if (Panelc1 is Panel)
                {
                    foreach (Button boton in Panelc1.Controls)
                    {
                        if (boton is Button)
                        {
                            if (boton.Name==NOMBRE)
                            {
                                boton.BackColor = Color.OrangeRed;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Modulos.Mesas_salones.Salones frm = new Modulos.Mesas_salones.Salones();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.ShowDialog();
        }
        public void frm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            dibujarsalones();
        }

        private void btnmasmesa_Click(object sender, EventArgs e)
        {
            aumentarTamañoMesa();
        }
        internal void aumentarTamañoMesa()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                Conexion.ConexionMaestra.abrir();
                cmd = new SqlCommand("aumentar_tamanio_mesa", Conexion.ConexionMaestra.conectar);
                cmd.ExecuteNonQuery();
                Conexion.ConexionMaestra.cerrar();
                dibujarMesas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        internal void disminuirTamañoMesa()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                Conexion.ConexionMaestra.abrir();
                cmd = new SqlCommand("disminuir_tamaño_mesa", Conexion.ConexionMaestra.conectar);
                cmd.ExecuteNonQuery();
                Conexion.ConexionMaestra.cerrar();
                dibujarMesas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnmenosmesa_Click(object sender, EventArgs e)
        {
            disminuirTamañoMesa();
        }

        private void btnmasletra_Click(object sender, EventArgs e)
        {
            aumentarTamañoLetra();
        }
        internal void aumentarTamañoLetra()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                Conexion.ConexionMaestra.abrir();
                cmd = new SqlCommand("aumentar_tamanio_letra", Conexion.ConexionMaestra.conectar);
                cmd.ExecuteNonQuery();
                Conexion.ConexionMaestra.cerrar();
                dibujarMesas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnmenosletra_Click(object sender, EventArgs e)
        {
            disminuirTamañoLetra();
        }
        internal void disminuirTamañoLetra()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                Conexion.ConexionMaestra.abrir();
                cmd = new SqlCommand("disminuir_tamanio_letra", Conexion.ConexionMaestra.conectar);
                cmd.ExecuteNonQuery();
                Conexion.ConexionMaestra.cerrar();
                dibujarMesas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
