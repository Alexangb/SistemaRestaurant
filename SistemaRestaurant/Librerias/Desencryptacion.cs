using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SistemaRestaurant.Librerias
{
    class Desencryptacion
    {
        static private Encryptacion aes = new Encryptacion();
        static public string cnString;
        static string dbcnString;

        static public string apppwdunique = "RESTAURANTE.codigo.GARCIA.RUBIO.BASE_";

        public static object checkServer()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            dbcnString = root.Attributes[0].Value;
            cnString = (aes.Decrypt(dbcnString, apppwdunique, int.Parse("256")));
            return cnString;

        }

        internal class label
        {

        }
        public static object UsuariosEncryp()
        {
            XmlDocument doc = new XmlDocument();
            label root = new label();

            dbcnString = root.ToString();
            cnString = (aes.Decrypt(dbcnString, apppwdunique, int.Parse("256")));
            return cnString;

        }
    }
}
