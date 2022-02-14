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
        public DbSet <Player> Players { get; set; } 
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
            //TODO 1: If you want to change the database name, find the appsettings.json file
            //      then modify the connection string for MyDataManagerData to set a different
            //      Database name
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                _configuration = builder.Build();
                var cnstr = _configuration.GetConnectionString("GuildRosterData");
                optionsBuilder.UseSqlServer(cnstr);
            }
        }
    }
}
