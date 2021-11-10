using AppMusic.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace AppMusic.Models
{
    class StudentModels
    {
        public bool save (Student student) {
            string db.Path =
                Path.Combine(ApplicationData.Current.LocalFolder.Path, DataAcces.DatabaseName);
            using (SQLiteConnection db = new SqlConnection )
            {}
        }
    }
}
