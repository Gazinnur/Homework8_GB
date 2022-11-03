// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int amount = num.ToString().Length;
if (amount < 3)
{
    Console.WriteLine("нет третьей цифры");
}
else
{ int c = 1;
    for (int i = amount; i > 3; i--)
    { c = c * 10; }
    int thirdnum = (num / c) % 10;
    Console.WriteLine(thirdnum);
}
