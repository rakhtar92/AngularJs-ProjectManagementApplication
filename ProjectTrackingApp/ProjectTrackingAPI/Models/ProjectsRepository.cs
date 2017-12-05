using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTrackingAPI.Models
{
    public class ProjectsRepository
    {
        private static ProjectTrackingDBEntities dataContext = new ProjectTrackingDBEntities ( );

        public static List<Project> GetAllProjects ( )
        {
            var query = from project in dataContext.Projects select project;
            return query.ToList ( );
        }
        public static Project GetProject ( int ProjectID )
        {
            var query = from project in dataContext.Projects where project.ProjectID == ProjectID select project;
            return query.SingleOrDefault ( );
        }
        public static List<Project> GetPRojectByName ( string projectName )
        {
            var query = from project in dataContext.Projects where project.ProjectName.Contains ( projectName ) select project;
            return query.ToList ( );
        }
        public static List<Project> InsertProject ( Project p )
        {
            dataContext.Projects.Add ( p );
            dataContext.SaveChanges ( );
            return GetAllProjects ( );
        }
        public static List<Project> UpdateProject ( Project p )
        {
            var proj = (from project in dataContext.Projects where project.ProjectID == p.ProjectID select project).SingleOrDefault ( );
            proj.ProjectName = p.ProjectName;
            proj.StartDate = p.StartDate;
            proj.EndDate = p.EndDate;
            proj.ClientName = p.ClientName;
            dataContext.SaveChanges ( );
            return GetAllProjects ( );
        }
        public static List<Project> DeleteProjects ( int projectID )
        {
            var proj = (from project in dataContext.Projects where project.ProjectID == projectID select project).SingleOrDefault ( );
            dataContext.Projects.Remove ( proj );
            dataContext.SaveChanges ( );
            return GetAllProjects ( );
        }
        public void Dispose ( )
        {
            dataContext.Dispose ( );
        }
    }
}