using Firebase.Database;
using Firebase.Database.Offline;
using Safety_app.Data.Interfaces;
using Safety_Instructions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.Database.Firebase
{
    public class Data_Instructions : IDatabaseCommon<Instruction>
    {


        public string EntityName { get; set; }

        private readonly RealtimeDatabase<Instruction> firebase;

        public Data_Instructions(FirebaseClient firebase)
        {
            EntityName = nameof(Instruction);
            this.firebase = firebase.Child(EntityName).AsRealtimeDatabase<Instruction>("", "", StreamingOptions.LatestOnly, InitialPullStrategy.MissingOnly, true);
            _ = syncdatabaseAsync();
        }

        private async Task syncdatabaseAsync()
        {
            await this.firebase.PullAsync();
        }


        public Instruction Findasync(Func<Instruction, bool> predicate)
        {
            return firebase.Once().Select(p => p.Object).ToList<Instruction>().Where(predicate).FirstOrDefault();
        }

        public List<Instruction> GetAsync()
        {

            return firebase.Once().Select(p => p.Object).ToList<Instruction>();
        }

        public void Insert(Instruction Entity)
        {

            firebase.Post<Instruction>(Entity);


        }


    }
}
