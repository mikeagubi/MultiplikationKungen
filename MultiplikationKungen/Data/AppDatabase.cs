using System;
using System.Collections.Generic;
using System.Text;
using MultiplikationKungen.Models;
using SQLite;

namespace MultiplikationKungen.Data
{
    public class AppDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public AppDatabase()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "multiplikationkungen.db3");

            _database = new SQLiteAsyncConnection(dbPath);
        }

        public async Task InitializeAsync()
        {
            await _database.CreateTableAsync<Player>();
        }

        public async Task<int> AddPlayerAsync(Player player)
        {
            return await _database.InsertAsync(player);
        }

        public async Task<List<Player>> GetPlayersAsync()
        {
            return await _database.Table<Player>().ToListAsync();
        }
        
        //Testar Pullrequest



    }
}
