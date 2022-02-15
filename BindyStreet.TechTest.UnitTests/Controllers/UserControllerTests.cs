using BindyStreet.TechTest.Controllers;
using BindyStreet.TechTest.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace BindyStreet.TechTest.UnitTests.Controllers
{
    [TestFixture]
    public class UserControllerTests
    {
        private UserControllerTestContext context;
        private UserController controller;

        [SetUp]
        public void SetUp()
        {
            context = new UserControllerTestContext();
            controller = context.CreateUserController();
        }

        [Test]
        public void Constructor_AllParametersProvided_InstanceCreatedSuccessfully()
        {
            Assert.DoesNotThrow(() => new UserControllerTestContext().CreateUserController());
        }

        [Test]
        public void Get_AnyCase_UserRepositoryCalled()
        {
            controller.Get();

            context.UserRepository.Verify(mock => mock.GetAll(), Times.Once());
        }

        private class UserControllerTestContext
        {
            internal Mock<ILogger<UserController>> Logger;
            internal Mock<IUserRepository> UserRepository;

            public UserControllerTestContext()
            {
                Logger = new Mock<ILogger<UserController>>();
                UserRepository = new Mock<IUserRepository>();
            }

            internal UserController CreateUserController()
                => new UserController(Logger.Object, UserRepository.Object);
        }
    }
}