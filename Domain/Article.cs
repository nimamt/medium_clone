using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class Article
{
    public int Id { get; set; }
    public string Title { get; set; }
    [Required]
    public Category Category { get; set; }
    public string Body { get; set; }
    public bool IsApproved { get; set; }
    [ForeignKey("Author")]
    public int AuthorId { get; set; }
    [Required]
    public AppUser Author { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<AppUser> Likes { get; set; } = new List<AppUser>();
    public ICollection<AppUser> Saves { get; set; } = new List<AppUser>();
}