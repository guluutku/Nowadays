using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Company> Get()
    {
        return GetCompanies();
    }

    private List<Company> GetCompanies()
    {
        return new List<Company> { new Company(){
        name = "Şirket",
        isActive = true,
    }};
    }

}
