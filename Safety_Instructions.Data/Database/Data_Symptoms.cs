using Firebase.Database;
using Firebase.Database.Query;
using Safety_Instructions.Data.Interfaces;
using Safety_Instructions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.Database
{
    class Data_Symptoms : IDatabase<Symptoms>
    {
        public FirebaseClient firebase { get ; set ; }
        public string EntityName { get; set; }

        public Data_Symptoms(FirebaseClient firebase)
        {
            this.firebase = firebase;
            EntityName = nameof(Instruction);
        }

        public Task Delete(Symptoms Entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Symptoms> Findasync(Func<Symptoms, bool> predicate)
        {
            var all = 
            await firebase
              .Child(EntityName)
              .OnceAsync<Symptoms>();
            return all.Where(predicate).FirstOrDefault();
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
           Title=item.Object.Title,

       }).ToList();
        }

        public async Task Insert(Symptoms Entity)
        {
            await firebase
      .Child(EntityName)
      .PostAsync(Entity, true);
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
    }
}
