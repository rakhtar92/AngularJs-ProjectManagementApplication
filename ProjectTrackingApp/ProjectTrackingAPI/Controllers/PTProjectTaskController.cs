using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ProjectTrackingAPI.Models;

namespace ProjectTrackingAPI.Controllers
{
    [EnableCors ( origins: "http://localhost:54062", headers: "*", methods: "*" )]
    public class PTProjectTaskController : ApiController
    {
        // GET: api/PTProjectTask
        [Route ( "api/ptprojecttasks" )]
        public IEnumerable<ProjectTask> Get()
        {
            return ProjectTasksRepository.GetAllProjectTasks ( );
        }

        // GET: api/PTProjectTask/5
        [Route ( "api/ptprojecttasks/{id}" )]
        public ProjectTask Get(int id)
        {
            return ProjectTasksRepository.GetProjectTask ( id );
        }

        // POST: api/PTProjectTask
        [Route ( "api/ptprojecttasks" )]
        public List<ProjectTask> Post(ProjectTask pt)
        {
            return ProjectTasksRepository.InsertPrrojectTask ( pt );
        }

        // PUT: api/PTProjectTask/5
        [Route ( "api/ptprojecttasks" )]
        public List<ProjectTask> Put(ProjectTask pt)
        {
            return ProjectTasksRepository.UpdateProjectTask ( pt );
        }

        // DELETE: api/PTProjectTask/5
        [Route ( "api/ptprojecttasks" )]
        public List<ProjectTask> Delete(ProjectTask pt)
        {
            return ProjectTasksRepository.DeleteProjectTask ( pt );
        }
    }
}
