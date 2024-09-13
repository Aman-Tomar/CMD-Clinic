using System.ComponentModel.DataAnnotations;

namespace CMD.DummyAPI.Model
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string DepartmentName { get; set; }
    }
}
