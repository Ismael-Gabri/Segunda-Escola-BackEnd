using Seo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.WebContext.Repos
{
    public interface IUserRepository
    {
        void Create(User user);
        User GetUserInformation(Guid Id);
    }
}
