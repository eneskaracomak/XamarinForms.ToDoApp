using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace TimelinePulse.Classes
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Item>().Wait();
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<List<Item>> GetItemAsync()
        {
            return _database.Table<Item>().ToListAsync();
        }
        public Task<List<User>> GetUserAsync()
        {
            return _database.Table<User>().ToListAsync();
        }
        public List<Item> ToList()
        {
            List<Item> x;
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "timeLine.db3")))
            {
                 return x = connection.Table<Item>().ToList();
                //// NOTE: In this sample the focus is on the UI. This is a Fake service.
              
            }
          

        }
        public List<User> ToUserList()
        {
            List<User> x;
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "timeLine.db3")))
            {
                return x = connection.Table<User>().ToList();
                //// NOTE: In this sample the focus is on the UI. This is a Fake service.

            }


        }

        public Task<int> SaveItemAsync(Item item)
        {
            return _database.InsertAsync(item);
        }
        public Task<int> DeleteItemAsync(Item item)
        {
            return _database.DeleteAsync(item);
        }
        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }

        internal Task SaveItemAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
