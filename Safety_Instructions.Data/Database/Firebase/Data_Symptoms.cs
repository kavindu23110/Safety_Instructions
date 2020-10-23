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
    public class Data_Symptoms : IDatabaseCommon<Symptoms>
    {

        public string EntityName { get; set; }

        private RealtimeDatabase<Symptoms> firebase;

        public Data_Symptoms(FirebaseClient firebase)
        {

            EntityName = nameof(Symptoms);
            this.firebase = firebase.Child(EntityName).AsRealtimeDatabase<Symptoms>("", "", StreamingOptions.LatestOnly, InitialPullStrategy.MissingOnly, true);
            _ = syncdatabaseAsync();
        }

        private async Task syncdatabaseAsync()
        {
            await this.firebase.PullAsync();
        }


        public List<Symptoms> GetAsync()
        {
            return firebase.Once().Select(p => p.Object).ToList<Symptoms>();
        }

        public void Insert(Symptoms Entity)
        {
            try
            {
                firebase.Post<Symptoms>(Entity);
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        public Symptoms Findasync(Func<Symptoms, bool> predicate)
        {
            return firebase.Once().Select(p => p.Object).ToList<Symptoms>().Where(predicate).FirstOrDefault();
        }

    }

}
