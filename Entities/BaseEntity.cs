using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class BaseEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime DateIn { get; set; }
        [Required]
        public DateTime Dateupdate { get; set; }
        [Required]
        public int MemberId { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
