// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 , 5 -> 120

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Факториал равен {FindProduce()}");

int FindProduce()
{
    int produce = 1;
    for (int i = 1; i <= number; i++)
    {
        produce = produce * i;
    }
    return produce;
}
