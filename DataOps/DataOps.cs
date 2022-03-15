using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using DataModels;
using DataLibrary;
using DataClasses;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace DataOps
{
    public class DataOp
    {
        private static IConfigurationRoot _configuration;
        public static DbContextOptionsBuilder<GuildDatabase> _optionsBuilder;

        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<GuildDatabase>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("GuildRosterData"));
        }
        public DataOp()
        {
            BuildOptions();
        }

        public async Task<List<Spec>> GetSpecs()
        {
            await using (var db = new GuildDatabase(_optionsBuilder.Options))
            {
                return db.Specs.OrderBy(x => x.WowClassId).ToList();
            }
        }
        public async Task<List<WowClass>> GetClasses()
        {
            await using (var db = new GuildDatabase(_optionsBuilder.Options))
            {
                return db.Classes.OrderBy(x => x.ClassName).ToList();
            }
        }
        public async Task<List<Role>> GetRoles()
        {
            await using (var db = new GuildDatabase(_optionsBuilder.Options))
            {
                return db.Roles.OrderBy(x => x.RoleName).ToList();
            }
        }
        public async Task<List<GuildRank>> GetGuildRanks()
        {
            await using (var db = new GuildDatabase(_optionsBuilder.Options))
            {
                return db.GuildRanks.OrderBy(x => x.Id).ToList();
            }
        }
        public async Task<List<Team>> GetTeams()
        {
            await using (var db = new GuildDatabase(_optionsBuilder.Options))
            {
                return db.Teams.OrderBy(x => x.TeamName).ToList();
            }
        }
        public async Task<List<Player>> GetPlayers()
        {
            await using (var db = new GuildDatabase(_optionsBuilder.Options))
            {
                return db.Players.OrderBy(x => x.GuildRankID).ToList();
            }
        }
        public async Task AddPlayer(Player player)
        {
            await using (var db = new GuildDatabase(_optionsBuilder.Options))
            {
                db.Players.Add(player);
                db.SaveChanges();
            }
        }
        public async Task DeletePlayer(int deleteID)
        {
            await using (var db = new GuildDatabase(_optionsBuilder.Options))
            {
                var player = db.Players.SingleOrDefault(x => x.Id == deleteID);
                if (player != null)
                {
                    db.Players.Remove(player);
                    db.SaveChanges();
                }
            }
        }


    }
}
