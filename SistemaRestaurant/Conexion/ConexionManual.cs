using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace SistemaRestaurant.Conexion
{
    public partial class ConexionManual : Form
    {
        private Librerias.Encryptacion aes = new Librerias.Encryptacion();
        int idtabla;
        public ConexionManual()
        {
            InitializeComponent();
        }
        public void SaveToXml(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.XML");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.XML", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

        string dbcnString;

        public void ReadFromXml()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.XML");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txtcadena.Text = (aes.Decrypt(dbcnString, Librerias.Desencryptacion.apppwdunique, int.Parse("256")));
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {


            }
        }

        private void ConexionManual_Load(object sender, EventArgs e)
        {
            ReadFromXml();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comprobar_conexion();
        }
        private void Comprobar_conexion()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                //String cadena ="Data Source=LAPTOP-487D7ONF\\SQLEXPRESS;Initial Catalog=BDrestaurant;Integrated security=true";
                con.ConnectionString =txtcadena.Text;
                SqlCommand cmd = new SqlCommand("select*from salones",con);
                con.Open();               
                idtabla = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                SaveToXml(aes.Encrypt(txtcadena.Text, Librerias.Desencryptacion.apppwdunique, int.Parse("256")));
                MessageBox.Show("Conexion realizada correctamente", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Sin conexion", "Conexion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show(ex.Message);
            }
        }
    }
}
