﻿// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

int a = 44;
int b = 5;
int c = 78;

if (a > b)
{
    //сдесь а больше б 
    if (a > c)
    {
        // а максимальное из трёх чисел
        Console.WriteLine("max = " + a);
    }
    else
    {
        //ц максимальное из трёх чисел
        Console.WriteLine("max = " + c);
    }
}
else
{
    //сдесь б больше а
    if (b > c)
    {
        // б максимальное из трёх чисел
         Console.WriteLine("max = " + b);
    }
    else 
    {
        // ц максимальное из трёх чисел
         Console.WriteLine("max = " + c);
    }
}


int max;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine("max = " + max);