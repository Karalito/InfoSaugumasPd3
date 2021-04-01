using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoSaugumasPD3
{
    class DataBase
    {
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Informacijos Saugumas\\InfoSaugumasPD3\\InfoSaugumasPD3\\RSA.mdf;Integrated Security = True";
            // "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RSA.mdf;Integrated Security = True";

        public void InsertValues(string text, BigInteger e, BigInteger n)
        {
            string query = "INSERT INTO CryptedData (CipherText, E, N) VALUES (@text, @e, @n)";
            try
            {
                Console.WriteLine("TEXT - > {0}, E - > {1}, N - > {2}", text, e, n);
                SqlConnection sqlCon = new SqlConnection(conn);
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand(query, sqlCon);
                sqlCom.Parameters.AddWithValue("@text", text);
                sqlCom.Parameters.AddWithValue("@e", e.ToString());
                sqlCom.Parameters.AddWithValue("@n", n.ToString());

                sqlCom.ExecuteNonQuery();
                MessageBox.Show("Crypted Data successfuly inserted into database !");
                sqlCon.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception in dataBase: {0}", ex);
            }
        }
    }
}
