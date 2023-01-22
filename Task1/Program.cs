/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Введите трехзначное число:");
int GetNumber(int leftBound, int rightBound)
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int a = GetNumber (100, 1000);
int b = a % 100 *10 / 100;
Console.WriteLine( b);
