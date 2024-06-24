using System;
using Microsoft.EntityFrameworkCore;

namespace Nowadays.Models
{
    public class ProjectRepository : IProjectRepository
    {

        NowadaysContext context = new NowadaysContext();

        public ProjectRepository()
        {
        }

        Project IProjectRepository.Add(Project project)
        {
            try
            {
                context.Add(project);
                context.SaveChanges();
                return project;
            }
            catch (Exception)
            {
                return project;
            }
        }

        Project IProjectRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Project> IProjectRepository.GetAllProjects()
        {
            List<Project> skills = context.Projects.ToList();
            Console.WriteLine(skills);
            return skills;
        }

        Project IProjectRepository.GetProject(int id)
        {
            throw new NotImplementedException();
        }

    }
}