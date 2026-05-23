using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Three items with different priority
    // Expected Result: Items come out in order of priority
    // Defect(s) Found: Item never removed
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 5);
        
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Highest priority is added last
    // Expected Result: Highest priority should come out first
    // Defect(s) Found: Last item wasn't shown
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Middle", 2);
        priorityQueue.Enqueue("Last", 10);

        Assert.AreEqual("Last", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Two item have same priority
    // Expected Result: First in First out
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);

        Assert.AreEqual("Second", priorityQueue.Dequeue()); // >= means last tied item wins
    }
}