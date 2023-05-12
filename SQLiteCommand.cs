using System;

namespace CarsDatabase
{
    internal class SQLiteCommand
    {
        private string getDB;
        private SQLiteConnection databaseConnection;

        public SQLiteCommand(SQLiteConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }

        public SQLiteCommand(string getDB, SQLiteConnection databaseConnection)
        {
            this.getDB = getDB;
            this.databaseConnection = databaseConnection;
        }

        public object CommandText { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}