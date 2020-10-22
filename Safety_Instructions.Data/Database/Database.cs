using Safety_app.Data.Interfaces;
using Safety_Instructions.Data.Interfaces;
using Safety_Instructions.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Safety_Instructions.Data.Database
{
    public class Database : IDatabase
    {
        private Firebase.DataContext Firebase;
        private Sqlite.DataContext sqlite;
        public Database(string DBpathSqlite,string Url_Firebase)
        {
            sqlite = new Sqlite.DataContext(DBpathSqlite);
            Firebase = new Firebase.DataContext(Url_Firebase);
        }

      

        public bool CheckInternetConnection()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                return true;
            }
            return false;
        }

        public IDatabaseCommon<Instruction> GetData_Instructions()
        {
            if (CheckInternetConnection())
            {
                return Firebase.GetData_Instructions();
              
            }
            return sqlite.GetData_Instructions();
        }

        public IDatabaseCommon<Symptoms> GetData_Symptoms()
        {
            if (CheckInternetConnection())
            {
                return Firebase.GetData_Symptoms();

            }
            return sqlite.GetData_Symptoms();
        }
    }
}
