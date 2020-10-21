using Firebase.Database;
using Safety_Instructions.Data.Database;

namespace Safety_Instructions.Data
{
    public class DataContext
    {
        private static FirebaseClient firebase { get; set; }
        private static Data_Instructions Data_Instructions { get; set; }

        public DataContext(string dbPath)
        {
            firebase = new FirebaseClient(dbPath);
            SetDatabaseOnObjects();
        }
        private void SetDatabaseOnObjects()
        {
            Data_Instructions = new Data_Instructions(firebase);

        }
        public Data_Instructions GetData_Instructions()
        {
            return Data_Instructions;
        }

    }
}
