using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTrackingAPI.Models
{
    public class ProjectTasksRepository
    {
        private static ProjectTrackingDBEntities dataContext = new ProjectTrackingDBEntities ( );
        public static List<ProjectTask> GetAllProjectTasks ( )
        {
            var query = from projectTask in dataContext.ProjectTasks select projectTask;
            return query.ToList ( );
        }
        public static ProjectTask GetProjectTask ( int projectTaskID )
        {
            var query = (from projectTask in dataContext.ProjectTasks where projectTask.ProjectTaskId == projectTaskID select projectTask).SingleOrDefault ( );
            return query;
        }
        public static List<ProjectTask> InsertPrrojectTask(ProjectTask PT )
        {
            dataContext.ProjectTasks.Add ( PT );
            dataContext.SaveChanges ( );
            return GetAllProjectTasks ( );
        }
        public static List<ProjectTask> UpdateProjectTask (ProjectTask PT )
        {
            var projTask = (from projectTasks in dataContext.ProjectTasks where projectTasks.ProjectTaskId == PT.ProjectTaskId select projectTasks).SingleOrDefault ( );
            projTask.AssignedTo = PT.AssignedTo;
            projTask.TaskStartDate = PT.TaskStartDate;
            projTask.TaskEndDate = PT.TaskEndDate;
            projTask.TaskCompletion = PT.TaskCompletion;
            projTask.USerStoryID = PT.USerStoryID;
            dataContext.SaveChanges ( );
            return GetAllProjectTasks ( );
        }
        public static List<ProjectTask> DeleteProjectTask(ProjectTask PT )
        {
            var projTask = (from projectTask in dataContext.ProjectTasks where projectTask.ProjectTaskId == PT.ProjectTaskId select projectTask).SingleOrDefault ( );
            dataContext.ProjectTasks.Remove ( projTask );
            dataContext.SaveChanges ( );
            return GetAllProjectTasks ( );
        }
    }
}