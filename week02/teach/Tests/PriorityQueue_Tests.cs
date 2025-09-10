using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueue_Tests
{
    [TestMethod]
    public void Enqueue_Dequeue_WorksCorrectly()
    {
        var pq = new PriorityQueue<string>();
        pq.Enqueue("low", 1);
        pq.Enqueue("high1", 10);
        pq.Enqueue("high2", 10);
        pq.Enqueue("medium", 5);

        // Dequeue should return "high1" first (highest priority, FIFO)
        Assert.AreEqual("high1", pq.Dequeue());
        // Then "high2"
        Assert.AreEqual("high2", pq.Dequeue());
        // Then "medium"
        Assert.AreEqual("medium", pq.Dequeue());
        // Then "low"
        Assert.AreEqual("low", pq.Dequeue());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Dequeue_Throws_WhenEmpty()
    {
        var pq = new PriorityQueue<int>();
        pq.Dequeue();
    }
}
