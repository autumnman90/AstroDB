using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Collections.ObjectModel;

namespace Astro_DB
{
    


    public class Database
    {

        public static SQLiteConnection sqlConnection = new SQLiteConnection(ConString());

        public static string ConString()//Erzeugt den Connectionstring
        {
            string conString;
            
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
            builder.DataSource = @".\Datenbank\AstronomieDB.sqlite";
            builder.Version = 3;

            conString = builder.ToString();
            
            
            return conString;
        }

        public static void Opener()
        {
            sqlConnection.Open();
        }

        public static void Commander(string commando)
        {
            SQLiteCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = commando;


        }

        public static ObservableCollection<PlanetenInfoModel> PlanetenDaten { get; set; }

        public static void Loader()
        {
            PlanetenDaten = new ObservableCollection<PlanetenInfoModel>();

            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
            builder.DataSource = @".\Datenbank\AstronomieDB.sqlite";
            builder.Version = 3;

            using (SQLiteConnection sqlConnection = new SQLiteConnection(builder.ToString()))
            {
                sqlConnection.Open();

                SQLiteCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select planet_ID, planets.Name, Age, Aphelion, diameter, mass, rotation_Period, temperature, luminosity, gravity, Moons_Number, planetcomposition_Type.name from planets join planetcomposition_Type on(planets.Planetcompositiontype_ID = planetcomposition_Type.Planetcompositiontype_ID)";

                using (SQLiteDataReader sqlResponse = sqlCommand.ExecuteReader())
                {
                    while (sqlResponse.Read())
                    {
                        PlanetenInfoModel pim = new PlanetenInfoModel
                        {
                            Planet_ID = sqlResponse.GetInt32(0),
                            PlanetName = sqlResponse.GetString(1),
                            Alter = sqlResponse.GetString(2),
                            Aphelion = sqlResponse.GetString(3),
                            Diameter = sqlResponse.GetString(4),
                            Mass = sqlResponse.GetString(5),
                            Rotation_Period = sqlResponse.GetString(6),
                            Temperature = sqlResponse.GetString(7),
                            Luminosity = sqlResponse.GetString(8),
                            Gravity = sqlResponse.GetString(9),
                            Moons_Number = sqlResponse.GetString(10),
                            CompositionName = sqlResponse.GetString(11)

                            
                        };

                        PlanetenDaten.Add(pim);

                    }
                }
            }

        }
            
            
            
        

    }
}
