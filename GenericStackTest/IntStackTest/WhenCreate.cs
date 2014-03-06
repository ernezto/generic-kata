using GenericStack;
using NUnit.Framework;

namespace GenericStackTest.IntStackTest
{
    [TestFixture]
    public class WhenCreate
    {
        [Test]
        public void ShouldHaveAMaximumCapacity()
        {
            var stack = new IntStack(1);
            Assert.IsNotNull(stack.Capacity);
        }

        [Test]
        public void CapacityShouldBeGreaterOrEqualThanZero()
        {
            var stack = new IntStack(1);
            Assert.IsTrue(stack.Capacity >=0 );
        }

        [Test]
        public void CapacityShouldBe50If50IsPassedToTheConstructor()
        {
            const int maximum = 50;
            var stack = new IntStack(maximum);
            Assert.AreEqual(50, stack.Capacity);
        }
    }
}