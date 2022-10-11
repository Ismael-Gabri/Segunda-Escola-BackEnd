using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;

namespace Seo.Domain.WebContext.Commands.Contracts
{
    public interface ICommand
    {
        void Validate();
    }
}
