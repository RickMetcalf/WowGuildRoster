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
using System.Windows.Shapes;
using DataClasses;
using DataModels;
using DataOps;


namespace GuildRoster
{
    /// <summary>
    /// Interaction logic for AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Window
    {
        private Player _player;
        private IList<Player> Players = new List<Player>();
        private IList<WowClass> Classes = new List<WowClass>();
        private IList<Spec> Specs = new List<Spec>();
        private IList<Team> Teams = new List<Team>();
        private IList<GuildRank> GuildRanks = new List<GuildRank>();
        private IList<Role> Roles = new List<Role>();

        public AddPlayer()
        {
            InitializeComponent();
            _player = new Player();
            var dataOp = new DataOp();
            Classes = dataOp.GetClasses().Result;
            Teams = dataOp.GetTeams().Result;
            GuildRanks = dataOp.GetGuildRanks().Result;
            Roles = dataOp.GetRoles().Result;
            Specs = dataOp.GetSpecs().Result;
            playerClass.ItemsSource = Classes;           
            playerRank.ItemsSource = GuildRanks;
            playerTeam.ItemsSource = Teams;           
        }
        private void playerClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            playerSpec.ClearValue(ItemsControl.ItemsSourceProperty);
            playerSpec.Items.Clear();

            var cboBox = sender as ComboBox;
            var selection = cboBox.SelectedItem as WowClass;
            LoadSpecs(selection);
        }
        
        private void playerSpec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            playerRole.ClearValue(ItemsControl.ItemsSourceProperty);
            playerRole.Items.Clear();
            var cboBoxTwo = sender as ComboBox;
            var selectionTwo = cboBoxTwo.SelectedItem as Spec;
            //LoadRole(selectionTwo);
            LoadRole(selectionTwo);
        }
        private void LoadSpecs(WowClass selecteditem)
        {
            playerRole.ClearValue(ItemsControl.ItemsSourceProperty);
            playerRole.Items.Clear();
            var data = Specs.Where(x => x.WowClassId == selecteditem.Id).ToList();
            playerSpec.ItemsSource = data;
        }
        private void LoadRole(Spec selecteditem)
        {
            if (selecteditem != null)
            {
                var data = Roles.Where(x => x.Id == selecteditem.RoleId).ToList();
                playerRole.ItemsSource = data;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addPlayer_Click(object sender, RoutedEventArgs e)
        {
            
            var classSelection = playerClass.SelectedIndex;
            var specSelection = playerSpec.SelectedItem.ToString();  
            var roleSelection = playerRole.SelectedItem.ToString();
            var rankSelection = playerRank.SelectedIndex;
            var teamSelection = playerTeam.SelectedIndex;

            _player.PlayerName = playerName.Text;
            _player.WowClassID = classSelection + 1;
            _player.Specialization = specSelection;
            _player.PlayerRole = roleSelection;
            _player.GuildRankID = rankSelection + 1;
            _player.TeamID = teamSelection + 1;


            if(string.IsNullOrEmpty(this.playerName.Text))
            {
                MessageBox.Show("Please enter a name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(this.playerName.Text.Length > 12)
            {
                MessageBox.Show("Character names can only be 12 characters long","Error" ,MessageBoxButton.OK, MessageBoxImage.Error);
                return ;
            }
            if (classSelection == 0 || specSelection == null || roleSelection == null || rankSelection == -1 || teamSelection == -1)
            {
                MessageBox.Show("One or more fields are not fully filled out", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var addPlayer = new DataOp();
            Task.Run(() => addPlayer.AddPlayer(_player));           
            this.Close();

        }

        

        
    }
}
