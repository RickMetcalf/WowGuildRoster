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
        public int PlayerClassID { get; set; }
        [Required]
        public int SpecializationID { get; set; }
        [Required]
        public int RoleID { get; set; } 
        public int AltRoleID { get; set; }
        
        public int TeamID { get; set; }
        [Required]
        public int GuildRankID { get; set; }
        
    }
    public class WowClass
    {
        [Required, Key]
        public int ClassID { get; set; }
        [Required, StringLength(16)]
        public string ClassName { get; set; }
    }
    public class Spec
    {
        [Required, Key]
        public int SpecID { get; set; }
        [Required, StringLength(20)]
        public string SpecName { get; set; }
        [Required]
        public int ClassID { get; set; } 
        [Required]
        public int RoleID { get; set; } 
           
    }
    public class Role
    {
        [Required, Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
    public class Team
    {
        [Required][Key]
        public int TeamID { get; set; }
        [Required, StringLength(20)]
        public string TeamName { get; set; }
        [Required]
        public int MaxTeamSize { get; set; }
    }
    public class GuildRank
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string GuildRankName { get; set; }   
    }
}
