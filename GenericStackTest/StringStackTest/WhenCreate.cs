using GenericStack;
using NUnit.Framework;

namespace GenericStackTest.StringStackTest
{
    [TestFixture]
    public class WhenCreate
    {
        [Test]
        public void ShouldHaveAMaximumCapacity()
        {
            var stack = new StringStack(1);
            Assert.IsNotNull(stack.Capacity);
        }

        [Test]
        public void CapacityShouldBeGreaterOrEqualThanZero()
        {
            var stack = new StringStack(1);
            Assert.IsTrue(stack.Capacity >=0 );
        }

        [Test]
        public void CapacityShouldBe50If50IsPassedToTheConstructor()
        {
            const int maximum = 50;
            var stack = new StringStack(maximum);
            Assert.AreEqual(50, stack.Capacity);
        }
    }
}