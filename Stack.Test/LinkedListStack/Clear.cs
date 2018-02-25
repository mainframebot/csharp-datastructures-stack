using NUnit.Framework;

namespace Stack.Test.LinkedListStack
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
            EmptyLinkedListStack.Clear();

            Assert.That(EmptyLinkedListStack.Count, Is.EqualTo(0));
        }

        // Test: Use Clear() to reset a single item stack
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearSingleItemStack()
        {
            SingleItemLinkedListStack.Clear();

            Assert.That(SingleItemLinkedListStack.Count, Is.EqualTo(0));
        }

        // Test: Use Clear() to reset a populated stack
        // Outcome:
        // 1. Count should equal 0
        [Test]
        public void ClearPopulatedStack()
        {
            PopulatedLinkedListStack.Clear();

            Assert.That(PopulatedLinkedListStack.Count, Is.EqualTo(0));
        }
    }
}
