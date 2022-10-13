using Microsoft.EntityFrameworkCore;
using Seo.Domain.Entities;
using Seo.Domain.infra.Data;
using Seo.Domain.WebContext.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.infra.Repos
{
    public class UserRepository : IUserRepository
    {
        private readonly SeoContext _context;
        public UserRepository(SeoContext context)
        {
            _context = context;
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public User GetUserInformation(Guid id)
        {
            return _context.Users.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }
    }
}