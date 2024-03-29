﻿ using System;
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
        Array _Array = new _Array();
        _Array.DeleteElementsBiggerThan100();
        _Array.RemoveDuplicates();

        Matrix _Matrix = new Matrix();
        _Matrix.PrintArrayWithEvenReversedRows();

        JaggedArray _JaggedArray = new JaggedArray();
        _JaggedArray.GetAveragesInInnerArrays();
        _JaggedArray.ChangeEvenElements();
    }
        
       
}
