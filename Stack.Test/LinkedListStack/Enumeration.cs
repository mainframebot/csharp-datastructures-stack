using NUnit.Framework;

namespace Stack.Test.LinkedListStack
{
    [TestFixture]
    public class Enumeration : Base
    {
        // Test: Use enumeration to traverse stack
        // Outcome:
        // 1. Counter is equal to stack count
        [Test]
        public void EnumeratePopulatedStack()
        {
            int counter = 0;
            foreach (var item in PopulatedLinkedListStack)
            {
                counter++;
            }

            Assert.That(PopulatedLinkedListStack.Count, Is.EqualTo(counter));
        }
    }
}
