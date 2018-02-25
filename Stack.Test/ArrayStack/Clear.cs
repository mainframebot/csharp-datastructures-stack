using NUnit.Framework;

namespace Stack.Test.ArrayStack
{
    [TestFixture]
    public class Clear : Base
    {
        // Test: Use Clear() to reset an empty stack
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearEmptyStack()
        {
            EmptyArrayStack.Clear();

            Assert.That(EmptyArrayStack.Count, Is.EqualTo(0));
        }

        // Test: Use Clear() to reset a single item stack
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearSingleItemStack()
        {
            SingleItemArrayStack.Clear();

            Assert.That(SingleItemArrayStack.Count, Is.EqualTo(0));
        }

        // Test: Use Clear() to reset a populated stack
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearPopulatedStack()
        {
            PopulatedArrayStack.Clear();

            Assert.That(PopulatedArrayStack.Count, Is.EqualTo(0));
        }
    }
}
