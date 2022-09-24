// Программа, которая принимает на вход два числа и проверяет, является ли одно квадратом другого
Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 / number2 == number2)
{
    Console.WriteLine("Число один является квадратом числа два");
}
else if (number2 / number1 == number1)
{
    Console.WriteLine("Число два является квадратом числа один");
}
    else
{
    Console.WriteLine("Числа не является квадратами друг друга");
}