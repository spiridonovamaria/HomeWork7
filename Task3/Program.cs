// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = ArrayFill();
ArrayPrint(array);
double[] res = AverageOfEachColumn(array);
ResultPrint(res);


int[,] ArrayFill()      
{
    System.Console.WriteLine("Двумерный массив чисел: ");
    int[,] array = new int[6, 7];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}
void ArrayPrint(int[,] array)       
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0)
            {
                if (array[i, j] % 100 > 9)
                {
                    System.Console.Write(" " + array[i, j] + " ");
                }
                else
                {
                    System.Console.Write("  " + array[i, j] + " ");
                }
            }
            else
            {
                if (array[i, j] % 100 <= -10)
                {
                    System.Console.Write(array[i, j] + " ");
                }
                else
                {
                    System.Console.Write(" " + array[i, j] + " ");
                }
            }
        }
        System.Console.WriteLine();
    }
}
double[] AverageOfEachColumn(int[,] array)      
{
    double[] result = new double[7];
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        sum/= result.Length;
        result[i] = Math.Round(sum, 2);
        sum = 0;
    }

    return result;
}
void ResultPrint(double[] array)    
{
    System.Console.WriteLine("____________________________________________________________");
    System.Console.WriteLine("Среднее арифметическое для каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
