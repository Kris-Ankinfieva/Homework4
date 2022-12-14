// Программa, которая задаёт массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8 */

Console.Clear();

int InputNumber(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine());
    return number;
}

void FillArray(int[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.Write(" ");
}

int number = InputNumber("Задайте количество элементов в массиве: ");
int[] myArray = new int[number];
FillArray(myArray);
PrintArray(myArray);