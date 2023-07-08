// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


double Akerman(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akerman(m - 1, 1);
    }
    else
    {
        return Akerman(m - 1, Akerman(m, n - 1));
    }
}

Console.WriteLine("Введите натурально число");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе натурально число");
double n = Convert.ToDouble(Console.ReadLine());

if (n < 0 || m < 0)
{
    Console.WriteLine("Вы ввели отрицательное число. Функция Акермана не принимает отрицательные числа");

}
else
{
    Console.WriteLine(Akerman(m, n));
}
