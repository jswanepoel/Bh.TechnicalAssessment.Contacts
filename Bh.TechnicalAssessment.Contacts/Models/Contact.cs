using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bh.TechnicalAssessment.Contacts.Models
{
    [Table("Contacts")]
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [StringLength(96)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(96)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(10)]
        public string Phone { get; set; }
        [StringLength(10)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Note { get; set; }
    }
}