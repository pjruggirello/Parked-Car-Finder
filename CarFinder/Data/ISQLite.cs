using System;
using SQLite;

namespace CarFinder.Data
{
    public interface ISQLite
    {
        //Sets connection to SQLlite database
        SQLiteConnection GetConnection();
    }
}
