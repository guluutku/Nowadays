using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReportController : ControllerBase
{
    private readonly ILogger<ReportController> _logger;

    public ReportController(ILogger<ReportController> logger)
    {
        _logger = logger;
    }
    
}
