using Seo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.WebContext.Queries
{
    public static class UserQueries
    {
        public static Expression<Func<User, bool>> GetUser(string user)
        {
            return x => x.Name.FirstName == user;
        }

        public static Expression<Func<User, bool>> HasAnyCourses(string user)
        {
            return x => x.OnGoingCourses.Any();
        }
    }
}
