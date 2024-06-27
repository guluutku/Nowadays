using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{

    ICompanyRepository companyRepository = new CompanyRepository();

    /// <summary>
    /// Use this to get a list of all companies
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("GetAllCompanies")]
    public IEnumerable<Company> GetAllCompanies()
    {
        return companyRepository.GetAllCompanies();
    }

    [HttpPost]
    [Route("AddCompany")]
    public Company AddCompany(Company company)
    {
        return companyRepository.Add(company);
    }

    [HttpPost]
    [Route("UpdateCompany")]
    public Company UpdateCompany(Company company)
    {
        return companyRepository.Update(company);
    }

    [HttpDelete]
    [Route("DeleteCompany")]
    public Company DeleteCompany(int companyID)
    {
        return companyRepository.Delete(companyID);
    }

    [HttpGet]
    [Route("GetCompany")]
    public Company GetCompany(int companyID)
    {
        return companyRepository.GetCompany(companyID);
    }

}
