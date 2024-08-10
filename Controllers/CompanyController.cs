using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;
using Nowadays.Services;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{

    private readonly MongoDBService _mongoDBService;

    public CompanyController(MongoDBService mongoDBService)
    {
        _mongoDBService = mongoDBService;
    }

    [HttpGet]
    [Route("GetCompany")]
    public async Task<List<Company>> Get()
    {
        return await _mongoDBService.GetAsync();
    }

    [HttpPost]
    [Route("PostCompany")]
    public async Task<IActionResult> Post([FromBody] Company company)
    {
        await _mongoDBService.CreateAsync(company);
        return CreatedAtAction(nameof(Get), new { id = company.companyID }, company);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AddToCompany(string id, [FromBody] string employeeId)
    {
        await _mongoDBService.AddToCompanyAsync(id, employeeId);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _mongoDBService.DeleteAsync(id);
        return NoContent();
    }

}
