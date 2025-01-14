﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TruthOrDrink
{
    public class LocalDBService
    {
        private const string DB_NAME = "local_players_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDBService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Player>();
        }

        public async Task<List<Player>> GetPlayers()
        {
            return await _connection.Table<Player>().ToListAsync();
        }

        public async Task Create(Player player)
        {
            await _connection.InsertAsync(player);
        }

        public async Task Update(Player player)
        {
            await _connection.UpdateAsync(player);
        }

        public async Task Delete(Player player)
        {
            await _connection.DeleteAsync(player);
        }

        public async Task<string> GetRandomPlayerNameAsync()
        {
            var players = await _connection.Table<Player>().ToListAsync();

            if (players == null || players.Count == 0)
            {
                return null; // als players leeg is
            }

            var random = new Random();
            var randomIndex = random.Next(players.Count);

            return players[randomIndex].PlayerName; // geeft een random naam terug
        }




    }
}
