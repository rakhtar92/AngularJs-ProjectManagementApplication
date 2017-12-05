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
    public class PTProjectsController : ApiController
    {
        //ProjectsRepository repository;
        //GET: api/PTProjects
       [Route ( "api/ptprojects" )]
        public HttpResponseMessage Get ( )
        {
            var projects = ProjectsRepository.GetAllProjects ( );
            HttpResponseMessage response = Request.CreateResponse ( HttpStatusCode.OK, projects );
            return response;
        }

        ////GET: api/PTProjects/5
        //[Route ( "api/ptprojects/{id}" )]
        //public Project Get ( int id )
        //{
        //    return repository.GetProject ( id );
        //}
        ////GET: api/PTProjects/name
        //[Route ( "api/ptprojects/{name:alpha}" )]
        //public List<Project> Get ( string name )
        //{
        //    return repository.GetPRojectByName ( name );
        //}

        ////POST: api/PTProjects
        //[Route ( "api/ptprojects" )]
        //public List<Project> Post (Project p )
        //{
        //    return repository.InsertProject (p);
        //}

        ////PUT: api/PTProjects/5
        //public List<Project> Put ( Project p )
        //{
        //    return repository.UpdateProject ( p );
        //}

        ////DELETE: api/PTProjects/5
        //public List<Project> Delete ( int p )
        //{
        //    return repository.DeleteProjects ( p );
        //}
    }
}
