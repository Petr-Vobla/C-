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
            array[i] = random.Next(1, 100);
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
        int[] newArray = new int[array.Length];
        int newIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 100)
                if (array[i] > 100)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
        }
        Array.Resize(ref newArray, newIndex);
        array = newArray;
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