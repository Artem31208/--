string str;
Console.WriteLine("Як тебе звати?");
string mane = Console.ReadLine();
Console.WriteLine("Скажи своє Прізвище");
string lastname = Console.ReadLine();

Console.WriteLine("Якого ти року народження?");
str = Console.ReadLine();
int a = Convert.ToInt32(str);
if (a == 2004)
{
    Console.WriteLine(a == 2004);
}
else if (a >= 2004)
{
    Console.WriteLine(a >= 2004);
}
if (a < 2004)
{
    Console.WriteLine(a < 2004);
}
Console.WriteLine("Скільки ти витратив вчора?");
double e, d;
e = double.Parse(Console.ReadLine());
Console.WriteLine("Скільки ти витратив сьогодні?");
d = double.Parse(Console.ReadLine());
double rezult = e + d;
Console.WriteLine("Разом за два дні витратив = " + rezult);
Console.ReadLine();
Console.Clear();
Console.WriteLine("Твоє Імя і Призвіще?");
string name = Console.ReadLine();
Console.WriteLine("Якого ти року? Тобі є 18?");
str = Console.ReadLine();
int b = Convert.ToInt32(str);
if (b == 2004)
{
    Console.WriteLine(b == 2004);
    Console.WriteLine("Повнолітній");
}
else if (b <= 2004)
{
    Console.WriteLine(b <= 2004);
    Console.WriteLine("Повнолітній");
}
if (b > 2004)
{
    Console.WriteLine(b > 2004);
    Console.WriteLine("Не повнолітній");
}
Console.WriteLine("Разом за два дні витратив");