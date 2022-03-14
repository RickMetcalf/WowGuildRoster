using DataClasses;
using DataModels;
using DataOps;
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
            dgRoster.Visibility = Visibility.Collapsed;
            Refresh();
        }
        public void Refresh()
        {
            var dataOp = new DataOp();
            Classes = dataOp.GetClasses().Result;
            Teams = dataOp.GetTeams().Result;
            GuildRanks = dataOp.GetGuildRanks().Result;
            Roles = dataOp.GetRoles().Result;
            Specs = dataOp.GetSpecs().Result;
            Players = dataOp.GetPlayers().Result;
            
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BuildOptions();

            
        }
        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<GuildDatabase>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("GuildRosterData"));
        }

        private void ViewRoster_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            dgRoster.Visibility=Visibility.Visible;           
            var dataView = Players.Where(x => x != null).ToList();
            dgRoster.ItemsSource = dataView;
            
            
        }
        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            var newPlayerAdd = new AddPlayer();
            newPlayerAdd.Show();
        }
    }

}
