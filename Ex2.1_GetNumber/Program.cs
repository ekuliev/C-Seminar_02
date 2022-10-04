// 
int Getnumber()
{
    Console.WriteLine("Insert number: ");
int a = Convert.ToInt32(Console.ReadLine());
}

bool CheckMod(int a, int mod)
{
    return (a % mod == 0);
}

int a = Getnumber();
if (CheckMod(int.MaxValue a)
//Console.WriteLine("Insert number: ");
//int a = Convert.ToInt32(Console.ReadLine());


bool result;
bool del7 = (a %7 == 0);
bool del23 = (a %23 == 0);
result = (del7 && del23);

if (result)
{
    Console.WriteLine("Ridht!");
}