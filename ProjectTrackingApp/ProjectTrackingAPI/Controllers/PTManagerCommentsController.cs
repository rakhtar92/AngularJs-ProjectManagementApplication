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
    public class PTManagerCommentsController : ApiController
    {
        [Route("api/ptmanagerComments")]
        public IEnumerable<ManagerComment> Get()
        {
            return ManagerCommentsRepository.GetAllManagerComments ( );
        }

        // GET: api/ptmanagerComments/5
        [Route( "api/ptmanagerComments/{id?}" )]
        public ManagerComment Get(int id)
        {
            return ManagerCommentsRepository.GetManagerComment ( id );
        }

        // POST: api/ptmanagerComments
        [Route( "api/ptmanagerComments" )]
        public List<ManagerComment> Post(ManagerComment comment)
        {
            return ManagerCommentsRepository.InsertManagerComments ( comment );
        }

        // PUT: api/ptmanagerComments/5
        [Route ( "api/ptmanagerComments" )]
        public List<ManagerComment> Put(ManagerComment comment)
        {
            return ManagerCommentsRepository.UpdateManagerComment ( comment );
        }

        // DELETE: api/ptmanagerComments/5
        [Route( "api/ptmanagerComments" )]
        public List<ManagerComment> Delete(ManagerComment comment)
        {
            return ManagerCommentsRepository.DeleteManagerComments ( comment);
        }
    }
}
