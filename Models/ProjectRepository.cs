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
                throw;
            }
        }

        Project IProjectRepository.Delete(int projectId)
        {
            try
            {
                Project? project = context.Projects.FirstOrDefault(c => c.projectID == projectId);
                project!.isActive = false;
                context.SaveChanges();

                return project;
            }
            catch
            {
                throw;
            }
        }

        List<Project> IProjectRepository.GetAllProjects()
        {
            List<Project> projects = context.Projects.ToList();
            return projects;
        }

        Project IProjectRepository.GetProject(int projectId)
        {
            var project = context.Projects.FirstOrDefault(c => c.projectID == projectId);
            return project!;
        }

        Project IProjectRepository.Update(Project project)
        {
            try
            {
                context.Update(project);
                context.SaveChanges();
                return project;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
