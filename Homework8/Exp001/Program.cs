// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int amount = num.ToString().Length;
if (amount < 3 || amount > 3)
{
    Console.WriteLine("Введено не трехзначное число");
}
    else
 { int centrnum = (num / 10) % 10;
    Console.WriteLine(centrnum);
 }
