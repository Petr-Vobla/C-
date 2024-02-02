 using System;
class Program
{
    public static void Main(string[] args)
    {
        
        BaseArray[] array = new BaseArray[3];
        array[0] = new Array();
        array[1] = new Matrix();
        array[2] = new JaggedArray();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Операции для массива {i + 1}");
            array[i].Initialize();
            double average = array[i].GetAverage();
            Console.WriteLine($"Cреднее: {average}");
            array[i].PrintArray();
        }
        Array Array = new Array();
        Array.DeleteElementsBiggerThan100();
        Array.RemoveDuplicates();

        Matrix Matrix = new Matrix();
        Matrix.PrintArrayWithEvenReversedRows();

        JaggedArray JaggedArray = new JaggedArray();
        JaggedArray.GetAveragesInInnerArrays();
        JaggedArray.ChangeEvenElements();
    }
        
       
}