
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
