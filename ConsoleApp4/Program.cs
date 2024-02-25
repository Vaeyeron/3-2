using System;
using System.Linq;

abstract class Array_Base
{
    protected int[] array;

    public abstract void Initialize();
    public abstract void Print();
    public abstract double Calculate_Average();
    public abstract void Remove_Elements_More_Than_Abs_100();
    public abstract void Remove_Duplicate_Elements();
}

sealed class One_Dimensional_Array : Array_Base
{
    public override void Initialize()
    {
        array = new int[length];
        if (user_Input)
        {
            Input_Array_From_User();
        }
        else
        {
            Fill_Array_With_Random_Values();
        }
    }

    private void Input_Array_From_User()
    {
        Console.WriteLine("Enter values for the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter value for index {i}: ");
            if (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                i--;
            }
        }
    }

    private void Fill_Array_With_Random_Values()
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 101);
        }
    }

    public void Print_Array()
    {
        Console.WriteLine("Array elements:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public override double Calculate_Average()
    {
        double sum = 0;
        foreach (var element in array)
        {
            sum += element;
        }
        return sum / array.Length;
    }

    public void Remove_Elements_Greater_Than_Abs_100()
    {
        array = Array.FindAll(array, x => Math.Abs(x) <= 100);
    }

    public override void Remove_Duplicate_Elements()
    {
        array = array.Distinct().ToArray();
    }
}

sealed class Multi_Dimensional_Array : Array_Base
{
    public override void Initialize()
    {
        array = new int[length];
        if (user_Input)
        {
            Input_Array_From_User();
        }
        else
        {
            Fill_Array_With_Random_Values();
        }
    }

    private void Input_Array_From_User()
    {
        Console.WriteLine("Enter values for the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter value for index {i}: ");
            if (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
                i--;
            }
        }
    }

    private void Fill_Array_With_Random_Values()
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 101);
        }
    }


    public override void Print()
    {
        Console.WriteLine("Array elements:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public override double Calculate_Average()
    {
        double sum = 0;
        foreach (var element in array)
        {
            sum += element;
        }
        return sum / array.Length;
    }

    public override void Remove_Elements_More_Than_Abs_100()
    {
        array = Array.FindAll(array, x => Math.Abs(x) <= 100);
    }

    public override void Remove_Duplicate_Elements()
    {
        array = array.Distinct().ToArray();
    }
}


sealed class Jagged_Array : Array_Base
{
    public override void Initialize()
    {
        {
            array = new int[length];
            if (user_Input)
            {
                Input_Array_From_User();
            }
            else
            {
                Fill_Array_With_Random_Values();
            }
        }

        private void Input_Array_From_User()
        {
            Console.WriteLine("Enter values for the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter value for index {i}: ");
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                    i--;
                }
            }
        }

        private void Fill_Array_With_Random_Values()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
            }
        }

    public override void Print()
    {
        Console.WriteLine("Array elements:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public override double CalculateAverage()
    {
        double sum = 0;
        foreach (var element in array)
        {
            sum += element;
        }
        return sum / array.Length;
    }

    public override void Remove_Elements_More_Than_Abs_100()
    {
        array = Array.FindAll(array, x => Math.Abs(x) <= 100);
    }

    public override void Remove_Duplicate_Elements()
    {
        array = array.Distinct().ToArray();
    }
}

class Program
{
    static void Main(string[] args)
    {

        Array_Base[] array = new Array_Base[3];
        array[0] = new One_Dimensional_Array();
        array[1] = new Multi_Dimensional_Array();
        array[2] = new Jagged_Array();

        foreach (var arr in array)
        {
            arr.Initialize();
            arr.Print();
            Console.WriteLine("Average: " + arr.Calculate_Average());
            arr.Remove_Elements_More_Than_Abs_100();
            arr.Remove_Duplicate_Elements();
        }
    }
}