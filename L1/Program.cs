// Методы
//void Insert(int a);
//{
//    Console.WriteLine("Вставить"+a);
//}

int CreateNumber()
{
    int number = new Random().Next(10,100);
    return number;
}

int MaxDigit(int number)
{
    int Decim = number/10;
    int Ed = number % 10;
    if (Decim >= Ed )
    {
        return Decim;
    }
    else
    {
        return Ed;
    }
}

int a = CreateNumber();
Console.WriteLine(a);
//int maxDigit = MaxDigit(a);
Console.WriteLine(MaxDigit(a));
