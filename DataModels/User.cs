using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataModels
{
    using System.ComponentModel.DataAnnotations;
    internal class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        
        [Required]
        public int RoleId { get; set; }

    }
}
