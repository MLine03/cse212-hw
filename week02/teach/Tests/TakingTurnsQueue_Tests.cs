using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class TakingTurnsQueue_Tests
{
    [TestMethod]
    public void AddPerson_And_GetNextPerson_WorksCorrectly()
    {
        var queue = new TakingTurnsQueue();
        queue.AddPerson("Alice", 2);
        queue.AddPerson("Bob", 0); // infinite turns

        // First call returns Alice, turns decrease
        Assert.AreEqual("Alice", queue.GetNextPerson());

        // Second call returns Bob, infinite turns so still in queue
        Assert.AreEqual("Bob", queue.GetNextPerson());

        // Third call returns Alice again (since 2 turns)
        Assert.AreEqual("Alice", queue.GetNextPerson());

        // Fourth call returns Bob again
        Assert.AreEqual("Bob", queue.GetNextPerson());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void GetNextPerson_Throws_WhenQueueEmpty()
    {
        var queue = new TakingTurnsQueue();
        queue.GetNextPerson();  // Should throw exception
    }
}
