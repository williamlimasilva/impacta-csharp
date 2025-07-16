using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Biography { get; set; }

        public DateTime? BirthDate { get; set; }

        // Navigation property for books
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
