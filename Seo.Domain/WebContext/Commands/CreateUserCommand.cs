using FluentValidator;
using Seo.Domain.WebContext.Commands.Contracts;
using Seo.Domain.WebContext.Entities;
using Seo.Domain.WebContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.WebContext.Commands
{
    public class CreateUserCommand : Notifications, ICommand
    {
        public CreateUserCommand()
        {

        }

        public CreateUserCommand(string firstName,
            string lastName,
            string address,
            string passwordHash
            )
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PasswordHash = passwordHash;
            OnGoingCourses = null;
            CreationDate = DateTime.Now;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PasswordHash { get; set; }
        public IList<string> OnGoingCourses { get; set; }
        public DateTime CreationDate { get; set; }
        public Dictionary<string, string> Notifications { get; private set; } = new Dictionary<string, string>();

        public void Validate()
        {
            if (FirstName == null || FirstName == "")
            {
                Notifications.Add("FirstName", "O campo está nulo ou vazio");
            }
            if (FirstName.ToString().Length < 3)
            {
                Notifications.Add("FirstNameLen", "O nome deve conter no mínimo 3 caracteres");
            }
            if (LastName == null || LastName == "")
            {
                Notifications.Add("LastName", "O campo está nulo ou vazio");
            }
            if (LastName.ToString().Length < 3)
            {
                Notifications.Add("LastNameLen", "O sobrenome deve conter no mínimo 3 caracteres");
            }
        }
    }
}
