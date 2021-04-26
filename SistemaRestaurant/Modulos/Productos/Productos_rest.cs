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
using System.IO;

namespace SistemaRestaurant.Modulos.Productos
{
    public partial class Productos_rest : Form
    {
        public Productos_rest()
        {
            InitializeComponent();
        }
        public static int id_grupo;

        private void Productos_rest_Load(object sender, EventArgs e)
        {
            dibujarGrupos();
        }
        private void dibujarGrupos()
        {
            try
            {
                flowLayoutPanelproductos.Controls.Clear();
                Conexion.ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("select*from grupo_de_productos", Conexion.ConexionMaestra.conectar);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Label label = new Label();
                    Panel panel1 = new Panel();
                    Panel panel2 = new Panel();
                    PictureBox pic1 = new PictureBox();

                    label.Text = rdr["nom_grupo"].ToString();
                    label.Name = rdr["idline"].ToString();
                    label.Size = new System.Drawing.Size(119, 25);
                    label.Font = new System.Drawing.Font("Miscrosoft Sans Serif", 13);
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Cursor = Cursors.Hand;

                    panel1.Size =new Size(140, 133);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    panel1.Dock = DockStyle.Bottom;
                    panel1.BackColor = Color.FromArgb(43, 43, 43);
                    panel1.Name= rdr["idline"].ToString();

                    panel2.Size = new Size(140, 25);
                    panel2.Dock = DockStyle.Top;
                    panel2.BackColor = Color.Transparent;
                    panel2.BorderStyle = BorderStyle.None;

                    pic1.Size = new Size(140, 76);
                    pic1.Dock = DockStyle.Top;
                    pic1.BackgroundImage = null;
                    byte[] by = (Byte[])rdr["icono"];
                    MemoryStream ms = new MemoryStream(by);
                    pic1.Image = Image.FromStream(ms);
                    pic1.SizeMode = PictureBoxSizeMode.Zoom;
                    pic1.Cursor = Cursors.Hand;
                    pic1.Tag = rdr["idline"].ToString();

                    MenuStrip menuStrip = new MenuStrip();
                    menuStrip.BackColor = Color.Transparent;
                    menuStrip.AutoSize = false;
                    menuStrip.Size = new Size(28, 24);
                    menuStrip.Dock = DockStyle.Right;
                    menuStrip.Name = rdr["idline"].ToString();

                    ToolStripMenuItem toolStripMenuItemprincipal = new ToolStripMenuItem();
                    ToolStripMenuItem toolStripEditar = new ToolStripMenuItem();
                    ToolStripMenuItem toolStripEliminar = new ToolStripMenuItem();
                    ToolStripMenuItem toolStripRestaurar = new ToolStripMenuItem();

                    toolStripMenuItemprincipal.Image = Properties.Resources.menuCajas_claro;
                    toolStripMenuItemprincipal.BackColor = Color.Transparent;

                    toolStripEditar.Text = "Editar";
                    toolStripEditar.Name = rdr["nom_grupo"].ToString();
                    toolStripEditar.Tag = rdr["idline"].ToString();

                    toolStripEliminar.Text = "Eliminar";
                    toolStripEliminar.Tag = rdr["idline"].ToString();

                    toolStripRestaurar.Text = "Restaurar";
                    toolStripRestaurar.Tag = rdr["idline"].ToString();

                    menuStrip.Items.Add(toolStripMenuItemprincipal);
                    toolStripMenuItemprincipal.DropDownItems.Add(toolStripEditar);
                    toolStripMenuItemprincipal.DropDownItems.Add(toolStripEliminar);
                    toolStripMenuItemprincipal.DropDownItems.Add(toolStripRestaurar);

                    panel2.Controls.Add(menuStrip);
                    panel1.Controls.Add(label);
                    if (rdr["estado_icono"].ToString()!="VACIO")
                    {
                        panel1.Controls.Add(pic1);
                    }
                    else
                    {
                        panel1.Controls.Add(label);
                    }
                    panel1.Controls.Add(panel2);
                    label.BringToFront();
                    panel2.SendToBack();
                    flowLayoutPanelproductos.Controls.Add(panel1);

                    label.Click+= new EventHandler(miEventoLabel);
                    pic1.Click += new EventHandler(miEventoPictureBox);



                }
                Conexion.ConexionMaestra.cerrar();
            }
            catch (Exception ex)
            {
                Conexion.ConexionMaestra.cerrar();
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void miEventoLabel(System.Object sender,EventArgs e)
        {
            id_grupo = Convert.ToInt32(((Label)sender).Name);
            verProductosPorGrupo();
        }

        private void miEventoPictureBox(System.Object sender, EventArgs e)
        {
            id_grupo = Convert.ToInt32(((PictureBox)sender).Name);
            verProductosPorGrupo();
        }

        private void verProductosPorGrupo()
        {
            lblbienvenida.Visible = false;
            panelagregarproductos.Visible = true;
            panelagregarproductos.Dock = DockStyle.Fill;
            dibujarProductos();
        }

        private void dibujarProductos()
        {
            try
            {
                flowLayoutPanelproductos.Controls.Clear();
                Conexion.ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("mostrar_productos_por_grupo", Conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idgrupo", id_grupo);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Label label = new Label();
                    Panel panel1 = new Panel();
                    Panel panel2 = new Panel();
                    PictureBox pic1 = new PictureBox();

                    label.Text = rdr["descripcion"].ToString();
                    label.Name = rdr["id_producto"].ToString();
                    label.Size = new System.Drawing.Size(119, 25);
                    label.Font = new System.Drawing.Font("Miscrosoft Sans Serif", 13);
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Cursor = Cursors.Hand;

                    panel1.Size = new Size(140, 133);
                    panel1.BorderStyle = BorderStyle.FixedSingle;
                    panel1.Dock = DockStyle.Bottom;
                    panel1.BackColor = Color.FromArgb(43, 43, 43);
                    //panel1.Name = rdr["idline"].ToString();

                    panel2.Size = new Size(140, 25);
                    panel2.Dock = DockStyle.Top;
                    panel2.BackColor = Color.Transparent;
                    panel2.BorderStyle = BorderStyle.None;

                    pic1.Size = new Size(140, 76);
                    pic1.Dock = DockStyle.Top;
                    pic1.BackgroundImage = null;
                    byte[] by = (Byte[])rdr["imagen"];
                    MemoryStream ms = new MemoryStream(by);
                    pic1.Image = Image.FromStream(ms);
                    pic1.SizeMode = PictureBoxSizeMode.Zoom;
                    pic1.Cursor = Cursors.Hand;
                    pic1.Tag = rdr["id_producto"].ToString();

                    MenuStrip menuStrip = new MenuStrip();
                    menuStrip.BackColor = Color.Transparent;
                    menuStrip.AutoSize = false;
                    menuStrip.Size = new Size(28, 24);
                    menuStrip.Dock = DockStyle.Right;
                    menuStrip.Name = rdr["id_producto"].ToString();

                    ToolStripMenuItem toolStripMenuItemprincipal = new ToolStripMenuItem();
                    ToolStripMenuItem toolStripEditar = new ToolStripMenuItem();
                    ToolStripMenuItem toolStripEliminar = new ToolStripMenuItem();
                    ToolStripMenuItem toolStripRestaurar = new ToolStripMenuItem();

                    toolStripMenuItemprincipal.Image = Properties.Resources.menuCajas_claro;
                    toolStripMenuItemprincipal.BackColor = Color.Transparent;

                    toolStripEditar.Text = "Editar";
                    toolStripEditar.Name = rdr["Descripcion"].ToString();
                    toolStripEditar.Tag = rdr["id_producto"].ToString();

                    toolStripEliminar.Text = "Eliminar";
                    toolStripEliminar.Tag = rdr["id_producto"].ToString();

                    toolStripRestaurar.Text = "Restaurar";
                    toolStripRestaurar.Tag = rdr["id_producto"].ToString();

                    menuStrip.Items.Add(toolStripMenuItemprincipal);
                    toolStripMenuItemprincipal.DropDownItems.Add(toolStripEditar);
                    toolStripMenuItemprincipal.DropDownItems.Add(toolStripEliminar);
                    toolStripMenuItemprincipal.DropDownItems.Add(toolStripRestaurar);

                    panel2.Controls.Add(menuStrip);
                    panel1.Controls.Add(label);
                    if (rdr["estado_imagen"].ToString() != "VACIO")
                    {
                        panel1.Controls.Add(pic1);
                    }
                    else
                    {
                        panel1.Controls.Add(label);
                    }
                    panel1.Controls.Add(panel2);
                    label.BringToFront();
                    panel2.SendToBack();
                    panelagregarproductos.Controls.Add(panel1);
                }
                Conexion.ConexionMaestra.cerrar();
            }
            catch (Exception ex)
            {
                Conexion.ConexionMaestra.cerrar();
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnagregarsalon_Click(object sender, EventArgs e)
        {
            Modulos.Productos.GrupoDeProductos frm = new GrupoDeProductos();
            frm.FormClosed += new FormClosedEventHandler(frmGruposFormClosed);
            frm.ShowDialog();
        }

        public void frmGruposFormClosed(Object sender, FormClosedEventArgs e)
        {
            dibujarGrupos();
        }
    }
}
