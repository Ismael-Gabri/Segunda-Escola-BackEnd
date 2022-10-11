using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seo.Domain.WebContext.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.tests.Entities
{
    [TestClass]
    public class CommandTests
    {
        private readonly CreateUserCommand _invalidCommand = new CreateUserCommand("", "", "", "");
        private readonly CreateUserCommand _validCommand = new CreateUserCommand("Ismael", "Castro", "Rua dos devs 101", "123");

        [TestMethod]
        public void When_Command_Is_Invalid()
        {
            _invalidCommand.Validate();
            Assert.AreEqual(_invalidCommand.Notifications.Count, 4);
        }

        [TestMethod]
        public void When_Command_Is_Valid()
        {
            _validCommand.Validate();
            Assert.AreEqual(_validCommand.Notifications.Count, 0);
        }
    }
}
