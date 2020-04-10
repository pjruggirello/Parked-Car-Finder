using System;
using SQLite;

namespace CarFinder.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
