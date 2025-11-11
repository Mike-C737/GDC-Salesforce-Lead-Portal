using System.ComponentModel.DataAnnotations;

namespace GDC.SalesforceLeadPortal.API.Models;

public class LeadDto
{
    [Required] public string Title { get; set; } = default!;
    [Required] public string Company { get; set; } = default!;
    [Required, StringLength(2, MinimumLength = 2)] public string State { get; set; } = default!;
    [Required] public string Industry { get; set; } = default!;
    [Required, Url] public string Website { get; set; } = default!;
    [Required, Range(1, int.MaxValue)] public int Employees { get; set; }
    [Required, EmailAddress] public string Email { get; set; } = default!;
    [Required] public string FirstName { get; set; } = default!;
    [Required] public string LastName { get; set; } = default!;
    [Required] public string PhoneOffice { get; set; } = default!;
    [Required] public string PhoneCell { get; set; } = default!;
}
