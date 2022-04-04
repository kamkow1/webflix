using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webflix_server.Data.Models;

public class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string? Name { get; set; }
    
    [Column("email")]
    public string? Email { get; set; }

    [Column("profile_pic")]
    public string? ProfilePic { get; set; }
    
    [Column("bio")]
    public string? Bio { get; set; }

    [Column("last_login")]
    public DateTime? LastLogin { get; set; }
}