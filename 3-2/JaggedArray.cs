public sealed class JaggedArray : BaseArray
{
    private int[][] array;

    public override void Initialize(bool fillByUser = false)
    {

        Console.WriteLine("Создание ступенчатого массива");
        Console.Write("Введите количество рядов: ");
        int rows = int.Parse(Console.ReadLine());
        array = new int[rows][];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите количество элементов в ряду: {i + 1}: ");
            int length = int.Parse(Console.ReadLine());
            array[i] = new int[length];

            if (fillByUser)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"Введите элемент {i + 1} под номером {j + 1}: ");
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Random random = new Random();

                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(1, 100);
                }
            }
        }
    }

    public override double GetAverage()
    {
        double sum = 0;
        int elementsCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                sum += array[i][j];
                elementsCount++;
            }
        }

        return sum / elementsCount;
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

    public override void PrintArray()
    {
        Console.WriteLine("Вывод ступенчатого массива:");
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
    
