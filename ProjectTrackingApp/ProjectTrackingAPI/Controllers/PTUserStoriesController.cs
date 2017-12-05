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
    public class PTUserStoriesController : ApiController
    {
        UserStoryRepository userstory;
        public PTUserStoriesController ( )
        {
            userstory = new UserStoryRepository ( );
        }
        // GET: api/PTUserStories
        [Route ( "api/ptuserstories" )]
        public IEnumerable<UserStory> Get ( )
        {
            return userstory.GetAllUserStory ( );
        }

        // GET: api/PTUserStories/5
        [Route ( "api/ptuserstories/{id}" )]
        public UserStory Get ( int id )
        {
            return userstory.GetUserStory ( id );
        }

        // POST: api/PTUserStories
        public List<UserStory> Post ( UserStory ust )
        {
            return userstory.InsertUSerStory ( ust );
        }

        // PUT: api/PTUserStories/5
        [Route ( "api/ptuserstories" )]
        public List<UserStory> Put ( UserStory ust )
        {
            return userstory.UpdateUserStory ( ust );
        }

        // DELETE: api/PTUserStories/5
        [Route ( "api/ptuserstories" )]
        public List<UserStory> Delete ( UserStory ust )
        {
            return userstory.DeleteUserStory ( ust );
        }
    }
}
