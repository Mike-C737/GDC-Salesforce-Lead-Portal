using GDC.SalesforceLeadPortal.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GDC.SalesforceLeadPortal.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LeadsController : ControllerBase
{
    // POST /api/leads
    [HttpPost]
    public IActionResult Create([FromBody] LeadDto dto)
    {
        // TODO: persist (future task). For now, echo back with an id and timestamp.
        var id = Guid.NewGuid();
        var result = new
        {
            id,
            receivedAtUtc = DateTime.UtcNow,
            data = dto
        };

        // 201 Created with Location header to GET /api/leads/{id} (not implemented yet)
        return Created($"/api/leads/{id}", result);
    }
}
