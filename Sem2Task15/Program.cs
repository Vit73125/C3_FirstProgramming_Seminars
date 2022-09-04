//===================================================================================
// # 15 Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
//===================================================================================

int weekDayNum = 0;
string weekDay = "";
Boolean result = false;

ReadData();
CalculateData();
PrintData();

// Ввод данных: ввести трёхзначное число
void ReadData()
{
    Console.Write("Введите число, обозначающее день недели (от 1 - Пн до 7 - Вс): ");
    string? inputLine = Console.ReadLine();
    if (inputLine != null) weekDayNum = int.Parse(inputLine);
}

// Вычисление: определяем 
void CalculateData()
{
    switch (weekDayNum)
    {
        case 1: weekDay = "Понедельник"; break;
        case 2: weekDay = "Вторник"; break;
        case 3: weekDay = "Среда"; break;
        case 4: weekDay = "Четверг"; break;
        case 5: weekDay = "Пятница"; break;
        case 6: weekDay = "Суббота"; result = true; break;
        case 7: weekDay = "Воскресенье"; result = true; break;
        default: weekDay = "Такого дня нет"; break;
    }
}

// Выводим результат на консоль
void PrintData() {
    Console.WriteLine(weekDay + (result ? " - выходной": ""));
}