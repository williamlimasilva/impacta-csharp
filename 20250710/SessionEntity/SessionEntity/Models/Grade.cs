using System.ComponentModel.DataAnnotations;

namespace SessionEntity.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        //Navigation property to the related students
        public ICollection<Student>? Students { get; set; }
    }
}
