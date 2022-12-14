using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Felhasznalo_keppel
{
    internal class Adatbazis
    {

        MySqlConnection sqlconnection;
        MySqlCommand sqlcommand;
        private string hibauzen = "";

        public Adatbazis(string host, string user, string password, string database)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = host;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = database;
            sqlconnection = new MySqlConnection(builder.ConnectionString);
            sqlcommand = sqlconnection.CreateCommand();

        }
        private bool DbOpen()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Open)
                {

                    sqlconnection.Open();

                }

            }
            catch (MySqlException ex)
            {

                hibauzen = ex.Message;
                return false;

            }

            return true;
        }
        private bool DbClose()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Closed)
                {

                    sqlconnection.Close();

                }

            }
            catch (MySqlException ex)
            {

                hibauzen = ex.Message;
                return false;

            }

            return true;

        }

        public List<FelhaszAdat> osszesFelhasz()
        {
            List<FelhaszAdat> felhasznaladatok = new List<FelhaszAdat>();
            sqlcommand.CommandText = "SELECT `id`, `nev`, `szuldat`, `profilkep` FROM `felhasznalo` WHERE 1";
            if (DbOpen())
            {

                using (MySqlDataReader dr = sqlcommand.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        FelhaszAdat ujadat = new FelhaszAdat(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDateTime("szuldat"), dr.GetString("profilkep"));
                        felhasznaladatok.Add(ujadat);

                    }

                }

            }
            else
            {

                MessageBox.Show(hibauzen);

            }
            DbClose();

            return felhasznaladatok;
        }

        public bool Hozzaadas(string nev, DateTime szuldata, string profilkep)
        {

            sqlcommand.CommandText = "INSERT INTO `felhasznalo`(`id`, `nev`, `szuldat`, `profilkep`) VALUES ('NULL','@felnev','@szuldat','@profilkep')";
            sqlcommand.Parameters.Clear();
            sqlcommand.Parameters.AddWithValue("@felnev", nev);
            sqlcommand.Parameters.AddWithValue("@szuldat", szuldata);
            sqlcommand.Parameters.AddWithValue("@profilkep", profilkep);
            DbOpen();
            try
            {

                if (sqlcommand.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Hozzáadás sikeres!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;

                }
                
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            DbClose();

            return true;
        }

        public bool Modosit(int id, string nev, DateTime szuldata, string profilkep)
        {

            sqlcommand.CommandText = "UPDATE `felhasznalo` SET `nev`=@nev',`szuldat`='@szuldata',`profilkep`='@profilkep' WHERE `id`='@id'";
            sqlcommand.Parameters.Clear();
            sqlcommand.Parameters.AddWithValue("@id", id);
            sqlcommand.Parameters.AddWithValue("@nev", nev);
            sqlcommand.Parameters.AddWithValue("@szuldata", szuldata);
            sqlcommand.Parameters.AddWithValue("@profilkep",profilkep);
            DbOpen();
            try
            {

                if (sqlcommand.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Módosítás sikeres!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            DbClose();

            return true;
        }

        public bool Torol(int id)
        {

            sqlcommand.CommandText = "DELETE FROM `felhasznalo` WHERE `id`='@id'";
            sqlcommand.Parameters.Clear();
            sqlcommand.Parameters.AddWithValue("@id", id);
            DbOpen();
            try
            {

                if (sqlcommand.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Törlés sikeres!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            DbClose();

            return true;
        }

    }
}
