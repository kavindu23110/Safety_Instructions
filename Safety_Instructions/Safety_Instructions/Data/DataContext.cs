using Safety_Instructions.Data.ModeldatabaseOperations;
using Safety_Instructions.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safety_Instructions.Data
{
 public    class DataContext
    {
        private static SQLiteAsyncConnection _database;
        public static DiseaseOperator DiseaseOperator { get; set; }
        public static InstructionOperator InstructionOperator { get; set; }
        public DataContext(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            SetDatabaseOnObjects();
        }
        private void SetDatabaseOnObjects()
        {
            DiseaseOperator = new DiseaseOperator(ref _database);
            InstructionOperator = new InstructionOperator(ref _database);

        }
        public DiseaseOperator GetDiseaseOperator()
        {
            return DiseaseOperator;
        }
        public InstructionOperator GetInstructionOperator()
        {
            return InstructionOperator;
        }
    }
}
