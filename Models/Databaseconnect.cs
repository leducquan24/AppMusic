using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace AppMusic.Models
{
    public class Databaseconnect
    {
        public static string DatabaseName = "studentManager.db";
        public async static void Database()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync(DatabaseName, CreationCollisionOption.OpenIfExists);
            String dppath = Path.Combine
        } 
    }
}
