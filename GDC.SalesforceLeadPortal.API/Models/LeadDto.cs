using System.ComponentModel.DataAnnotations;

namespace GDC.SalesforceLeadPortal.API.Models;

public class LeadDto
{
    [Required] public string Title { get; set; } = string.Empty;
    [Required] public string Company { get; set; } = string.Empty;

    [Required, StringLength(2, MinimumLength = 2)]
    public string State { get; set; } = string.Empty;

    [Required] public string Industry { get; set; } = string.Empty;

    [Required, Url] public string Website { get; set; } = string.Empty;

    [Required, Range(1, int.MaxValue)] public int Employees { get; set; }

    [Required, EmailAddress] public string Email { get; set; } = string.Empty;

    [Required] public string FirstName { get; set; } = string.Empty;
    [Required] public string LastName { get; set; } = string.Empty;

    [Required, RegularExpression(@"^\d{7,20}$")]
    public string PhoneOffice { get; set; } = string.Empty;

    [Required, RegularExpression(@"^\d{7,20}$")]
    public string PhoneCell { get; set; } = string.Empty;
}
