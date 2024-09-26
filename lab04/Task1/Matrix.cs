namespace lab04.Task1;

public struct Matrix
{
    Matrix(UInt16 width, UInt16 height)
    {
        Width = width;
        Height = height;

        _matrix = new int[][width];
        for (var i = 0; i < width; ++i)
        {
            _matrix[i] = new int[height];
            for (var j = 0; j < height; ++j)
            {
                _matrix[i][j] = Random.Shared.Next();
            }
        }
    }
    
    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.Width != m2.Width || m1.Height != m2.Height)
        {
            throw new ArgumentException("Matrix sizes do not match");
        }

        var newMatrix = new Matrix(m1.Width, m1.Height);
        for (var i = 0; i < m1.Width; ++i)
        {
            for (var j = 0; j < m1.Height; ++j)
            {
                newMatrix[i][j] = m1[i][j] + m2[i][j];
            }
        }

        return newMatrix;
    }
    
    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.Width != m2.Width || m1.Height != m2.Height)
        {
            throw new ArgumentException("Matrix sizes do not match");
        }

        var newMatrix = new Matrix(m1.Width, m1.Height);
        for (var i = 0; i < m1.Width; ++i)
        {
            for (var j = 0; j < m1.Height; ++j)
            {
                newMatrix[i][j] = m1[i][j] - m2[i][j];
            }
        }

        return newMatrix;
    }
    
    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.Width != m2.Height)
        {
            throw new ArgumentException("Matrix sizes do not match");
        }
        
        var newMatrix = new Matrix(m2.Width, m1.Height);
        for (var i = 0; i < newMatrix.Width; ++i)
        {
            for (var j = 0; j < newMatrix.Height; ++j)
            {
                newMatrix[i][j] = 0;
                for (var k = 0; k < m1.Width; ++k)
                {
                    newMatrix[i][j] += m1[i][k] * m2[j][k];
                }
            }
        }

        return newMatrix;
    }

    public static Matrix operator *(Matrix matrix, int multiplier)
    {
        var newMatrix = new Matrix(matrix.Width, matrix.Height);
        for (var i = 0; i < matrix.Width; ++i)
        {
            for (var j = 0; j < matrix.Height; ++j)
            {
                newMatrix[i][j] = matrix[i][j] * multiplier;
            }
        }

        return newMatrix;
    }

    public static Matrix operator /(Matrix matrix, int divider)
    {
        var newMatrix = new Matrix(matrix.Width, matrix.Height);
        for (var i = 0; i < matrix.Width; ++i)
        {
            for (var j = 0; j < matrix.Height; ++j)
            {
                newMatrix[i][j] = matrix[i][j] / divider;
            }
        }

        return newMatrix;
    }
    
    public int[] this[int x] => _matrix[x];
    public int this[int x, int y] => _matrix[x][y];
    public UInt16 Width { get; private set; }
    public UInt16 Height { get; private set; }
    
    private int[][] _matrix;
}