﻿// 
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
void Module( int a, int b)
{
    if (b % a == 0)
{ 
    Console.WriteLine("Первое число кратно второму ");
}
else
{
    Console.WriteLine("Первое число не кратно второму ");
    Console.WriteLine("Остаток от деления равен " + (b % a));
}

}
Module(a, b);
