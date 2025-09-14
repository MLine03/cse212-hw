public class PriorityQueue
{
    private readonly Queue<(string Value, int Priority)> _queue = new();

    public void Enqueue(string value, int priority)
    {
        _queue.Enqueue((value, priority));
    }

    public string Dequeue()
    {
        if (_queue.Count == 0)
            throw new InvalidOperationException("The queue is empty.");

        var items = _queue.ToList();
        int highestPriority = items.Max(item => item.Priority);
        var target = items.First(item => item.Priority == highestPriority);

        var newQueue = new Queue<(string Value, int Priority)>();
        bool removed = false;

        foreach (var item in _queue)
        {
            if (!removed && item.Equals(target))
            {
                removed = true;
                continue;
            }
            newQueue.Enqueue(item);
        }

        _queue.Clear();
        foreach (var item in newQueue)
        {
            _queue.Enqueue(item);
        }

        return target.Value;
    }

    public int Count => _queue.Count;
}
