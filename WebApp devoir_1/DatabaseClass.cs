using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace WebApp_devoir_1
{
    public class DatabaseClass
    {

        /// <summary>
        /// Methode to create database
        /// </summary>
        public static void CreateDatabase()
        {

            // create a new database connection:
            using (SQLiteConnection sqlite_conn = new SQLiteConnection(MyConnection()))
            {
                
                // open the connection:
                sqlite_conn.Open();

                // create a new SQL command:
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Personne (personne_id INTEGER PRIMARY KEY AUTOINCREMENT, nom varchar(30), prenom1 varchar(30), prenom2 varchar(30), age integer, " +
                    "telephone varchar(30), adresseRue varchar(30), ville varchar(30), pays varchar(30), nationalite varchar(30), datecree varchar(30), " +
                "Unique(personne_id, nom, prenom1, prenom2, age, telephone, adresseRue, ville, pays, nationalite, datecree))";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();


            }
        }
        /// <summary>
        /// Method to insert data into database
        /// </summary>
        /// <param name="personne"></param>
        public void InsertIntoDatabase(Personne personne)
        {
            using (SQLiteConnection sqlite_conn = new SQLiteConnection(MyConnection()))
            {
                // open the connection:
                sqlite_conn.Open();
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

                // Lets insert something into our new table:
                sqlite_cmd.CommandText = "INSERT OR IGNORE INTO Personne(nom, prenom1, prenom2, age, telephone, adresseRue, ville, pays, nationalite, datecree) VALUES(@nom, @prenom1, @prenom2, @age, @telephone, @adresseRue, @ville, @pays, @nationalite, @datecree)";


                sqlite_cmd.Parameters.AddWithValue("@nom", personne.Nom);
                sqlite_cmd.Parameters.AddWithValue("@prenom1", personne.Prenom1);
                sqlite_cmd.Parameters.AddWithValue("@prenom2", personne.Prenom2);
                sqlite_cmd.Parameters.AddWithValue("@age", personne.Age);
                sqlite_cmd.Parameters.AddWithValue("@telephone", personne.Telephone);
                sqlite_cmd.Parameters.AddWithValue("@adresseRue", personne.AdresseRue);
                sqlite_cmd.Parameters.AddWithValue("@ville", personne.Ville);
                sqlite_cmd.Parameters.AddWithValue("@pays", personne.Pays);
                sqlite_cmd.Parameters.AddWithValue("@nationalite", personne.Nationalite);
                sqlite_cmd.Parameters.AddWithValue("@datecree", personne.Datecree);

                sqlite_cmd.Prepare();

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }

        }


        /// <summary>
        /// Method to Select data from database to dataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectIntoDatabase()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection sqlite_conn = new SQLiteConnection(MyConnection()))
            {
                // open the connection:
                sqlite_conn.Open();
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

                string stm = "SELECT nom, prenom1 || ' ' || prenom2 AS Prenom, age, telephone FROM Personne";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(stm, sqlite_conn);
                dataAdapter.Fill(dataTable);

                return dataTable;

            }

        }

        /// <summary>
        /// Method to make the connection with the database
        /// </summary>
        /// <returns></returns>
        public static string MyConnection()
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string dbpath = System.IO.Path.Combine(strWorkPath, "personnes.db");

            string connectionString = $"Data Source={dbpath};Version=3;";

            return connectionString;
            
        } 
        


    }
}