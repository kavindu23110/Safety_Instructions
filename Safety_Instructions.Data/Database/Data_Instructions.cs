using Firebase.Database;
using Firebase.Database.Query;
using Safety_Instructions.Data.Interfaces;
using Safety_Instructions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.Database
{
    public class Data_Instructions : IDatabase<Instruction>
    {
        public FirebaseClient firebase { get; set; }
        public string EntityName { get; set; }

        public Data_Instructions(FirebaseClient firebase)
        {
            this.firebase = firebase;
            EntityName = nameof(Instruction);
        }
        public Task Delete(Instruction Entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Instruction> Findasync(Func<Instruction, bool> predicate)
        {
            var allPersons = await GetAsync();
            await firebase
              .Child(EntityName)
              .OnceAsync<Instruction>();
            return allPersons.Where(predicate).FirstOrDefault();
        }

        public async Task<List<Instruction>> GetAsync()
        {
            return (await firebase
            .Child(EntityName)
            .OnceAsync<Instruction>()).Select(item => new Instruction
            {
                Description = item.Object.Description,
                AnimationJson = item.Object.AnimationJson,
                Id = item.Object.Id,
                Title = item.Object.Title,

            }).ToList();
        }

        public async Task Insert(Instruction Entity)
        {

            await firebase
       .Child(EntityName)
       .PostAsync(Entity, true);


        }

        public async Task Update(Instruction Entity)
        {
            var toUpdate = (await firebase
          .Child(EntityName)
          .OnceAsync<Instruction>()).Where(a => a.Object.Id == Entity.Id).FirstOrDefault();

            await firebase
              .Child(EntityName)
              .Child(toUpdate.Key)
              .PutAsync(Entity);
        }
    }
}
