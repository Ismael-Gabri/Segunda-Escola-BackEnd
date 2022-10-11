using FluentValidator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.WebContext.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            Address = address;
        }
        public string Address { get; private set; }
        public IDictionary<string, string> Notifications { get; private set; }

        public void ValidateEmail() { }
    }
}
