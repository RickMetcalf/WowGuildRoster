using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.IO;
using DataModels;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Data.SqlClient;


namespace DataClasses
{
    public class GuildDatabase : DbContext 
    {
        private static IConfigurationRoot _configuration;
       
        public DbSet <DataModels.Player> Players { get; set; }
        public DbSet<DataModels.Spec> Specs { get; set; }
        public DbSet<DataModels.WowClass> Classes { get; set; }
        
        public DbSet<DataModels.Role> Roles { get; set; }
        public DbSet<DataModels.GuildRank> GuildRanks { get; set;}
        public DbSet<DataModels.Team> Teams { get; set; }  
        public GuildDatabase() : base()
        {
            //left blank
        }
        public GuildDatabase(DbContextOptions options) : base(options)
        {
            //left blank
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings2.json", optional: true, reloadOnChange: true);

                _configuration = builder.Build();
                var cnstr = _configuration.GetConnectionString("GuildRosterData");
                optionsBuilder.UseSqlServer(cnstr);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(x =>
            {
                x.HasData(new Player() { Id = 1, PlayerName = "Heterohexual", WowClassID = 10, TeamID = 1,  GuildRankID = 1 });
            });
            modelBuilder.Entity<WowClass>(a =>
            {
                a.HasData(new WowClass() { Id = 1, ClassName = "Death Knight" },
                          new WowClass() { Id = 2, ClassName = "Demon Hunter" },
                          new WowClass() { Id = 3, ClassName = "Druid" },
                          new WowClass() { Id = 4, ClassName = "Hunter" },
                          new WowClass() { Id = 5, ClassName = "Mage" },
                          new WowClass() { Id = 6, ClassName = "Monk" },
                          new WowClass() { Id = 7, ClassName = "Paladin" },
                          new WowClass() { Id = 8, ClassName = "Priest" },
                          new WowClass() { Id = 9, ClassName = "Rogue" },
                          new WowClass() { Id = 10, ClassName = "Shaman" },
                          new WowClass() { Id = 11, ClassName = "Warlock" },
                          new WowClass() { Id = 12, ClassName = "Warrior" }
                );
            });
            modelBuilder.Entity<Role>(b =>
            {
                b.HasData(new Role() { Id = 1, RoleName = "Tank" },
                          new Role() { Id = 2, RoleName = "Healer" },
                          new Role() { Id = 3, RoleName = "Melee DPS" },
                          new Role() { Id = 4, RoleName = "Ranged DPS" }

                );
            });
            modelBuilder.Entity<Spec>(c =>
            {
                c.HasData(new Spec() { Id = 1, SpecName = "Blood", WowClassId = 1, RoleId = 1 },
                          new Spec() { Id = 2, SpecName = "Frost", WowClassId = 1, RoleId = 3 },
                          new Spec() { Id = 3, SpecName = "Blood", WowClassId = 1, RoleId = 3 },
                          new Spec() { Id = 4, SpecName = "Vengeance", WowClassId = 2, RoleId = 1 },
                          new Spec() { Id = 5, SpecName = "Havoc", WowClassId = 2, RoleId = 3 },
                          new Spec() { Id = 6, SpecName = "Guardian", WowClassId = 3, RoleId = 1 },
                          new Spec() { Id = 7, SpecName = "Restoration", WowClassId = 3, RoleId = 2 },
                          new Spec() { Id = 8, SpecName = "Feral", WowClassId = 3, RoleId = 3 },
                          new Spec() { Id = 9, SpecName = "Balance", WowClassId = 3, RoleId = 4 },
                          new Spec() { Id = 10, SpecName = "Survival", WowClassId = 4, RoleId = 3 },
                          new Spec() { Id = 11, SpecName = "Beast Mastery", WowClassId = 4, RoleId = 4 },
                          new Spec() { Id = 12, SpecName = "Marksmanship", WowClassId = 4, RoleId = 4 },
                          new Spec() { Id = 13, SpecName = "Fire", WowClassId = 5, RoleId = 4 },
                          new Spec() { Id = 14, SpecName = "Frost", WowClassId = 5, RoleId = 4 },
                          new Spec() { Id = 15, SpecName = "Arcane", WowClassId = 5, RoleId = 4 },
                          new Spec() { Id = 16, SpecName = "Brewmaster", WowClassId = 6, RoleId = 1 },
                          new Spec() { Id = 17, SpecName = "Mistweaver", WowClassId = 6, RoleId = 2 },
                          new Spec() { Id = 18, SpecName = "Windwalker", WowClassId = 6, RoleId = 3 },
                          new Spec() { Id = 19, SpecName = "Protection", WowClassId = 7, RoleId = 1 },
                          new Spec() { Id = 20, SpecName = "Holy", WowClassId = 7, RoleId = 2 },
                          new Spec() { Id = 21, SpecName = "Retribution", WowClassId = 7, RoleId = 3 },
                          new Spec() { Id = 22, SpecName = "Discipline", WowClassId = 8, RoleId = 2 },
                          new Spec() { Id = 23, SpecName = "Holy", WowClassId = 8, RoleId = 2 },
                          new Spec() { Id = 24, SpecName = "Shadow", WowClassId = 8, RoleId = 4 },
                          new Spec() { Id = 25, SpecName = "Outlaw", WowClassId = 9, RoleId = 3 },
                          new Spec() { Id = 26, SpecName = "Subtlety", WowClassId = 9, RoleId = 3 },
                          new Spec() { Id = 27, SpecName = "Assassination", WowClassId = 9, RoleId = 3 },
                          new Spec() { Id = 28, SpecName = "Restoration", WowClassId = 10, RoleId = 2 },
                          new Spec() { Id = 29, SpecName = "Enhancement", WowClassId = 10, RoleId = 3 },
                          new Spec() { Id = 30, SpecName = "Elemental", WowClassId = 10, RoleId = 4 },
                          new Spec() { Id = 31, SpecName = "Destruction", WowClassId = 11, RoleId = 4 },
                          new Spec() { Id = 32, SpecName = "Demonology", WowClassId = 11, RoleId = 4 },
                          new Spec() { Id = 33, SpecName = "Affliction", WowClassId = 11, RoleId = 4 },
                          new Spec() { Id = 34, SpecName = "Protection", WowClassId = 12, RoleId = 1 },
                          new Spec() { Id = 35, SpecName = "Fury", WowClassId = 12, RoleId = 3 },
                          new Spec() { Id = 36, SpecName = "Arms", WowClassId = 12, RoleId = 3 }
                    );
            });
            modelBuilder.Entity<GuildRank>(b =>
            {
                b.HasData(new GuildRank() { Id = 1, GuildRankName = "Guild Master" },
                          new GuildRank() { Id = 2, GuildRankName = "Officer" },
                          new GuildRank() { Id = 3, GuildRankName = "Member" },
                          new GuildRank() { Id = 4, GuildRankName = "Trial" }

                );
            });
            modelBuilder.Entity<Team>(b =>
            {
                b.HasData(new Team() { Id = 1, TeamName = "Mythic Raiding" },
                          new Team() { Id = 2, TeamName = "M+ Team One" }


                );
            });


        }
    }

}
