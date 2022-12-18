// See https://aka.ms/new-console-template for more information

//Задача 2
Console.WriteLine("************  Задачаа № 2 ****************");

Console.WriteLine(" Введите число а:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число b:  ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($" a = {a}; b = {b}  -> max = {a}");
}
else
{
    Console.WriteLine($" a = {a}; b = {b}  -> max = {b}");
}

// Задача 4
Console.WriteLine("************  Задачаа № 4 ****************");
Console.WriteLine(" Введите число а:  ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число b:  ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число c:  ");
int c1 = Convert.ToInt32(Console.ReadLine());
if ((a1 > b1) & (a1 > c1))
{
    Console.WriteLine($" a = {a1}; b = {b1}; c = {c1}  -> max = {a1}");
}
else if ((b1 > c1) & (b1 > a1))
{
    Console.WriteLine($" a = {a1}; b = {b1}; c = {c1}  -> max = {b1}");
}
else
{
    Console.WriteLine($" a = {a1}; b = {b1}; c = {c1}  -> max = {c1}");
}

//Задача 6
Console.WriteLine("************  Задачаа № 6 ****************");

Console.WriteLine(" Введите число ЧИСЛО:  ");
int n = Convert.ToInt32(Console.ReadLine());
int val1 = n%2;
if (val1 ==0)
{
Console.WriteLine($" Чило {n} -> ДА");
}
else
{
    Console.WriteLine($" Чило {n} -> Нет");
}

//Задача 8
Console.WriteLine("************  Задачаа № 8 ****************");
Console.WriteLine(" Введите число ЧИСЛО  N:  ");
int N = Convert.ToInt32(Console.ReadLine());
int vall = 0;
int val2 =0;
string text1 = "";
for (int i = 1; i <= N; i++)
{
    val2 = i%2;
   
    if (val2 == 0)
    {
        vall =i;
        text1 = text1 + vall + ',';
    }
}

Console.WriteLine($" Чило {N} -> {text1}");
