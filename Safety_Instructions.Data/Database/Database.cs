using Safety_app.Data.Interfaces;
using Safety_Instructions.Data.Interfaces;
using Safety_Instructions.Data.Models;

namespace Safety_Instructions.Data.Database
{
    public class Database : IDatabase
    {
        private Firebase.DataContext Firebase;

        public Database(string Url_Firebase)
        {
            Firebase = new Firebase.DataContext(Url_Firebase);
        }

        public IDatabaseCommon<Instruction> GetData_Instructions()
        {
            return Firebase.GetData_Instructions();
        }

        public IDatabaseCommon<Symptoms> GetData_Symptoms()
        {
            return Firebase.GetData_Symptoms();
        }
    }
}
