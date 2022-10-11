using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seo.Domain.WebContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.tests.ValueObjects
{
    public class NameTests
    {
        [TestClass]
        public class UserTests
        {
            [TestMethod]
            public void Should_Return_2_Notifications_When_Name_and_lastname_are_Not_Valid()
            {
                var name = new Name("i", "i");
                Assert.AreEqual(2 ,name.Notifications.Count);
            }

            [TestMethod]
            public void Should_Return_4_When_First_and_Lastname_are_Empty()
            {
                var name = new Name("", "");
                Assert.AreEqual(4, name.Notifications.Count);
            }
        }
    }
}
