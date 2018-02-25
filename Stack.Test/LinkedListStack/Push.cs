using NUnit.Framework;

namespace Stack.Test.LinkedListStack
{
    [TestFixture]
    public class Push : Base
    {
        // Test: Use Push() to add a new item to the top of a new stack
        // Outcome:
        // 1. Count is equal to one
        [Test]
        public void PushToEmptyStack()
        {
            EmptyLinkedListStack.Push(Item);

            Assert.That(EmptyLinkedListStack.Count, Is.EqualTo(1));
        }

        // Test: Use Push() to add a new item to the top of a populated stack
        // Outcome:
        // 1. Count is equal to items + 1
        [Test]
        public void PushToPopulatedStack()
        {
            PopulatedLinkedListStack.Push(Item);

            Assert.That(PopulatedLinkedListStack.Count, Is.EqualTo(Items.Length + 1));
        }
    }
}
