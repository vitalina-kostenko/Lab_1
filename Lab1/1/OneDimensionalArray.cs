using System;
using System.Text;

public class OneDimensionalArray
{
    private int[] array;

    public OneDimensionalArray(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentException("Size must be greater than zero.");
        }
        array = new int[size];
    }

    public int this[int index] //одномірний індекатор
    {
        get => (index >= 0 && index < array.Length) ? array[index] : throw new IndexOutOfRangeException("Index is out of range.");
        set => array[index >= 0 && index < array.Length ? index : throw new IndexOutOfRangeException("Index is out of range.")] = value;
    }

    public void InputElements()
    {
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < array.Length; i++)
            array[i] = int.Parse(Console.ReadLine());
    }

    public void OutputElements()
    {
        Console.WriteLine("Array elements: " + string.Join(" ", array));
    }

    //public int FindMax()
    //{
    //    if (array.Length == 0) throw new InvalidOperationException("Array is empty.");
    //    int max = array[0];
    //    for (int i = 1; i < array.Length; i++)
    //    {
    //        if (array[i] > max)
    //        {
    //            max = array[i];
    //        }
    //    }
    //    return max;
    //}
    public int FindMax() => array.Length == 0 ? throw new InvalidOperationException("Array is empty.") : array.Max();

    //public int FindMin()
    //{
    //    if (array.Length == 0) throw new InvalidOperationException("Array is empty.");
    //    int min = array[0];
    //    for (int i = 1; i < array.Length; i++)
    //    {
    //        if (array[i] < min)
    //        {
    //            min = array[i];
    //        }
    //    }
    //    return min;
    //}
    public int FindMin() => array.Length == 0 ? throw new InvalidOperationException("Array is empty.") : array.Min();
}


class ArrayOperationsExample
{
    public static void Task1()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        OneDimensionalArray array = new OneDimensionalArray(size);

        array.InputElements();
        array.OutputElements();

        Console.WriteLine("Maximum element: " + array.FindMax());
        Console.WriteLine("Minimum element: " + array.FindMin());
    }
}

