// Программа конвертации десятичного числа в двоичное.
// Используется массив для формирования двоичного числа.

int ReadNumber() // Ввод натурального числа.
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

int QuantityDigit(int number) // Определение количества разрядов двоичного числа.
{
    int count = 0;
    while(number > 0)
    {
        number /= 2;
        ++count;
    }
    return count;
}

int [] ConvertNumber(int number, int dig) // Заполнение массива двоичным числом.
{
    int [] binaryArray = new int [dig];
    for(int i = dig - 1; i >= 0; i--)
    {
        binaryArray[i] = number % 2;
        number /= 2;
    }
    return binaryArray;
}

void WriteArray(int [] array) // Вывод массива на экран.
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

// Тело программы.

int decNumber = ReadNumber();
Console.WriteLine(decNumber);
int digits = QuantityDigit(decNumber);
Console.WriteLine(digits);
int [] binNumber = ConvertNumber(decNumber, digits);
//int [] binNumber = ConvertNumber(3, 2);
Console.Write($"Десятичное число {decNumber} конвертировано в двоичное ");
WriteArray(binNumber);


