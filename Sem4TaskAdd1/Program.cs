//===================================================================================
// # * Напишите программу, которая из имён через запятую выберет случайное
// имя и выведет в терминал
//===================================================================================

string namesString = ReadData("Введите имена через запятую:");
string[] names = ParseNames(namesString);
PrintResult(getAnyName(names));

// Ввод: строка
string ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    string inString = Console.ReadLine() ?? "0";
    // Возвращаем значение
    return inString;
}

string[] ParseNames(string namesString)
{
    char[] sym = { ',', ' ' };
    return namesString.Split(sym, StringSplitOptions.RemoveEmptyEntries);
}

string getAnyName(string[] names)
{
    Random rnd = new Random();
    return names[rnd.Next(0, names.Length)];
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}