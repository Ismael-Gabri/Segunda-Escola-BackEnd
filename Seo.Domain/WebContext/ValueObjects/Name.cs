using FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.WebContext.ValueObjects
{
    public class Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            ValidateName(firstName, lastName);
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Dictionary<string, string> Notifications { get; private set; } = new Dictionary<string, string>();

        public bool ValidateName(string firstName, string lastName)
        {
            if (firstName == null || firstName == "")
            {
                Notifications.Add("FirstName", "O campo está nulo ou vazio");
                return false;
            }
            else if (firstName.ToString().Length < 3)
            {
                Notifications.Add("FirstNameLen", "O nome deve conter no mínimo 3 caracteres");
                return false;
            }
            else if (lastName == null || lastName == "")
            {
                Notifications.Add("SecondName", "O campo está nulo ou vazio");
                return false;
            }
            else if (lastName.ToString().Length < 3)
            {
                Notifications.Add("SecondNameLen", "O sobrenome deve conter no mínimo 3 caracteres");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
