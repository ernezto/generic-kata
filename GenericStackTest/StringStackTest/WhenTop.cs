using System;
using GenericStack;
using NUnit.Framework;

namespace GenericStackTest.StringStackTest
{
    [TestFixture]
    class WhenTop
    {
        [Test]
        public void ThenShouldReturnHolaIfHolaIsAtTopOfStack()
        {
            var stack = new StringStack(1);
            stack.Push("Hola");
            Assert.AreEqual("Hola", stack.Top());
        }

        [Test]
        public void ThenNextTopShouldReturnPreviousNumber()
        {
            var stack = new StringStack(2);
            stack.Push("Hola");
            stack.Push("Mundo");
            stack.Top();

            Assert.AreEqual("Hola", stack.Top());
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThenShouldThrowInvalidOperationIfStackDoesNotContainsElements()
        {
            var stack = new StringStack(1);
            stack.Top();
        }


    }
}
