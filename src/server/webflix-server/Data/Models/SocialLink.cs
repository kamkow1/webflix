using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace webflix_server.Data.Models;

[Table("social_links")]
public class SocialLink
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("url", TypeName = "varchar")]
    public string? Url { get; set; }

    [Column("name", TypeName = "varchar")]
    public string? Name { get; set; }

    [Column("icon_url", TypeName = "varchar")]
    public string? IconUrl { get; set; }

    [ForeignKey("User")]
    [Column("user_id", TypeName = "int")]
    public int? UserId { get; set; }

    [JsonIgnore]
    public virtual User User { get; set; }
}