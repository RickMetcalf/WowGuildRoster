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
using DataLibrary;
using DataClasses;
using DataOps;
using DataModels;

namespace GuildRoster
{
    /// <summary>
    /// Interaction logic for AddTeam.xaml
    /// </summary>
    public partial class AddTeam : Window
    {
        private Team _team;
        private IList<Team> Teams = new List<Team>();
        public AddTeam()
        {
            InitializeComponent();
            _team = new Team();
            var dataop = new DataOp();
            Teams = dataop.GetTeams().Result;
        }

        private void addTeam_Click(object sender, RoutedEventArgs e)
        {
            _team.TeamName = teamName.Text;
            if (string.IsNullOrEmpty(this.teamName.Text))
            {
                MessageBox.Show("Please enter a name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var addTeam = new DataOp();
            Task.Run(() => addTeam.AddTeam(_team));
            this.Close();

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
