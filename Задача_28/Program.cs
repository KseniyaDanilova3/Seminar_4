// Вытянуть по одной цифре все цифры из числа

// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine ()!); // 12345

// while (n > 0) // 2. n == 1234
// {
//    int digit = n % 10; // достать последнюю цифру
//    Console.WriteLine (digit);
//    n = n / 10; // оставить всё, кроме последней цифры
// }




// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3, 78 -> 2, 89126 -> 5

int CountDigits(int n) {
    int numberDisplay = n;
    int count = 0;

    while (n > 0) {
        int digit = n % 10;
        n = n / 10;
        count += 1;
    }
    return count;
}

Console.WriteLine("Введите число");
int numberToCount = int.Parse(Console.ReadLine());

Console.WriteLine($"В числе {numberToCount} {CountDigits(numberToCount)} цифр.");