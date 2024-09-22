namespace lab03.Task1;

public struct Vector
{
    Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }
    
    public static Vector operator *(Vector v1, Vector v2)
    {
        return new Vector(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
    }

    public static Vector operator *(Vector v, double s)
    {
        return new Vector(v.X * s, v.Y * s, v.Z * s);
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.Length == v2.Length;
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    public static bool operator <(Vector v1, Vector v2)
    {
        return v1.Length < v2.Length;
    }

    public static bool operator >(Vector v1, Vector v2)
    {
        return v2 < v1;
    }

    public static bool operator <=(Vector v1, Vector v2)
    {
        return v2 >= v1;
    }

    public static bool operator >=(Vector v1, Vector v2)
    {
        return !(v1 < v2);
    }
    
    public readonly double X, Y, Z;
    public readonly double Length => Math.Sqrt(X * X + Y * Y + Z * Z);
}