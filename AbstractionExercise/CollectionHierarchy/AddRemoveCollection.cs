namespace CollectionHierarchy;

public class AddRemoveCollection : ISupportsAdd, ISupportsRemove
{
    private readonly Queue<string> _queue = new Queue<string>();

    public int Add(string item)
    {
        this._queue.Enqueue(item);
        return 0;
    }

    public string Remove() => this._queue.Dequeue();

}