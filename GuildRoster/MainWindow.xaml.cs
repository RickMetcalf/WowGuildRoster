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
using System.Diagnostics;

namespace GuildRoster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private static IConfigurationRoot _configuration;
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
            dgTeams.Visibility = Visibility.Collapsed;
            addTeam.Visibility = Visibility.Collapsed;
            removeTeam.Visibility = Visibility.Collapsed;
            updateTeam.Visibility = Visibility.Collapsed;
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
            Refresh();

            
        }
        

        private void ViewRoster_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            dgTeams.Visibility = Visibility.Collapsed;
            addTeam.Visibility = Visibility.Collapsed;
            removeTeam.Visibility = Visibility.Collapsed;
            updateTeam.Visibility = Visibility.Collapsed;
            dgRoster.Visibility=Visibility.Visible;           
            var dataView = Players.Where(x => x != null).ToList();
            dgRoster.ItemsSource = dataView;
            
            
        }
        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            var newPlayerAdd = new AddPlayer();
            newPlayerAdd.Show();
        }

        private void RemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (dgRoster.SelectedItem != null)
            {
                Player selectedPlayer = dgRoster.SelectedItem as Player;
                int playerInfo = selectedPlayer.Id;
                string playerName = selectedPlayer.PlayerName;                              
                var userChoice = MessageBox.Show($"Do you want to delete {playerName}?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (userChoice == MessageBoxResult.Yes)
                {
                    var deleteOp = new DataOp();
                    Task.Run(() => deleteOp.DeletePlayer(playerInfo));
                    MessageBox.Show($"{playerName} deleted", "Player Deleted", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    Refresh();
                }
            }
            

        }

        private void ViewTeams_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
            
            dgRoster.Visibility = Visibility.Collapsed;
            addTeam.Visibility = Visibility.Visible;
            removeTeam.Visibility = Visibility.Visible;
            updateTeam.Visibility = Visibility.Visible;
            dgTeams.Visibility = Visibility.Visible;
            var dataview = Teams.Where(x => x != null).ToList();
            dgTeams.ItemsSource = dataview;

        }

        private void AddTeam_Click(object sender, RoutedEventArgs e)
        {
            var newTeamAdd = new AddTeam();
            newTeamAdd.Show();

        }

        private void UpdateTeam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveTeam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgRoster_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void dgTeams_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

    }

}
