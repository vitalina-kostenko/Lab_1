using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TVector3D : TVector2D
{
    public double Z { get; set; }

    public TVector3D() : base()
    {
        Z = 0;
    }

    public TVector3D(double x, double y, double z) : base(x, y)
    {
        Z = z;
    }

    public TVector3D(TVector3D other) : base(other)
    {
        Z = other.Z;
    }

    public override string ToString() //перевизначення
    {
        return $"({X}, {Y}, {Z})";
    }

    public new double Length()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public new void Normalize()
    {
        double length = Length();
        if (length != 0)
        {
            X /= length;
            Y /= length;
            Z /= length;
        }
    }

    public static TVector3D operator +(TVector3D a, TVector3D b)
    {
        return new TVector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static TVector3D operator -(TVector3D a, TVector3D b)
    {
        return new TVector3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public static double operator *(TVector3D a, TVector3D b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    }

    public new void Input()
    {
        base.Input();
        Console.Write("Enter Z: ");
        Z = Convert.ToDouble(Console.ReadLine());
    }

    public new void Output()
    {
        Console.WriteLine($"Vector: {this}");
    }
}
