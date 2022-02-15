using DataClasses;
using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.Configuration.Json;

namespace GuildRoster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private static IConfigurationRoot _configuration;
        public static DbContextOptionsBuilder<GuildDatabase> _optionsBuilder;
        private IList<Player> Players = new List<Player>();
        private IList<WowClass> Classes = new List<WowClass>();
        private IList<Spec> Specs = new List<Spec>();
        private IList<Team> Teams = new List<Team>();
        private IList<GuildRank> GuildRanks = new List<GuildRank>();
        private IList<Role> Roles = new List<Role>();


        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BuildOptions();
            using (var db = new GuildDatabase(_optionsBuilder.Options))
            {
                var dataView = from c in db.Classes
                               from s in db.Specs
                               from r in db.Roles
                               from p in db.Players
                               from g in db.GuildRanks
                               //from t in db.Teams
                               where p.PlayerClassID == c.ClassID &&
                                     s.SpecID == p.SpecializationID &&
                                     r.RoleID == p.RoleID &&
                                     p.GuildRankID == g.Id 
                                     //&& t.TeamID == p.TeamID || p.TeamID == 0)

                               select new
                                {
                                   p.PlayerName,
                                   c.ClassName,
                                   s.SpecName,
                                   r.RoleName,
                                   //t.TeamName,
                                   g.GuildRankName

                                 };
                //               into selection
                //               orderby selection.PlayerName descending, selection.RoleName descending
                //               select selection;
                var newDataView = from p in db.Players
                                  where p.PlayerName != null
                                  select p;
                dgRoster.ItemsSource = dataView.ToList();
            }
        }
        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<GuildDatabase>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("GuildRosterData"));
        }
    }

}
