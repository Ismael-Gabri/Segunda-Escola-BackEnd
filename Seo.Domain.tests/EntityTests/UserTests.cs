using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seo.Domain.Entities;
using Seo.Domain.WebContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Seo.Domain.tests.Entities
{
    [TestClass]
    public class UserTests
    {
        private readonly Name _name = new Name("Ismael", "Castro");
        private readonly Email _email = new Email("ismaelgabri03@hotmail.com");
        private readonly string _password = "123";

        [TestMethod]
        public void When_A_New_User_Is_Created_Course_List_Should_Be_An_Empty_List()
        {
            var user = new User(_name, _email, _password);
            Assert.AreEqual(user.OnGoingCourses.Count, 0);
        }
    }
}
