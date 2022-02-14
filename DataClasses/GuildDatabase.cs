using Microsoft.EntityFrameworkCore;
using System;

namespace DataClasses
{
    public class GuildDatabase : DbContext 
    {
        public GuildDatabase(DbContextOptions options) : base(options)
        {
            //left blank
        }

        public GuildDatabase() : base()
        {
            //left blank
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
