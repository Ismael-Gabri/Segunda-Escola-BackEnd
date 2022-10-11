using Seo.Domain.Entities;
using Seo.Domain.WebContext.Commands;
using Seo.Domain.WebContext.Commands.Contracts;
using Seo.Domain.WebContext.Handlers.Contracts;
using Seo.Domain.WebContext.Repos;
using Seo.Domain.WebContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seo.Domain.WebContext.Handlers
{
    public class UserHandler : IHandler<CreateUserCommand>
    {
        private readonly IUserRepository _repository;

        public UserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateUserCommand command)
        {

            //Criar usuario
            var name = new Name("Ismael", "Castro");
            var email = new Email("ismaelgabri03@hotmail.com");
            var user = new User(name, email, "123");

            //Fail fast Validation
            command.Validate();
            if (command.Notifications.Count > 0)
                return new GenericCommandResult(
                    false,
                    "Ops, parece que sua tarefa está errada",
                    command.Notifications);

            //Salvar no banco
            _repository.Create(user);

            //Retornar resultado
            return new GenericCommandResult(true, "Tarefa salva", user);

            //Notificar usuario
        }
    }
}
