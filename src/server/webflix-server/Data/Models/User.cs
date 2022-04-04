using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webflix_server.Data.Models;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name", TypeName = "varchar")]
    public string? Name { get; set; }
    
    [Column("email", TypeName = "varchar")]
    public string? Email { get; set; }

    [Column("profile_pic", TypeName = "varchar")]
    public string? ProfilePic { get; set; }
    
    [Column("bio", TypeName = "varchar")]
    public string? Bio { get; set; }

    [Column("last_login", TypeName = "timestamp")]
    public DateTime? LastLogin { get; set; }

    public virtual ICollection<SocialLink> SocialLinks { get; set; }
}