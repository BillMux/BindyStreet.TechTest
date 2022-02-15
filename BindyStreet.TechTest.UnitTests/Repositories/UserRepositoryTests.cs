using BindyStreet.TechTest.Repositories;
using Moq;
using NUnit.Framework;

namespace BindyStreet.TechTest.UnitTests.Repositories
{
    [TestFixture]
    public class UserRepositoryTests
    {
        private UserRepositoryTestContext context;
        private UserRepository repository;

        [SetUp]
        public void SetUp()
        {
            context = new UserRepositoryTestContext();
            repository = context.CreateUserRepository();
        }

        [Test]
        public void Constructor_AllParametersProvided_InstanceCreatedSuccessfully()
        {
            Assert.DoesNotThrow(() => new UserRepositoryTestContext().CreateUserRepository());
        }

        [Test]
        public void GetAll_AnyCase_MockedDataReturned()
        {
            var data = repository.GetAll();

            Assert.NotNull(data);
        }

        private class UserRepositoryTestContext
        {
            // mocked properties to be added here as needed

            public UserRepositoryTestContext()
            {
            }

            internal UserRepository CreateUserRepository()
                => new UserRepository();
        }
    }
}