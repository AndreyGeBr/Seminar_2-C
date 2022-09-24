//Программа, которая будет принимать на вход два чила и выводить, является ли второе число кратным первому. 
//Если второе число не кратно первому числу, то программа выводит остаток от деления

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int remainder = number1 % number2;

if (remainder == 0)
{
    Console.WriteLine("Второе число кратно первому числу");
}
else
{
    Console.WriteLine($"Остаток равен {remainder}");
}

