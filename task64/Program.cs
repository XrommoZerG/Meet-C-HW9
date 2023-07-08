// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Выводит вcе натуральные числа от N до 1

int Vuvod(int number)
{
    if (number == 1 || number == 0)
    {
        return 1;
    }
    else if (number < 0)
    {
        Console.WriteLine("Отрицательные числа не натуральные");
        return 0;
    }
    else
    {
        Console.Write($"{number};");
        return Vuvod(number - 1);
    }
}

Console.WriteLine("Введите натурально число число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Vuvod(number));





