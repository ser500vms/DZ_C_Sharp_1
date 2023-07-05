// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Четными числами являются: "); 
for (int i = 1; i <= number - 2; i++)
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }

if(number % 2 == 0)
{
    Console.Write(number);
}                                         //Костыль чтобы убрать запятую при выводе в терминале (Как сделать по другому не разобрался)
else
{
    Console.Write($"{number - 1} ");
}