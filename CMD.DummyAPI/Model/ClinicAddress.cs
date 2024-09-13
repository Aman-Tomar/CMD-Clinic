using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMD.DummyAPI.Model
{
    public class ClinicAddress
    {
        [Key]
        public int ClinicAddressId { get; set; }
        [ForeignKey("Clinic")]
        public int ClinicId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Street { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string State { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [Required]
        public string Location { get; set; }

        public virtual Clinic Clinic { get; set; }
    }
}
