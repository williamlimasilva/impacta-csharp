using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        public DateTime PublicationDate { get; set; }

        [Required]
        public string ISBN { get; set; } = string.Empty;

        // Foreign key for Author
        public int AuthorId { get; set; }

        // Navigation property
        [ForeignKey("AuthorId")]
        public virtual Author? Author { get; set; }
    }
}
