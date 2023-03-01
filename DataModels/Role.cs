using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Security.Policy;

    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool SeeUserDetails { get; set; }
        public bool SeeYourBooks { get; set; }
        public bool BorrowBook { get; set; }
        public bool SeeAllBooks { get; set; }
        public bool AddBook { get; set; }
        public bool RemoveBook { get; set; }
        public bool SeeAllUsers { get; set; }
        public bool AddUser { get; set; }
        public bool RemoveUser { get; set; }
        public bool SeeAllRoles { get; set; }
        public bool AddRole { get; set; }
        public bool RemoveRole { get; set; }

    }
}
