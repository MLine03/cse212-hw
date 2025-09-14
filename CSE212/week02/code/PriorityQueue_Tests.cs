using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Defect(s) Found: Highest priority item not dequeued correctly. Fixed in Dequeue().
    public void Test_DequeuesHighestPriorityItem()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("Medium", 5);
        queue.Enqueue("High", 10);

        var result = queue.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Defect(s) Found: Did not preserve FIFO when priorities were equal.
    public void Test_TiePriorityResolvesFIFO()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("First", 5);
        queue.Enqueue("Second", 5);
        queue.Enqueue("Third", 3);

        var result = queue.Dequeue();
        Assert.AreEqual("First", result);
    }

    [TestMethod]
    // Defect(s) Found: No exception thrown on empty queue.
    public void Test_EmptyQueueThrowsException()
    {
        var queue = new PriorityQueue();

        try
        {
            queue.Dequeue();
            Assert.Fail("Expected exception not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}
