// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/

Console.WriteLine("Введите цифру:");
int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int c = GetNumber();
if (c < 6 && c > 0)
{
    Console.WriteLine("Нет");
}
if (c == 6 || c == 7)
{ 
    Console.WriteLine("Да");
}
if (c < 1 || c > 8)
{
    Console.WriteLine("Это не день недели");
}