using System;
using NUnit.Framework;

namespace Ballance.StarDate.Tests
{
    [TestFixture]
    public class StarDateTests
    {
        [Test]
        public void ShouldReturnCorrectStarDate_WhenKnownEarthDatePassedIn()
        {
            var tngKnownDate = new DateTime(2318, 7, 5, 12, 0, 0);
            var equvalentStarDate = tngKnownDate.ToStarDate();
            Assert.AreEqual(0d, equvalentStarDate);
        }

        [Test]
        public void ShouldReturnCorrectStarDate_WhenSendingToday_April_24_2015()
        {
            var tngKnownDate = new DateTime(2015, 4, 24, 12, 0, 0);
            var equvalentStarDate = tngKnownDate.ToStarDate();
            Assert.AreEqual(-278404.30d, equvalentStarDate);
        }

        [Test]
        public void ShouldReturnCorrectHomesteadDate_WhenSending_April_6_2378()
        {
            var homesteadDate = new DateTime(2378, 4, 6, 12, 0, 0);
            var equivalentStarDate = homesteadDate.ToStarDate();
            Assert.AreEqual(54868.82d, equivalentStarDate);
        }
    }
}
