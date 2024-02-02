public sealed class Matrix : BaseArray
{
    private int[,] array;

    public override void Initialize(bool fillByUser = false)
    {
        Console.WriteLine("Создание матрицы:");
        Console.Write("Введите количество рядов: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество строчек: ");
        int columns = int.Parse(Console.ReadLine());
        array = new int[rows, columns];

        if (fillByUser)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Введите элемент под номером: [{i + 1}, {j + 1}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        else
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }
        }
    }
    public override void PrintArray()
    {
        Console.WriteLine("Вывод матрицы:");
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

    public override double GetAverage()
    {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
        }

        return sum / array.Length;
    }
}