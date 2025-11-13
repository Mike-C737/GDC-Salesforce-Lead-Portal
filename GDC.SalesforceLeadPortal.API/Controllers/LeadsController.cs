using GDC.SalesforceLeadPortal.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GDC.SalesforceLeadPortal.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LeadsController : ControllerBase
{
    private readonly ILogger<LeadsController> _logger;

    public LeadsController(ILogger<LeadsController> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpPost]
    public IActionResult Create([FromBody] LeadDto dto)
    {
        if (!ModelState.IsValid)
            return ValidationProblem(ModelState);

        var id = Guid.NewGuid();

        _logger.LogInformation("Lead received (id: {Id}): {@Lead}", id, dto);

        return Created($"/api/leads/{id}", new
        {
            id,
            receivedAtUtc = DateTime.UtcNow
        });
    }
}
