

using Safety_app.Data.Interfaces;
using Safety_Instructions.Data.Models;
using SQLite;

namespace Safety_Instructions.Data.Database.Sqlite
{
    public class DataContext
    {
        private SQLiteAsyncConnection _database;
        private IDatabaseCommon<Instruction> Data_Instructions;
        private IDatabaseCommon<Symptoms> Data_Symptoms;
        public DataContext(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            SetDatabaseOnObjects();
        }


        private void SetDatabaseOnObjects()
        {
            Data_Instructions = new Data_Instructions(ref _database);
            Data_Symptoms = new Data_Symptoms(ref _database);
        }

        public IDatabaseCommon<Instruction> GetData_Instructions()
        {
            return Data_Instructions;
        }

        public IDatabaseCommon<Symptoms> GetData_Symptoms()
        {
            return Data_Symptoms;
        }

    }
}
