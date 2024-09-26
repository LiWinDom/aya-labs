namespace lab05.Task2;

public class Vector<T>
{
    public Vector(int size = 0, T filler = default)
    {
        Size = size;
        _array = new T[size];
        for (var i = 0; i < Size; ++i)
        {
            _array[i] = filler;
        }
    }
    
    public Vector(IEnumerable<T> collection)
    {
        Size = collection.Count();
        _array = new T[Size];
        for (var i = 0; i < Size; ++i)
        {
            _array[i] = collection.ElementAt(i);
        }
    }
    
    public void Add(T value)
    {
        if (Size >= _array.Length)
        {
            T[] newArray = new T[_array.Length * 2];
            for (var i = 0; i < _array.Length; ++i)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        _array[Size] = value;
        ++Size;
    }
    
    public T this[int index] => _array[index];
    public int Size { get; private set; }
    
    private T[] _array;
}