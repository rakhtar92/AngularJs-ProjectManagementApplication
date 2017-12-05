using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTrackingAPI.Models
{
    public class UserStoryRepository
    {
        private ProjectTrackingDBEntities dataContext;
        public UserStoryRepository ( )
        {
            dataContext = new ProjectTrackingDBEntities ( );
        }
        public List<UserStory> GetAllUserStory ( )
        {
            var query = from us in dataContext.UserStories select us;
            return query.ToList ( );
        }
        public UserStory GetUserStory(int UserStoryID )
        {
            var query = from us in dataContext.UserStories where us.UserStoryID == UserStoryID select us;
            return query.SingleOrDefault ( );
        }
        public List<UserStory> InsertUSerStory(UserStory us )
        {
            dataContext.UserStories.Add ( us );
            dataContext.SaveChanges ( );
            return GetAllUserStory ( );
        }
        public List<UserStory> UpdateUserStory(UserStory oldUS )
        {
            var userStory = (from us in dataContext.UserStories where us.UserStoryID == oldUS.UserStoryID select us).SingleOrDefault ( );
            userStory.Story = oldUS.Story;
            dataContext.SaveChanges ( );
            return GetAllUserStory ( );
        }
        public List<UserStory> DeleteUserStory(UserStory oldUS )
        {
            var userStory = (from us in dataContext.UserStories where us.UserStoryID == oldUS.UserStoryID select us).SingleOrDefault ( );
            dataContext.UserStories.Remove ( userStory );
            dataContext.SaveChanges ( );
            return GetAllUserStory ( );
        }
        public void Dispose ( )
        {
            dataContext.Dispose ( );
        }
    }
}