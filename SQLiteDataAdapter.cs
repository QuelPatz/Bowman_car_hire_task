using System;
using System.Data;

namespace CarsDatabase
{
    internal class SQLiteDataAdapter
    {
        private SQLiteCommand cmd;

        public SQLiteDataAdapter(SQLiteCommand cmd)
        {
            this.cmd = cmd;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}