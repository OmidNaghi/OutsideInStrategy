using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Profile : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public string NationalCode { get; set; }

        public Demographic Demographics { get; set; }

    }
}