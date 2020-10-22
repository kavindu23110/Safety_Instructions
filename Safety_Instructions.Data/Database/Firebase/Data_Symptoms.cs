using Firebase.Database;
using Firebase.Database.Query;
using Safety_app.Data.Interfaces;
using Safety_Instructions.Data.Interfaces;
using Safety_Instructions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.Database.Firebase
{
    public class Data_Symptoms : IDatabaseCommon<Symptoms>
    {
        public FirebaseClient firebase { get; set; }
        public string EntityName { get; set; }

        public Data_Symptoms(FirebaseClient firebase)
        {
            this.firebase = firebase;
            EntityName = nameof(Symptoms);
        }

        public Task Delete(Symptoms Entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Symptoms>> GetAsync()
        {
            return (await firebase
       .Child(EntityName)
       .OnceAsync<Symptoms>()).Select(item => new Symptoms
       {
           Description = item.Object.Description,
           AnimationJson = item.Object.AnimationJson,
           Id = item.Object.Id,
           Title = item.Object.Title,

       }).ToList();
        }

        public async Task Insert(Symptoms Entity)
        {
            try
            {
                await firebase.Child(EntityName).PostAsync(Entity, true);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task Update(Symptoms Entity)
        {
            var toUpdate = (await firebase
       .Child(EntityName)
       .OnceAsync<Symptoms>()).Where(a => a.Object.Id == Entity.Id).FirstOrDefault();

            await firebase
              .Child(EntityName)
              .Child(toUpdate.Key)
              .PutAsync(Entity);
        }

        public Task<Symptoms> Findasync(Func<Symptoms, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
