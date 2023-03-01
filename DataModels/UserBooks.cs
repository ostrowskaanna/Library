using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataModels
{
    using System.ComponentModel.DataAnnotations;
    internal class UserBooks
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public DateTime BorrowStart { get; set; }

        [Required]
        public DateTime BorrowEnd { get; set; }

    }
}
