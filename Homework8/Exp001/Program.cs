// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
num = Math.Abs(num);
//int amount = num.ToString().Length;
// if (amount < 3 || amount > 3)
if (num > 999 || num < 100)
{
    Console.WriteLine("Введено не трехзначное число");
}
else
{
    int centrnum = (num / 10) % 10;
    Console.WriteLine(centrnum);
}
