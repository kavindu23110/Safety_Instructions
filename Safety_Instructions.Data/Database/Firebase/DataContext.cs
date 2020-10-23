using Firebase.Database;
using Firebase.Database.Offline;
using Safety_app.Data.Interfaces;
using Safety_Instructions.Data.Models;

namespace Safety_Instructions.Data.Database.Firebase
{
    public class DataContext
    {
        private static FirebaseClient firebase { get; set; }
        private static IDatabaseCommon<Instruction> Data_Instructions { get; set; }
        private static IDatabaseCommon<Symptoms> Data_Symptoms { get; set; }

        public DataContext(string dbPath)
        {
            var options = new FirebaseOptions();
           options.SyncPeriod = new System.TimeSpan(0, 0, 1, 0);
            options.OfflineDatabaseFactory= (t, s) => new Offlinedatabase.OfflineDatabase(t, s);


            firebase = new FirebaseClient(dbPath,options);
            SetDatabaseOnObjects();
        }
        private void SetDatabaseOnObjects()
        {
            Data_Instructions = new Data_Instructions(firebase);
            Data_Symptoms = new Data_Symptoms(firebase);

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
