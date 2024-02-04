using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab9;
using System.Collections.Generic;

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

        [TestMethod]
        public void DialClock_CalculateAngle_ShouldCalculateAngle()
        {
            // Arrange
            DialClock clock = new DialClock(0, 30);

            // Act
            double angle = clock.CalculateAngle();

            // Assert
            Assert.AreEqual(165, angle);
        }

        [TestMethod]
        public void DialClock_CalculateAngleStatic_ShouldCalculateAngleStatic()
        {
            // Arrange

            // Act
            double angle1 = DialClock.CalculateAngleStatic(0,30);
            double angle2 = DialClock.CalculateAngleStatic(0, -5);
            double angle3 = DialClock.CalculateAngleStatic(0, 70);

            // Assert
            Assert.AreEqual(165, angle1);
            Assert.AreEqual(152.5, angle2);
            Assert.AreEqual(25, angle3);
        }

        [TestMethod]
        public void DialClock_IsDewidedTwoHalf_ShouldReturnTrueOrFalse()
        {
            double angle1 = 127.5;
            double angle2 = 3;
            Assert.AreEqual(true, DialClock.IsDevidedTwoHalf(angle1));
            Assert.AreEqual(false, DialClock.IsDevidedTwoHalf(angle2));
        }

        [TestMethod]
        public void DialClock_Counter_ShouldReturnValue()
        {
            DialClock clock = new DialClock(1,30);
            Assert.AreEqual(99, clock.Counter());
        }

        [TestMethod]
        public void DialClock_GetObjectCount_ShouldReturnObjectsCount()
        {
            for (int i = 0; i < 5; i++)
            {
                DialClock clock = new DialClock();
            }
            Assert.AreEqual(5, DialClock.GetObjectCount());
        }

        [TestMethod]
        public void DialClock_Operators_ShouldSummarizeClocks()
        {
            DialClock clock1 = new DialClock(1, 1);
            DialClock clock2 = new DialClock(2, 2);
            DialClock clock3 = clock1 + clock2;
            DialClock clock4 = clock2 - clock1;
            Assert.AreEqual(clock3.Hours, clock1.Hours + clock2.Hours);
            Assert.AreEqual(clock3.Minutes, clock1.Minutes + clock2.Minutes);
            Assert.AreEqual(clock4.Hours, clock2.Hours - clock1.Hours);
            Assert.AreEqual(clock4.Minutes, clock2.Minutes - clock1.Minutes);
        }
    }
}
