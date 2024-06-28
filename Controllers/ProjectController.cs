using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectController : ControllerBase
{
    IProjectRepository projectRepository = new ProjectRepository();

    /// <summary>
    /// Use this to get a list of all Projects
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("GetAllProjects")]
    public IEnumerable<Project> GetAllProjects()
    {
        return projectRepository.GetAllProjects();

    }

    [HttpGet]
    [Route("GetProject")]
    public Project GetProject(int projectID)
    {
        return projectRepository.GetProject(projectID);
    }

    [HttpPost]
    [Route("AddProject")]
    public Project AddProject(Project project)
    {
        return projectRepository.Add(project);
    }

    [HttpPost]
    [Route("UpdateProject")]
    public Project UpdateProject(Project project)
    {
        return projectRepository.Update(project);
    }

    [HttpDelete]
    [Route("DeleteProject")]
    public Project DeleteProject(int projectID)
    {
        return projectRepository.Delete(projectID);
    }

}
