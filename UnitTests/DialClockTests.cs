using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab9;

namespace UnitTests
{
    [TestClass]
    public class DialClockTests
    {
        [TestMethod]
        public void DialClock_DefaultConstructor_ShouldSetHoursAndMinutesToZero()
        {
            // Arrange
            DialClock clock = new DialClock();

            // Act

            // Assert
            Assert.AreEqual(0, clock.Hours);
            Assert.AreEqual(0, clock.Minutes);
        }

        [TestMethod]
        public void DialClock_ConstructorWithParameters_ShouldSetHoursAndMinutesCorrectly()
        {
            // Arrange
            DialClock clock = new DialClock(5, 30);

            // Act

            // Assert
            Assert.AreEqual(5, clock.Hours);
            Assert.AreEqual(30, clock.Minutes);
        }

        [TestMethod]
        public void DialClock_CopyConstructor_ShouldCreateNewInstanceWithSameHoursAndMinutes()
        {
            // Arrange
            DialClock originalClock = new DialClock(2, 45);

            // Act
            DialClock copyClock = new DialClock(originalClock);

            // Assert
            Assert.AreEqual(originalClock.Hours, copyClock.Hours);
            Assert.AreEqual(originalClock.Minutes, copyClock.Minutes);
        }

        [TestMethod]
        public void DialClock_AddMinute_ShouldIncrementMinutesByOne()
        {
            // Arrange
            DialClock clock = new DialClock(1, 59);

            // Act
            clock.AddMinute();

            // Assert
            Assert.AreEqual(2, clock.Hours);
            Assert.AreEqual(0, clock.Minutes);
        }

        [TestMethod]
        public void DialClock_DeleteMinute_ShouldDecrementMinutesByOne()
        {
            // Arrange
            DialClock clock = new DialClock(1, 0);

            // Act
            clock.DeleteMinute();

            // Assert
            Assert.AreEqual(0, clock.Hours);
            Assert.AreEqual(59, clock.Minutes);
        }
    }
}
