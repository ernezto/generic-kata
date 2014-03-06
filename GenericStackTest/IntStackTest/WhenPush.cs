using System;
using GenericStack;
using NUnit.Framework;

namespace GenericStackTest.IntStackTest
{
    [TestFixture]
    public class WhenPush
    {
        [Test]
        public void IfPushNumberTwoThenStackShouldContainNumberTwoAtTop()
        {
            var stack = new Stack<int>(1);
            stack.Push(2);
            Assert.AreEqual(stack.Top(), 2);
        }

        [Test]
        public void IfPushNumberTenAndThreeThenStackShouldContainNumberTenAtTop()
        {
            var stack = new Stack<int>(1);
            stack.Push(10);
            Assert.AreEqual(stack.Top(), 10);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldThrowInvalidOperationExceptionIfCapacityIsOverloaded()
        {
            var stack = new Stack<int>(2);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
        }
    }
}
