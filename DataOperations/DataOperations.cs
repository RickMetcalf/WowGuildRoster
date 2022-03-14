using DataLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataOperations
{
    public class DataOperations
    {
        public static IConfigurationRoot _configuration;
        public static DbContextOptionsBuilder<DataDbContext> _optionsBuilder;

        public static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyDataManagerData"));
        }
        public DataOperations()
        {
            BuildOptions();
        }
    }
}
