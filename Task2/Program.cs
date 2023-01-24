/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число:");
int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int a = GetNumber ();
if (a / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет"); 
}
else
{
    while (a > 999)
    {
        a = a /10;
    }
    a = a % 10;
    Console.WriteLine( a );
}

