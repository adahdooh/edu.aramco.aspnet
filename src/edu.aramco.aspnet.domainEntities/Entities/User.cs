using System.ComponentModel.DataAnnotations;

namespace edu.aramco.aspnet.domainEntities.Entities;

public abstract class User
{
    [Key]
    public Guid Id { get; set; }

    [MaxLength(200)]
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? EmailAddress { get; set; }
    public required char Gender { get; set; }

    [MaxLength(200)]
    public required string Address { get; set; }
    //public required string Nationality { get; set; }
    public DateTime DOB{ get; set; }
    public string? Telephone { get; set; }
    public required string Password { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Guid? CreatedByUserId { get; set; }
    public Guid? UpdatedByUserId { get; set; }

    //public User CreatedBy { get; set; }
    //public User UpdatedBy { get; set; }
}
