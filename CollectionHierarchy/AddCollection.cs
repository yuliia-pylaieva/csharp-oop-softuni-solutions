namespace CollectionHierarchy;

public class AddCollection : ISupportsAdd
{
    private readonly List<string> _list = new List<string>();
    public int Add(string item)
    {
        this._list.Add(item);
        return _list.Count - 1;
    }
}