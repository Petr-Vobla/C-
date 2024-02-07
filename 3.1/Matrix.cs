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
                Console.Write($"������� ������� ��� ������� [{i + 1}, {j + 1}]: ");
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
            for (int j = 0; j < array.GetLength(1); j++)
            {   int IndexColumn;

                if (i % 2 == 1)
                {
                    IndexColumn =  array.GetLength(1) - 1 - j;
                }
                else
                {
                    IndexColumn = j
                }
                Console.Write(array[i, IndexColumn] + " ");

            }

            Console.WriteLine();
        }
    }
}