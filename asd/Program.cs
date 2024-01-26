using System;

public class GenArray
{
    private int[] array;

    public GenArray(int length, bool fillByUser = false)
    {
        array = new int[length];

        if (fillByUser)
        {
            FillArrayByUser();
        }
        else
        {
            FillArrayByRandom();
        }
    }

    public void FillArrayByUser()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент под номером {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    public void FillArrayByRandom()
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100);
        }
    }

    public double GetAverage()
    {
        double sum = 0;

        foreach (int value in array)
        {
            sum += value;
        }

        return sum / array.Length;
    }

    public void DeleteElementsBiggerThan100()
    {
        array = Array.FindAll(array, x => Math.Abs(x) <= 100);
    }

    public void RemoveDuplicates()
    {
        int[] newArray = new int[array.Length];
        int newIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                newArray[newIndex] = array[i];
                newIndex++;
            }
        }
        Array.Resize(ref newArray, newIndex);
        array = newArray;
    }

    public void PrintArray()
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();
    }
}

public class GenMatrix
{
    private int[,] array;

    public GenMatrix(int rows, int columns, bool fillByUser = false)
    {
        array = new int[rows, columns];

        if (fillByUser)
        {
            FillArrayByUser();
        }
        else
        {
            FillArrayByRandom();
        }
    }

    public void FillArrayByUser()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"Введите элемент под номером [{i+1}, {j+1}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void FillArrayByRandom()
    {
        Random random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(100);
            }
        }
    }

    public double GetAverage()
    {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
        }

        return sum / (array.GetLength(0) * array.GetLength(1));
    }

    public void PrintArray()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public void PrintArrayWithEvenReversedRows()
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i % 2 == 1)
            {
                for (int j = array.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            else
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine();
        }
    }


    public class GenJaggedArray
    {
        private int[][] array;

        public GenJaggedArray(int[] lengths, bool fillByUser = false)
        {
            array = new int[lengths.Length][];

            if (fillByUser)
            {
                FillArrayByUser(lengths);
            }
            else
            {
                FillArrayByRandom(lengths);
            }
        }

        public void FillArrayByUser(int[] lengths)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[lengths[i]];

                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"Введите элемент под номером [{i + 1}, {j + 1}]:: ");
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void FillArrayByRandom(int[] lengths)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[lengths[i]];

                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(100);
                }
            }
        }

        public double GetAverage()
        {
            double sum = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    count++;
                }
            }

            return sum / count;
        }

        public double[] GetAveragesInInnerArrays()
        {
            double[] averages = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                double sum = 0;

                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }

                averages[i] = sum / array[i].Length;
            }

            return averages;
        }

        public void ChangeEvenElements()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
        }

        public void PrintArray()
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Array
            GenArray Array = new GenArray(10);
            Array.PrintArray();
            Console.WriteLine($"Среднее: {Array.GetAverage()}");
            Array.DeleteElementsBiggerThan100();
            Array.PrintArray();
            Array.RemoveDuplicates();
            Array.PrintArray();
            Console.WriteLine();

            // Matrix
            GenMatrix Matrix = new GenMatrix(3, 3);
            Matrix.PrintArray();
            Console.WriteLine($"Среднее: {Matrix.GetAverage()}");
            Matrix.PrintArrayWithEvenReversedRows();
            Console.WriteLine();

            // Jagged array
            int[] lengths = { 2, 3, 4 };
            GenJaggedArray jaggedArray = new GenJaggedArray(lengths);
            jaggedArray.PrintArray();
            Console.WriteLine($"Среднее: {jaggedArray.GetAverage()}");
            double[] averages = jaggedArray.GetAveragesInInnerArrays();

            for (int i = 0; i < averages.Length; i++)
            {
                Console.WriteLine($"Срднее по индексу {i}: {averages[i]}");
            }

            jaggedArray.ChangeEvenElements();
            jaggedArray.PrintArray();
        }
    }
}

