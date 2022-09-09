// Программа конвертации десятичного числа в двоичное.
// Используется строка для формирования двоичного числа.

int ReadNumber()
{
    Console.Write("Введите натуральное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    while (number < 0)
    {
        Console.Write("ОШИБКА!!! Число не может быть меньше нуля.");
        Console.Write("Введите натуральное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

string ConvertNumber(int number)
{
    string binaryStr = string.Empty;
    while(number > 0)
    {
        binaryStr = number % 2 + binaryStr;
        number /= 2;
    }
    return binaryStr;
}

// Тело прогрпммы.

int decNumber = ReadNumber();
string binNumber = ConvertNumber(decNumber);
Console.WriteLine($"Десятисное число {decNumber} конвертировано в двоичное: {binNumber}");
