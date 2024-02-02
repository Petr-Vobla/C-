public sealed class Array : BaseArray
{
    public int[] array;

    public override void Initialize(bool fillByUser = false)
    {
        Console.WriteLine("Создание одномерного массива:");
        Console.Write("Введите длину массива:");
        int length = int.Parse(Console.ReadLine());
        array = new int[length];

        if (fillByUser)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент под номером: {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        else
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
        }
    }
    public override void PrintArray()
    {
        Console.WriteLine("Вывод одномерного массива:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();
    }

    public override double GetAverage()
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
        int Index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 100)
            {
                if (array[i] > 100)
                {
                    Index += 1;
                }
            }
        }
        int[] newArray = new int[Index];

        int NewIndex = 0;

        foreach (int num in array)
        {
            if (num >= -100 && num <= 100)
            {
                newArray[NewIndex] = num;
                NewIndex += 1;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }



    public int[] RemoveDuplicates()
    {
        int calc = 0;

        int[] ArrayWithOutDublicates = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            ArrayWithOutDublicates[i] = int.MinValue;
        }
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < ArrayWithOutDublicates.Length; j++)
                if (ArrayWithOutDublicates[j] != ArrayWithOutDublicates[i])
                {
                    ArrayWithOutDublicates[calc] = array[i];
                    calc++;
                }
        }
        int[] NewArrayWithOutDublicates = new int[calc];
        for (int i = 0; i < NewArrayWithOutDublicates.Length; i++)
        {
            NewArrayWithOutDublicates[i] = ArrayWithOutDublicates[i];
        }
        return NewArrayWithOutDublicates;


    }
}