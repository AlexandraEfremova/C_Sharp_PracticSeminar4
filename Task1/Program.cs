// Напишите программу, которая бесконечно запрашивает целые
// числа с консоли. Программа завершается при вводе символа 
// ‘q’ или при вводе числа, сумма цифр которого чётная.
using System.Globalization;

void Main()
{
    // Создаём бесконечный цикл, который будет продолжаться до тех пор, пока мы не выйдем из него при помощи return
    while(true)
    {
        // 
        System.Console.WriteLine("Введите целое трёхзначное число или \n введите 'q' для выхода из цикла");
        string value = Console.ReadLine();
        if(value.ToLower() == "q")
        {
            System.Console.WriteLine("Вы ввели 'q' - программа завершена");
            return;
        }
        if(int.TryParse(value, out int value2))
        {
            if(IsSumEven(value2))
            {
                System.Console.WriteLine($"Сумма числа {value2} чётная. Завершаем программу");
                return;
            }
            else
            {
                System.Console.WriteLine($"Сумма числа {value2} нечётная, продолжаем цикл");
            }
        }
        else
        {
            System.Console.WriteLine("Вы ввели не корректное значение");
        }
    }


bool IsSumEven(int number)
{
    int sumNumber = 0;
    while(number > 0)
    {
        sumNumber = sumNumber + number % 10;
        number = number / 10;
    }
    return sumNumber % 2 == 0;
}
}

Main();
