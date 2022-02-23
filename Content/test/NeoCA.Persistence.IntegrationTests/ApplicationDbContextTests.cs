using NeoCA.Application.Contracts;
using NeoCA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;
using System;
using Xunit;

namespace NeoCA.Persistence.IntegrationTests
{
    public class ApplicationDbContextTests
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        private readonly string _loggedInUserId;

        public ApplicationDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _loggedInUserId = "00000000-0000-0000-0000-000000000000";
            _loggedInUserServiceMock = new Mock<ILoggedInUserService>();
            _loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

            _applicationDbContext = new ApplicationDbContext(dbContextOptions, _loggedInUserServiceMock.Object);
        }


       // [Fact]
        public async void Save_SetCreatedByProperty()
        {
            var ev = new Event() { EventId = Guid.NewGuid(), Name = "Test event" };

            _applicationDbContext.Events.Add(ev);
            await _applicationDbContext.SaveChangesAsync();

            ev.CreatedBy.ShouldBe(_loggedInUserId);
        }
    }
}
