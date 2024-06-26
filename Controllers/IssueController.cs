using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IssueController : ControllerBase
{
    private readonly ILogger<IssueController> _logger;

    public IssueController(ILogger<IssueController> logger)
    {
        _logger = logger;
    }

}
