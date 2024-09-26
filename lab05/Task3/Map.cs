namespace lab05.Task3;

public class Map<TKey, TValue>
{
    private class Node
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Node Next { get; set; }

        public Node(TKey key, TValue value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
    
    public Map(int capacity)
    {
        _nodes = new Node[capacity];
    }

    public void Add(TKey key, TValue value)
    {
        int index = GetHashIndex(key);
        var newNode = new Node(key, value);

        if (_nodes[index] == null)
        {
            _nodes[index] = newNode;
        }
        else
        {
            var current = _nodes[index];
            while (current.Next != null)
            {
                if (current.Key.Equals(key))
                {
                    throw new ArgumentException("Key already exists");
                }
                current = current.Next;
            }
            current.Next = newNode;
        }

        ++Size;
    }

    public TValue Get(TKey key)
    {
        int index = GetHashIndex(key);
        var current = _nodes[index];
        
        while (current != null)
        {
            if (current.Key.Equals(key))
            {
                return current.Value;
            }
            current = current.Next;
        }
        throw new KeyNotFoundException();
    }
    
    public IEnumerable<TValue> GetEnumerable()
    {
        for (var i = 0; i < _nodes.Length; ++i)
        {
            var node = _nodes[i];
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }
        yield break;
    }

    private int GetHashIndex(TKey key)
    {
        return int.Abs(key.GetHashCode()) % _nodes.Length;
    }
    
    public int Size { get; private set; }

    public TValue this[TKey key]
    {
        get => Get(key);
        set => Add(key, value);
    }
    
    private Node[] _nodes;
}