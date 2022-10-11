using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seo.Domain.tests.Repos;
using Seo.Domain.WebContext.Commands;
using Seo.Domain.WebContext.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.tests.Handler
{
    [TestClass]
    public class CreateUserHandlerTests
    {
        private readonly CreateUserCommand _invalidCommand = new CreateUserCommand("", "", "", "");
        private readonly CreateUserCommand _validCommand = new CreateUserCommand("Ismael", "Castro", "Rua dos devs 101", "123");
        private readonly UserHandler _Handler = new UserHandler(new FakeUserRepository());

        [TestMethod]
        public void When_Command_Is_Invalid_Should_Stop_Execution()
        {
            var result = (GenericCommandResult)_Handler.Handle(_invalidCommand);
            Assert.AreEqual(result.Success, false);
        }

        [TestMethod]
        public void When_Command_Is_Valid_Should_Execute_The_Task()
        {
            var result = (GenericCommandResult)_Handler.Handle(_validCommand);
            Assert.AreEqual(result.Success, true);
        }
    }
}
