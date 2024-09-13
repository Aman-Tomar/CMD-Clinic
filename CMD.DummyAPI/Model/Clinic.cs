using System.ComponentModel.DataAnnotations;

namespace CMD.DummyAPI.Model
{
    public class Clinic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string Status { get; set; }

        public virtual ClinicAddress ClinicAddress { get; set; }
    }
}
