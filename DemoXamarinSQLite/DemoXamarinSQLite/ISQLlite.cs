using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DemoXamarinSQLite
{
   public interface ISQLlite
    {
        SQLiteConnection GetConnection();
    }
}
