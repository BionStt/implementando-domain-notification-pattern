using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using DomainNotificationHelperSample.Domain.Commands;
using DomainNotificationHelperSample.Domain.Entities;
using DomainNotificationHelperSample.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomanNotificationSample.Services.UserServices
{
    public class RegisterUserService : ServerCommand
    {
        private RegisterUserCommand _command;
        private IUserRepository _repository;

        public RegisterUserService(RegisterUserCommand command, IUserRepository repository):base(command)
        {
            _command = command;
            _repository = repository;
        }

        public void Run()
        {
            Validate();
            if (HasNotifications())
                return;

            var user = new User(_command.Username, _command.Password);
            _repository.Save(user);
        }

        public void Validate()
        {
            AddNotification(Assert.Length(_command.Username,5,20,"Username", "Usuário Inválido"));
            AddNotification(Assert.IsNotNull(_command.Username, "Username", "Usuário Inválido"));
        }
        

    }
}
