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
    [EnableCors(origins: "http://localhost:54062", headers:"*", methods:"*")]
    public class PTEmployeesController : ApiController
    {
        // GET: api/ptemployees
        [Route ("api/ptemployees")]
        public HttpResponseMessage Get()
        {
            var employees = EmployeeRepository.GetAllEmployee ( );
            HttpResponseMessage response = Request.CreateResponse ( HttpStatusCode.OK, employees );
            return response;
        }

        // GET api/ptemployees/5
        [Route ("api/ptemployees/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var employees = EmployeeRepository.GetEmployee ( id );
            HttpResponseMessage response = Request.CreateResponse ( HttpStatusCode.OK, employees );

            return response;
        }

        // POST: api/PTEmployees
        [Route("api/ptemployees/{name:alpha}")]
        public HttpResponseMessage Get(string name )
        {
            var employees = EmployeeRepository.SearchEmployeesByName ( name );
            HttpResponseMessage response = Request.CreateResponse ( HttpStatusCode.OK, employees );
            return response;
        }
        [Route("api/ptemployees")]
        public HttpResponseMessage Post(Employee e)
        {
            var employees = EmployeeRepository.InsertEmployee ( e );
            HttpResponseMessage response = Request.CreateResponse ( HttpStatusCode.OK, employees );
            return response;
        }

        // PUT: api/PTEmployees/5
        [Route ( "api/ptemployees" )]
        public HttpResponseMessage Put(Employee emp)
        {
            var employees = EmployeeRepository.UpdateEmployees ( emp );
            HttpResponseMessage response = Request.CreateResponse ( HttpStatusCode.OK, employees );
            return response;
        }

        // DELETE: api/PTEmployees/5
        [Route ( "api/ptemployees" )]
        public HttpResponseMessage Delete(Employee emp)
        {
            var employees = EmployeeRepository.DeleteEmployee ( emp );
            HttpResponseMessage response = Request.CreateResponse ( HttpStatusCode.OK, employees );
            return response;
        }
    }
}
