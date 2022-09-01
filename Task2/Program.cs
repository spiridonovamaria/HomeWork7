// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.



int[,] array = ArrayFill();
ArrayPrint(array);
int position = Prompt("Введите позицию элемента: ");
FindElement(array, position);


int Prompt(string message)    
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if (result < 1 && result > 40)
        throw new Exception("Такого числа в массиве нет");
    else
        return result;
}
int[,] ArrayFill()     
{
    System.Console.WriteLine("Двумерный массив чисел: ");
    int[,] array = new int[5, 8];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-25, 25);
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
void FindElement(int[,] array, int elementNumber)     
{
    int rows = elementNumber / 8;
    int columns = elementNumber % 8 - 1;

    System.Console.WriteLine($"На позиции {elementNumber} находится элемент {array[rows, columns]}");
}