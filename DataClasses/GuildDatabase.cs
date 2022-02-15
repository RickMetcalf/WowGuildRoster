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
        public DbSet<DataModels.WowClass> Classes { get; set; }
        public DbSet<DataModels.Spec> Specs { get; set; }
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
                x.HasData(new Player() { Id = 1, PlayerName = "Heterohexual", PlayerClassID = 10, SpecializationID = 29, RoleID = 3, AltRoleID = 4, GuildRankID = 1 });
            });
            modelBuilder.Entity<WowClass>(a =>
            {
                a.HasData(new WowClass() { ClassID = 1, ClassName = "Death Knight"},
                          new WowClass() { ClassID = 2, ClassName = "Demon Hunter" },
                          new WowClass() { ClassID = 3, ClassName = "Druid" },
                          new WowClass() { ClassID = 4, ClassName = "Hunter" },
                          new WowClass() { ClassID = 5, ClassName = "Mage" },
                          new WowClass() { ClassID = 6, ClassName = "Monk" },
                          new WowClass() { ClassID = 7, ClassName = "Paladin" },
                          new WowClass() { ClassID = 8, ClassName = "Priest" },
                          new WowClass() { ClassID = 9, ClassName = "Rogue" },
                          new WowClass() { ClassID = 10, ClassName = "Shaman" },
                          new WowClass() { ClassID = 11, ClassName = "Warlock" },
                          new WowClass() { ClassID = 112, ClassName = "Warrior" }
                );
            });
            modelBuilder.Entity<Role>(b =>
            {
                b.HasData(new Role() { RoleID = 1, RoleName = "Tank" },
                          new Role() { RoleID = 2, RoleName = "Healer" },
                          new Role() { RoleID = 3, RoleName = "Melee DPS" },
                          new Role() { RoleID = 4, RoleName = "Ranged DPS" }

                );
            });
            modelBuilder.Entity<Spec>(c =>
            {
                c.HasData(new Spec() { SpecID = 1, SpecName = "Blood", ClassID = 1, RoleID = 1 },
                          new Spec() { SpecID = 2, SpecName = "Frost", ClassID = 1, RoleID = 3 },
                          new Spec() { SpecID = 3, SpecName = "Blood", ClassID = 1, RoleID = 3 },
                          new Spec() { SpecID = 4, SpecName = "Vengeance", ClassID = 2, RoleID = 1 },
                          new Spec() { SpecID = 5, SpecName = "Havoc", ClassID = 2, RoleID = 3 },
                          new Spec() { SpecID = 6, SpecName = "Guardian", ClassID = 3, RoleID = 1 },
                          new Spec() { SpecID = 7, SpecName = "Restoration", ClassID = 3, RoleID = 2 },
                          new Spec() { SpecID = 8, SpecName = "Feral", ClassID = 3, RoleID = 3 },
                          new Spec() { SpecID = 9, SpecName = "Balance", ClassID = 3, RoleID = 4 },
                          new Spec() { SpecID = 10, SpecName = "Survival", ClassID = 4, RoleID = 3 },
                          new Spec() { SpecID = 11, SpecName = "Beast Mastery", ClassID = 4, RoleID = 4 },
                          new Spec() { SpecID = 12, SpecName = "Marksmanship", ClassID = 4, RoleID = 4 },
                          new Spec() { SpecID = 13, SpecName = "Fire", ClassID = 5, RoleID = 4 },
                          new Spec() { SpecID = 14, SpecName = "Frost", ClassID = 5, RoleID = 4 },
                          new Spec() { SpecID = 15, SpecName = "Arcane", ClassID = 5, RoleID = 4 },
                          new Spec() { SpecID = 16, SpecName = "Brewmaster", ClassID = 6, RoleID = 1 },
                          new Spec() { SpecID = 17, SpecName = "Mistweaver", ClassID = 6, RoleID = 2 },
                          new Spec() { SpecID = 18, SpecName = "Windwalker", ClassID = 6, RoleID = 3 },
                          new Spec() { SpecID = 19, SpecName = "Protection", ClassID = 7, RoleID = 1 },
                          new Spec() { SpecID = 20, SpecName = "Holy", ClassID = 7, RoleID = 2 },
                          new Spec() { SpecID = 21, SpecName = "Retribution", ClassID = 7, RoleID = 3 },
                          new Spec() { SpecID = 22, SpecName = "Discipline", ClassID = 8, RoleID = 2 },
                          new Spec() { SpecID = 23, SpecName = "Holy", ClassID = 8, RoleID = 2 },
                          new Spec() { SpecID = 24, SpecName = "Shadow", ClassID = 8, RoleID = 4 },
                          new Spec() { SpecID = 25, SpecName = "Outlaw", ClassID = 9, RoleID = 3 },
                          new Spec() { SpecID = 26, SpecName = "Subtlety", ClassID = 9, RoleID = 3 },
                          new Spec() { SpecID = 27, SpecName = "Assassination", ClassID = 9, RoleID = 3 },
                          new Spec() { SpecID = 28, SpecName = "Restoration", ClassID = 10, RoleID = 2 },
                          new Spec() { SpecID = 29, SpecName = "Enhancement", ClassID = 10, RoleID = 3 },
                          new Spec() { SpecID = 30, SpecName = "Elemental", ClassID = 10, RoleID = 4 },
                          new Spec() { SpecID = 31, SpecName = "Destruction", ClassID = 11, RoleID = 4 },
                          new Spec() { SpecID = 32, SpecName = "Demonology", ClassID = 11, RoleID = 4 },
                          new Spec() { SpecID = 33, SpecName = "Affliction", ClassID = 11, RoleID = 4 },
                          new Spec() { SpecID = 34, SpecName = "Protection", ClassID = 12, RoleID = 1 },
                          new Spec() { SpecID = 35, SpecName = "Fury", ClassID = 12, RoleID = 3 },
                          new Spec() { SpecID = 36, SpecName = "Arms", ClassID = 12, RoleID = 3 }
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


        }
    }

}
