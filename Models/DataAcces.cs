using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace AppMusic.Models
{
    public static class DataAcces
    {
        public static string DatabaseName = "sqliteSamle.db";
        
        public async static void InitializeDatabase()
        {
            await ApplicationData.Current.LocalCacheFolder.CreateFileAsync(DatabaseName, CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalCacheFolder.Path.DatabaseName);
            using (SQLiteConnection db = new SQLiteConnection($"Filename={dbpath}"))
            {
                db.Open();
                var tableComad = "CREATE TABLE IF NOT" +
                    "EXISTS studens (roolnumber INTEFER PRIMARY KEY, " +
                    "name NVARCHAR(250 NULL))";
                SqliteCommand createbale = new SqliteCommand(tableComad, db); 
                creaTebale.ExecuteReader();
            }    
        }
    }
            
}
