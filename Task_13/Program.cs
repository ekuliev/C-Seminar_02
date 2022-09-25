// Задача 13: выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int Digit = 0;
int ExtractDigit(int number)
{
    while (number >= 100)
    {
        Digit = number% 10;
        number = number/10;
    }
    return Digit;
}
if (number < 100)
{
    Console.WriteLine("3-й цифры нет");
}
else
{
ExtractDigit(number);
Console.WriteLine(Digit);
}
    