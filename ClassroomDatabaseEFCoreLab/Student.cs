using System.ComponentModel.DataAnnotations;

namespace ClassroomDatabaseEFCoreLab
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Food { get; set; }

        [Required]
        [MaxLength(50)]
        public string Hometown { get; set; }
    }
}
