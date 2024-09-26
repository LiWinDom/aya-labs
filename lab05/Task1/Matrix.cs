namespace lab05.Task1;

public struct Matrix
{
    Matrix(UInt16 width, UInt16 height)
    {
        Width = width;
        Height = height;

        _matrix = new int[width, height];
        Fill();
    }

    public void ChangeSize(UInt16 width, UInt16 height)
    {
        var newMatrix = new int[width, height];
        for (var i = 0; i < width; ++i)
        {
            for (var j = 0; j < height; ++j)
            {
                if (i < Width && j < Height)
                {
                    newMatrix[i, j] = _matrix[i, j];
                }
                else
                {
                    newMatrix[i, j] = Random.Shared.Next();
                }
            }
        }

        Width = width;
        Height = height;
        _matrix = newMatrix;
    }

    public void Show(UInt16 startX = 0, UInt16 startY = 0, UInt16 width = 0, UInt16 height = 0)
    {
        if (width == 0 || height == 0)
        {
            width = Width;
            height = Height;
        }

        for (var i = startX; i < startX + Width; ++i)
        {
            for (var j = startY; j < startY + Height; ++j)
            {
                Console.Write(_matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void Fill()
    {
        for (var i = 0; i < Width; ++i)
        {
            for (var j = 0; j < Width; ++j)
            {
                _matrix[i, j] = Random.Shared.Next();
            }
        }
    }
    
    public int this[int x, int y] => _matrix[x, y];
    public UInt16 Width { get; private set; }
    public UInt16 Height { get; private set; }
    
    private int[,] _matrix;
}