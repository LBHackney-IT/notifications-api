using System;
using NotificationsApi.V1.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace NotificationsApi.Tests.V1.Domain
{
    [TestFixture]
    public class EntityTests
    {
        [Test]
        public void EntitiesHaveAnId()
        {
            var entity = new Notification();
            entity.Id.Should().NotBeEmpty();//.BeGreaterOrEqualTo(0);
        }

        [Test]
        public void EntitiesHaveACreatedAt()
        {
            var entity = new Notification();
            var date = new DateTime(2019, 02, 21);
            entity.CreatedAt = date;

            entity.CreatedAt.Should().BeSameDateAs(date);
        }
    }
}