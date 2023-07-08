// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//  Фуекции в которой сума будет считатся от меньшего числа к большему
int Sum(int number1, int number2)
{
    if (number1 == number2)
    {
        return number2;
    }
    else if (number1 < number2)
    {
        return number1 + Sum(number1 + 1, number2);
    }
    else
    {
        return number1 + Sum(number2 + 1, number1);
    }
}
Console.WriteLine("Введите натурально число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натурально число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Числа меньше 0 не натуральные");
}
else if (number1 == number2)
{
    Console.WriteLine("Считать нечего поскольку числа равны и промежуток отсутствуе");
}
else
{
    Console.WriteLine(Sum(number1, number2));
}



