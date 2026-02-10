using System.ComponentModel.DataAnnotations;

namespace edu.aramco.aspnet.api.Models.Requests;

public class CreateUserRequestModel
{
    [Required(ErrorMessage = "Please enter your first name")]
    [StringLength(20, ErrorMessage = "20 charcs are allowed")]
    public string? FirstName { get; set; }

    public required string LastName { get; set; }

    [Required]
    [RangeAttribute(1, 200, ErrorMessage = "Age must be between 1 and 200")]
    public int Age { get; set; }

    [Required]
    [StringLength(1)]
    [RegularExpression("^(M|F|f|m)$", ErrorMessage ="Test")]
    public string Gender { get; set; }
}