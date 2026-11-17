using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyBestiarium
{
    internal class SzornyAdatbazis
    {
        private string connectionString;

        public SzornyAdatbazis(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Szorny> Fetolt()
        {
            List<Szorny> szornyek = new List<Szorny>();
            try
            {
                var myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = myConnection;
                comm.CommandText = "SELECT * FROM szornyek";

                using var myReader = comm.ExecuteReader();
                {
                    while (myReader.Read())
                    {
                        int id = myReader.GetInt32("Id");
                        string nev = myReader.GetString("Nev");
                        int veszelyessegiSzint = myReader.GetInt32("VeszelyessegiSzint");
                        string elohely = myReader.GetString("Elohely");
                        string foGyengeseg = myReader.GetString("FoGyengeseg");
                        string legGyakoribbZsakmany = myReader.GetString("legGyakoribbZsakmany");
                        bool veszelyesE = myReader.GetBoolean("VeszelyesE");
                        szornyek.Add(new Szorny(id, nev, veszelyessegiSzint, elohely,
                            foGyengeseg, legGyakoribbZsakmany, veszelyesE));
                    }    
                }
                myConnection.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return szornyek;
        }
    }
}
