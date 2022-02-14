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
        [Required, StringLength(16)]
        public string PlayerClass { get; set; }
        [Required, StringLength(15)]
        public string Specialization { get; set; }
        [Required]
        public int RoleId { get; set; } 
        public int AltRoleId { get; set; }
        
        public int TeamId { get; set; }
        [Required]
        public int GuildRankID { get; set; }
        
    }
}
