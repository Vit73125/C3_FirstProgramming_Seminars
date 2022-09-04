//===================================================================================
// # 9 Напишите программу, которая выводит случайное число изи отрезка [10, 99]
// и показывает наибольшую цифру числа.
//===================================================================================

void MyVariant()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    // Вариант 1
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void EvgeniyVariant()
{
    // Вариант Евгения
     Console.WriteLine("Метод 2");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    Console.WriteLine(number);
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

void CharVariant()
{
    // Вариант char
    Console.WriteLine("Метод 3");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(number);
    Console.WriteLine(((int) charArray[0] > (int) charArray[1]) ? charArray[0] : charArray[1]);
}

MyVariant();

EvgeniyVariant();

CharVariant();