using System;

public class TVector2D
{
    public double X { get; set; }
    public double Y { get; set; }

    public TVector2D()
    {
        X = 0;
        Y = 0;
    }

    public TVector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public TVector2D(TVector2D other)
    {
        X = other.X;
        Y = other.Y;
    }

    public override string ToString()
    {
        return $"({X:F10}, {Y:F10})"; //10 знаків після коми
    }

    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

    public void Normalize()
    {
        double length = Length();
        if (length != 0)
        {
            X /= length;
            Y /= length;
        }
    }

    public override bool Equals(object obj) //перезавантаження операторів порівняння
    {
        if (obj is TVector2D)
        {
            var other = (TVector2D)obj;
            return Math.Abs(X - other.X) < 1e-10 && Math.Abs(Y - other.Y) < 1e-10;
        }
        return false;
    }

    public static bool operator !=(TVector2D a, TVector2D b)
    {
        return !(a == b);
    }

    public static bool operator ==(TVector2D a, TVector2D b)
    {
        return a.Equals(b);
    }

    public static TVector2D operator +(TVector2D a, TVector2D b) //перезавантаження арифметичних операцій
    {
        return new TVector2D(a.X + b.X, a.Y + b.Y);
    }

    public static TVector2D operator -(TVector2D a, TVector2D b)
    {
        return new TVector2D(a.X - b.X, a.Y - b.Y);
    }

    public static double operator *(TVector2D a, TVector2D b)
    {
        a.Normalize();
        b.Normalize();

        return a.X * b.X + a.Y * b.Y;
    }

    public void Input()
    {
        bool validInput = false;
        while (!validInput)
        {
            try
            {
                Console.Write("Enter X: ");
                X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Y: ");
                Y = Convert.ToDouble(Console.ReadLine());
                validInput = true; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }

    }

    public void Output()
    {
        Console.WriteLine($"Vector: {this}");
        Console.WriteLine($"Length of 2D Vector: {Length():F10}");
    }
}
