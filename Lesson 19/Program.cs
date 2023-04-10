using Lesson_19;

Console.WriteLine();
Console.Write("Укажите количество строк массива: ");
int aal = Calculator.ReadFromConsoleAmountOfArraysLines(); //aal - amount of array's lines
Console.WriteLine();
Console.Write("Укажите количество столбцов массива: ");
int aac = Calculator.ReadFromConsoleAmountOfArraysColumns(); //aac - amount of array's columns
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Генерация элементов массива.");
int[,] array = Calculator.Generate(aal, aac);
Console.WriteLine();
Calculator.WriteTheEntireArray(array);
Console.WriteLine();
Console.WriteLine();

//1) Найти минимальный элемент массива.
Console.WriteLine("1. Нахождение минимального элемента массива.");
int min = Calculator.FindMinElementOfArray(array);
Calculator.WriteMinElementOfArray(min);
Console.WriteLine();

//2) Найти максимальный элемент массива.
Console.WriteLine("2. Нахождение максимального элемента массива.");
int max = Calculator.FindMaxElementOfArray(array);
Calculator.WriteMaxElementOfArray(max);
Console.WriteLine();

//3) Найти индекс минимального элемента массива.
Console.WriteLine("3. Нахождение индекса минимального элемента массива.");
string minIndex = Calculator.FindMinIndex(array);
Calculator.WriteMinIndexOfArray(minIndex);
Console.WriteLine();

//4) Найти индекс максимального элемента массива.
Console.WriteLine("4. Нахождение индекса максимального элемента массива.");
string maxIndex = Calculator.FindMaxIndex(array);
Calculator.WriteMaxIndexOfArray(maxIndex);
Console.WriteLine();

Calculator.WriteTheEntireArraySpreadsheet(array);
Console.WriteLine();
Console.WriteLine();

//5) Найти количество элементов массива, которые больше своих левого и нижнего соседа одновременно.
Console.WriteLine("5. Нахождение количества элементов массива, которые больше своих левого и нижнего соседа одновременно.");
Calculator.WriteIndex(array);
Console.WriteLine();
Calculator.WriteElements(array);
Console.WriteLine();
int quantity = Calculator.FindQuantity(array);
Console.WriteLine();
Calculator.WriteQuantity(quantity);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Конец!");