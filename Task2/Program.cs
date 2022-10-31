// Программуa, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12 */

int SumDigits(int num)
{
    if (num < 0)
    {
        num = -num;
    }
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int SumDig = SumDigits(a);
System.Console.WriteLine($"Сумма чисел заданного Вами значения {a}, равна {SumDig}");