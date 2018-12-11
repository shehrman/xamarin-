using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoXamarinSQLite.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Driod))]
namespace DemoXamarinSQLite.Droid
{
    class SQLite_Driod : ISQLlite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "myDatabase.sqlite";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbPath,dbName );
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}