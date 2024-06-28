using System;
namespace Nowadays.Models
{
    public interface IProjectRepository
    {

        List<Project> GetAllProjects();
        Project GetProject(int id);
        Project Delete(int id);
        Project Add(Project project);
        Project Update(Project project);

    }
}