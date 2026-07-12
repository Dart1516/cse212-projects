using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{

    // As we are on soccer worlp cup this will use countries as the values in the queue.  The priority will be the number of goals scored by that country in the tournament.  The country with the highest number of goals will be removed first from the queue.
    [TestMethod]
    // Scenario:  Add teams with different priorities where the highest is in the middle:
    // Expected Result:  Argentina, France, Spain
    // Defect(s) Found: is working fine but just by luck. 
    // The Dequeue method is not correctly finding the highest priority item.  It is only working because the highest priority item happens to be in the middle of the queue.  If it was at the end of the queue it would not be found and removed.
    public void TestPriorityQueue_HighestInMiddle()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Spain", 2);
        priorityQueue.Enqueue("Argentina", 5);
        priorityQueue.Enqueue("France", 3);
        
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Argentina", result);

    }
    
    [TestMethod]
    // Scenario: Add teams where the highest priority team is at the very end:
    // Expected Result: Argentina, France, Spain
    // Defect(s) is not working because it skips checking the last element. It incorrectly returns "France" instead of "Argentina".


    public void TestPriorityQueue_HighestAtEnd()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Spain", 2);
        priorityQueue.Enqueue("France", 3);
        priorityQueue.Enqueue("Argentina", 5);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Argentina", result);
    }

    [TestMethod]
    // Scenario: Add multiple teams sharing the same highest priority to verify FIFO strategy:
    // Expected Result: France, England, Spain
    // Defect(s) Found: is showing the second country but it should be showing the first country.  
    
    public void TestPriorityQueue_DuplicatePrioritiesFIFO()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("France", 5);
        priorityQueue.Enqueue("England", 5);
        priorityQueue.Enqueue("Spain", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("France", result);
    }

    [TestMethod]
    // Scenario: Verify that the item is being removed from the queue after Dequeue is called.
    // Expected Result: First Dequeue returns Argentina, Second Dequeue returns France.
    // Defect(s) Found: The original code fails to remove the element from the internal list. 

    public void TestPriorityQueue_ItemIsRemoved()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Spain", 2);
        priorityQueue.Enqueue("Argentina", 5);
        priorityQueue.Enqueue("France", 3);

        // First removal should give Argentina (highest priority)
        var firstResult = priorityQueue.Dequeue();
        Assert.AreEqual("Argentina", firstResult);

        // Second removal should give France (next highest priority)
        var secondResult = priorityQueue.Dequeue();
        Assert.AreEqual("France", secondResult);
    }

    [TestMethod]
    // Scenario: Attempt to Dequeue from a completely empty world cup queue.
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: None. This specific validation works correctly in the original source code.
    public void TestPriorityQueue_EmptyQueueException()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("An InvalidOperationException should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(string.Format("Unexpected exception of type {0} caught: {1}", e.GetType(), e.Message));
        }
    }
}