using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly ILogger<CompanyController> _logger;

    public CompanyController(ILogger<CompanyController> logger)
    {
        _logger = logger;
    }
    
}
