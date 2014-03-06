using System;
using GenericStack;
using NUnit.Framework;

namespace GenericStackTest.IntStackTest
{
    [TestFixture]
    class WhenTop
    {
        [Test]
        public void ThenShouldReturn3If3IsAtTopOfStack()
        {
            var stack = new IntStack(1);
            stack.Push(3);
            Assert.AreEqual(3, stack.Top());
        }

        [Test]
        public void ThenNextTopShouldReturnPreviousNumber()
        {
            var stack = new IntStack(2);
            stack.Push(5);
            stack.Push(3);
            stack.Top();

            Assert.AreEqual(5, stack.Top());
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThenShouldThrowInvalidOperationIfStackDoesNotContainsElements()
        {
            var stack = new IntStack(1);
            stack.Top();
        }


    }
}
