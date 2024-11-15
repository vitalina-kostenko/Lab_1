using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramClient
{
    public static void Task2()
    {
        Console.WriteLine("Enter values for 2D Vector:");
        TVector2D vector2D = new TVector2D();
        vector2D.Input();
        vector2D.Output();
        Console.WriteLine("Length of 2D Vector: " + vector2D.Length());
        vector2D.Normalize();
        Console.WriteLine("Normalized 2D Vector: " + vector2D);
        Console.WriteLine();

        Console.WriteLine("Enter the value of the second vector for 2D Vector:");
        TVector2D vector2D2 = new TVector2D();
        vector2D2.Input();
        vector2D2.Output();
        Console.WriteLine($"Vector 2D: {vector2D2}");
        Console.WriteLine("Addition: " + (vector2D + vector2D2));
        Console.WriteLine("Subtraction: " + (vector2D - vector2D2));
        Console.WriteLine("Dot Product: " + (vector2D * vector2D2));
        Console.WriteLine("Equality Check: " + (vector2D == vector2D2));

        Console.WriteLine("Enter values for 3D Vector:");
        TVector3D vector3D = new TVector3D();
        vector3D.Input();
        vector3D.Output();
        Console.WriteLine("Length of 3D Vector: " + vector3D.Length());
        vector3D.Normalize();
        Console.WriteLine("Normalized 3D Vector: " + vector3D);
        Console.WriteLine();

        Console.WriteLine("Enter values of the second vector for 3D Vector:");
        TVector3D vector3D2 = new TVector3D();
        vector3D2.Input();
        vector3D2.Output();
        Console.WriteLine($"Vector 3D: {vector3D}");
        Console.WriteLine("Addition: " + (vector3D + vector3D2));
        Console.WriteLine("Subtraction: " + (vector3D - vector3D2));
        Console.WriteLine("Dot Product: " + (vector3D * vector3D2));
        Console.WriteLine("Equality Check: " + (vector3D == vector3D2));
    }
}

