using System.ComponentModel.DataAnnotations;

namespace SessionEntity.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int GradeId { get; set; }
        public Grade? Grade { get; set; }

    }
}
