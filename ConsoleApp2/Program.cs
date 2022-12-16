string str;
Console.WriteLine("Як тебе звати?");
string mane = Console.ReadLine();
Console.WriteLine("Скажи своє Прізвище");
string lastname = Console.ReadLine();
Console.WriteLine("Скільки тобі років?");
str  = Console.ReadLine();
int a = Convert.ToInt32(str);
if (a == 18)
{
    Console.WriteLine("Повнолітній");

else if (a >= 18)
{
    Console.WriteLine("Повнолітній");
   
}
if (a < 18)
{
    
   Console.WriteLine ("Неповнолітній");

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
Console.WriteLine (mane  +  lastname);
Console.WriteLine(a);
Console.WriteLine("Разом витратив " + rezult);