namespace CollectionHierarchy;

public class MyList : ISupportsAdd, ISupportsRemove, ICountable
{
    private readonly Stack<string> _stack = new();

    public int Add(string item)
    {
        this._stack.Push(item);
        return 0;
    }
    public string Remove() => this._stack.Pop();
    public int Count => this._stack.Count;
}