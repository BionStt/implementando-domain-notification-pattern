using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainNotificationHelperSample.Domain.Commands;
using DomanNotificationSample.Services.UserServices;
using DomainNotificationHelperCore;
using DomainNotificationHelperSample.Domain.Repositories;
using DomainNotificationHelperSample.Domain.Entities;

namespace DomainNotificationHelperSample.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dado_um_username_invalido_deve_gerar_notificacao()
        {
            var runtime = new Runtime();

            RegisterUserCommand command = new RegisterUserCommand();
            command.Username = "";
            command.Password = "teste";

            RegisterUserService service= new RegisterUserService(command, new FakeUserRepository());
            service.Run();

            runtime.AddNotifications(service.GetNotifications());

            Assert.IsTrue(runtime.HasNotifications());


        }

        [TestMethod]
        public void Dado_um_username_invalido_deve_gerar_notificacao2()
        {

            RegisterUserCommand command = new RegisterUserCommand();
            command.Username = "";
            command.Password = "teste";

            RegisterUserService service = new RegisterUserService(command, new FakeUserRepository());
            service.Run();

            Assert.IsTrue(service.HasNotifications());


        }
    }

    public class FakeUserRepository : IUserRepository
    {
        public void Save(User user)
        {
            return;
        }
    }
}
