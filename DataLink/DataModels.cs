using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Player
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(12)]
        public string PlayerName { get; set; }
        [Required]
        public int WowClassID { get; set; }
        [Required, StringLength(20)]

        public string Specialization { get; set; }
        [Required, StringLength(20)]
        public string PlayerRole { get; set; }  
        public int TeamID { get; set; }

        

        [Required]
        public int GuildRankID { get; set; }
        public virtual Team? Team { get; set; }
        public virtual GuildRank? GuildRank { get; set; }
        public virtual WowClass? WowClass { get; set; }
        public override string ToString()
        {
            return PlayerName;
        }

        //public virtual Spec Spec { get; set; }


    }
    public class WowClass
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(16)]
        public string ClassName { get; set; }

        public virtual List<Spec> Spec { get; set; } = new List<Spec>();
        public virtual List<Player> Player { get; set; } = new List<Player>();
        public override string ToString()
        {
            return ClassName;
        }
    }
    public class Spec
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string SpecName { get; set; }
        [Required]
        public int WowClassId { get; set; } 
        [Required]
        public int RoleId { get; set; }

        public virtual WowClass? WowClass { get; set; }
        
        public virtual Role? Role { get; set; }
        public override string ToString()
        {
            return SpecName;
        }


    }
    public class Role
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }

        public virtual List<Spec> Specs { get; set; } = new List<Spec>();
        public override string ToString()
        {
            return RoleName;
        }
    }
    public class Team
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string TeamName { get; set; }

        public virtual List<Player> Players { get; set; } = new List<Player> { };
        public override string ToString()
        {
            return TeamName;
        }
    }
    public class GuildRank
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string GuildRankName { get; set; }

        public virtual List<Player> Players { get; set; } = new List<Player> { };
        public override string ToString()
        {
            return GuildRankName;
        }
    }
    
}
