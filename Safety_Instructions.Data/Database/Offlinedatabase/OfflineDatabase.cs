using Firebase.Database.Offline;
using LiteDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Safety_Instructions.Data.Database.Offlinedatabase
{



    /// <summary>
    /// The offline database.
    /// </summary>
    public class OfflineDatabase : IDictionary<string, OfflineEntry>
    {
        private readonly LiteDB.LiteRepository db;
        private readonly IDictionary<string, OfflineEntry> cache;


        public OfflineDatabase(Type itemType, string filenameModifier)
        {
            var fullName = this.GetFileName(itemType.ToString());
            if (fullName.Length > 100)
            {
                fullName = fullName.Substring(0, 100);
            }

            BsonMapper mapper = BsonMapper.Global;
            mapper.Entity<OfflineEntry>().Id(o => o.Key);

            string root = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filename = fullName + filenameModifier + ".db";
            var path = Path.Combine(root, filename);
            this.db = new LiteRepository(new LiteDatabase(path, mapper));

            this.cache = db.Database.GetCollection<OfflineEntry>().FindAll()
                .ToDictionary(o => o.Key, o => o);
        }

        public int Count => this.cache.Count;

        public bool IsReadOnly => this.cache.IsReadOnly;

        public ICollection<string> Keys => this.cache.Keys;


        public ICollection<OfflineEntry> Values => this.cache.Values;
 
        public OfflineEntry this[string key]
        {
            get
            {
                return this.cache[key];
            }

            set
            {
                this.cache[key] = value;
                this.db.Upsert(value);
            }
        }


        public IEnumerator<KeyValuePair<string, OfflineEntry>> GetEnumerator()
        {
            return this.cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(KeyValuePair<string, OfflineEntry> item)
        {
            this.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            this.cache.Clear();
 
    
        }


        public bool Contains(KeyValuePair<string, OfflineEntry> item)
        {
            return this.ContainsKey(item.Key);
        }


        public void CopyTo(KeyValuePair<string, OfflineEntry>[] array, int arrayIndex)
        {
            this.cache.CopyTo(array, arrayIndex);
        }


        public bool Remove(KeyValuePair<string, OfflineEntry> item)
        {
            return this.Remove(item.Key);
        }

        public bool ContainsKey(string key)
        {
            return this.cache.ContainsKey(key);
        }


        public void Add(string key, OfflineEntry value)
        {
            this.cache.Add(key, value);
            this.db.Insert(value);
        }

        public bool Remove(string key)
        {
            this.cache.Remove(key);
            return this.db.Delete<OfflineEntry>(key);
        }

 

        public bool TryGetValue(string key, out OfflineEntry value)
        {
            return this.cache.TryGetValue(key, out value);
        }

        private string GetFileName(string fileName)
        {
            var invalidChars = new[] { '`', '[', ',', '=' };
            foreach (char c in invalidChars.Concat(System.IO.Path.GetInvalidFileNameChars()).Distinct())
            {
                fileName = fileName.Replace(c, '_');
            }

            return fileName;
        }
    }
}
