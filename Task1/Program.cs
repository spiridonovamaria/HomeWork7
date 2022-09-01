// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.



double[,] array = ArrayFill(Prompt("Введите количество строк массива от 1 до 10: "), Prompt("Введите количество столбцов массива от 1 до 10: "));
ArrayPrint(array);



int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if (result < 1 && result > 10)
        throw new Exception("Необходимо число от 1 до 10");
    else
        return result;
}
double[,] ArrayFill(int rows, int columns)
{
    System.Console.WriteLine("Двумерный массив чисел: ");
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    Random rnd2 = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round((rnd.NextSingle() * (rnd2.Next(-25, 25))), 2);
        }
    }
    return array;
}
void ArrayPrint(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            NicePicture(i, j);
        }
        System.Console.WriteLine();
    }
}
int GetDecimalDigitCount(double element)
{
    string[] str = element.ToString().Split(",");
    return str.Length == 2 ? str[1].Length : 0;
}
void NicePicture(int i, int j)
{
    if (array[i, j] < 0)
    {
        if (array[i, j] % 100 <= -10)
        {
            if (GetDecimalDigitCount(array[i, j]) == 2)
            {
                System.Console.Write(array[i, j] + " ");
            }
            else
            {
                System.Console.Write(array[i, j] + "  ");
            }
        }
        else
        {
            if (GetDecimalDigitCount(array[i, j]) == 2)
            {
                System.Console.Write(" " + array[i, j] + " ");
            }
            else
            {
                System.Console.Write(" " + array[i, j] + "  ");
            }
        }
    }
    else if (Convert.ToInt32(array[i, j]) == array[i, j])
    {
        System.Console.Write("  " + array[i, j] + "    ");
    }
    else
    {
        if (array[i, j] % 100 >= 10)
        {
            if (GetDecimalDigitCount(array[i, j]) == 2)
            {
                System.Console.Write(" " + array[i, j] + " ");
            }
            else
            {
                System.Console.Write(" " + array[i, j] + "  ");
            }
        }
        else
        {
            if (GetDecimalDigitCount(array[i, j]) == 2)
            {
                System.Console.Write("  " + array[i, j] + " ");
            }
            else
            {
                System.Console.Write("  " + array[i, j] + "  ");
            }
        }
    }
}