using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Member : BaseEntity
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public Profile Profile { get; set; }
    }
}
