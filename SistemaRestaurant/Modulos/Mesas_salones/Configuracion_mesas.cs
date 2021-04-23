﻿using System;
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
        public Configuracion_mesas()
        {
            InitializeComponent();
        }

        private void Configuracion_mesas_Load(object sender, EventArgs e)
        {
            panelbienvenidad.Dock = DockStyle.Fill;
            dibujarsalones();
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


    }
}
