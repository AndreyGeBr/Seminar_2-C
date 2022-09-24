//Программа, которая будет принимать на вход два чиcла и выводить, является ли первое число кратным второму. 
//Если первое число не кратно второму числу, то программа выводит остаток от деления

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int remainder = number1 % number2;

if (remainder == 0)
{
    Console.WriteLine("Первое число кратно второму числу");
}
else
{
    Console.WriteLine($"Остаток равен {remainder}");
}

