using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Roles : BaseEntity
    {
        [Required]
        public string Title { get; set; }
    }
}
