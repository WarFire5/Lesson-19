namespace Lesson_19
{
    internal static class Calculator
    {
        public static int ReadFromConsoleAmountOfArraysLines()
        {
            int aal = Convert.ToInt32(Console.ReadLine()); //aal - amount of array's lines
            if (aal <= 0)
            {
                while (aal <= 0)
                {
                    Console.WriteLine(";");
                    Console.Write("Число строк масива должно быть больше 0. Задайте корректное значение: ");
                    aal = Convert.ToInt32(Console.ReadLine());
                }
            }
            return aal;
        }
        public static int ReadFromConsoleAmountOfArraysColumns()
        {
            int aaс = Convert.ToInt32(Console.ReadLine()); //aac - amount of array's columns
            if (aaс <= 0)
            {
                while (aaс <= 0)
                {
                    Console.WriteLine(";");
                    Console.Write("Число столбцов масива должно быть больше 0. Задайте корректное значение: ");
                    aaс = Convert.ToInt32(Console.ReadLine());
                }
            }
            return aaс;
        }
        public static int[,] Generate(int aal, int aac)
        {
            Random r = new Random();
            int[,] array = new int[aal, aac];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(-1000, 1000);
                }
            }
            return array;
        }
        public static void WriteTheEntireArray(int[,] array)
        {
            Console.WriteLine();
            Console.WriteLine($"Массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Элементу в ячейке '{i} {j}' ");
                    Console.Write($"соответствует значение '{array[i, j]}';");
                    Console.WriteLine();
                }
            }
        }
        public static void WriteTheEntireArraySpreadsheet(int[,] array)
        {
            Console.WriteLine();
            Console.WriteLine($"Массив в виде таблицы:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}; ");
                }
                Console.WriteLine();
            }
        }

        //1) Найти минимальный элемент массива.
        public static int FindMinElementOfArray(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
        public static void WriteMinElementOfArray(int min)
        {
            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент массива: {min}.");
            Console.WriteLine();
        }

        //2) Найти максимальный элемент массива.
        public static int FindMaxElementOfArray(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
        public static void WriteMaxElementOfArray(int max)
        {
            Console.WriteLine();
            Console.WriteLine($"Максимальный элемент массива: {max}.");
            Console.WriteLine();
        }

        //3) Найти индекс минимального элемента массива.
        public static string FindMinIndex(int[,] array)
        {
            string minIndex = "";
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] <= min)
                    {
                        min = array[i, j];
                        minIndex = ($"i = {i}, j = {j}");
                    }
                }
            }
            return minIndex;
        }
        public static void WriteMinIndexOfArray(string minIndex)
        {
            Console.WriteLine();
            Console.WriteLine($"Координаты минимального элемента массива: {minIndex}.");
            Console.WriteLine();
        }

        //4) Найти индекс максимального элемента массива.
        public static string FindMaxIndex(int[,] array)
        {
            string maxIndex = "";
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max <= array[i, j])
                    {
                        max = array[i, j];
                        maxIndex = ($"i = {i}, j = {j}");
                    }
                }
            }
            return maxIndex;
        }
        public static void WriteMaxIndexOfArray(string maxIndex)
        {
            Console.WriteLine();
            Console.WriteLine($"Координаты максимального элемента массива: {maxIndex}.");
            Console.WriteLine();
        }

        //5) Найти количество элементов массива, которые больше своих левого и нижнего соседа одновременно.
        public static void WriteIndex(int[,] array)
        {
            Console.WriteLine();
            Console.WriteLine($"Индексы элементов массива, больших левого и нижнего соседей одновременно:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[i - 1, j]) && (i >= array.GetLength(0) - 1 || array[i, j] > array[i + 1, j]) && (j == 0 || array[i, j] > array[i, j - 1]) && (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j + 1]))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"i = {i}, j = {j};");
                    }
                }
            }
        }
        public static void WriteElements(int[,] array)
        {
            Console.WriteLine();
            Console.WriteLine($"Элементы массива, большие своих левого и нижнего соседей одновременно:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[i - 1, j]) && (i >= array.GetLength(0) - 1 || array[i, j] > array[i + 1, j]) && (j == 0 || array[i, j] > array[i, j - 1]) && (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j + 1]))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{array[i, j]};");
                    }
                }
            }
        }
        public static int FindQuantity(int[,] array)
        {
            int quantity = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[i - 1, j]) && (i >= array.GetLength(0) - 1 || array[i, j] > array[i + 1, j]) && (j == 0 || array[i, j] > array[i, j - 1]) && (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j + 1]))
                    {
                        quantity++;
                    }
                }
            }
            return quantity;
        }
        public static void WriteQuantity(int quantity)
        {
            Console.WriteLine($"Количество элементов массива, которые больше своих левого и нижнего соседа одновременно: {quantity}.");
            Console.WriteLine();
        }
    }
}
