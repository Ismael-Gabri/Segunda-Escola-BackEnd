using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seo.Domain.Entities;
using Seo.Domain.WebContext.Queries;
using Seo.Domain.WebContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Seo.Domain.tests.QueryTests
{
    [TestClass]
    public class UserQuerieTests
    {
        private readonly Name _name;
        private readonly Email _email;
        private List<User> _users;

        public UserQuerieTests()
        {
            _users = new List<User>();

            _name = new Name("Ismael", "Castro");
            _email = new Email("ismaelgabrijob@hotmail.com");

            _users.Add(new User(_name, _email, "123"));

            _name = new Name("Guilherme", "Fabri");
            _email = new Email("GuiFabri07@hotmail.com");

            _users.Add(new User(_name, _email, "123"));

            _users.FirstOrDefault(x => x.Name == _name).OnGoingCourses.Add("CS50");

            _name = new Name("Wagner", "Pinheiro");
            _email = new Email("WagnerP@hotmail.com");

            _users.Add(new User(_name, _email, "123"));

            _users.FirstOrDefault(x => x.Name == _name).OnGoingCourses.Add("CS50");
        }

        [TestMethod]
        public void Should_Return_True_When_List_Of_Course_Is_Not_Empty()
        {
            var result = _users.AsQueryable().Where(UserQueries.HasAnyCourses("Guilherme"));
            Assert.AreEqual(true, result.Any());
        }
    }
}
