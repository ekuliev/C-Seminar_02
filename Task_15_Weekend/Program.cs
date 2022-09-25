// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

bool Weekend (int number)
{
    if (number == 6 | number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

if (number < 1 | number > 7) Console.WriteLine("Неверный день");
else
{
    if (Weekend (number)) Console.WriteLine("Выходной");
    else
    {
        Console.WriteLine("Рабочий");
    }
}