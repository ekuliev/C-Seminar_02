// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа
// Инициализация переменных и ввод
Console.WriteLine("Введите 3-х значное число: ");
int number = int.Parse(Console.ReadLine());
int Digit;
int ExtractDigits(int number)
{
    Digit = number% 100;
    return Digit;

}
if (number >= 100 & number < 1000)
{
    ExtractDigits(number);
    Console.WriteLine(Digit/10);
}
else
{
    Console.WriteLine("Некорректное значение");
}