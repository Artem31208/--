string str;
Console.WriteLine("Скільки тобі років?");
str = Console.ReadLine();
int a = Convert.ToInt32(str);
if (a == 18)
{
    Console.WriteLine(a == 18);
}
else if (a >= 18)
{
    Console.WriteLine(a>=18);
}
if (a<18)
{
    Console.WriteLine("Малолетка");
}