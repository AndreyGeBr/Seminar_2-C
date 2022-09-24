// Программа, которая принимает на вход число и проверяет, кратно ли он одновременно 7 и 23
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0)
{
    if (number % 23 == 0)
    {
        Console.WriteLine("Число одновременно кратно 7 и 23");
    }
    else 
    {
        Console.WriteLine("Число не кратно");
    }    
}
else 
    {
        Console.WriteLine("Число не кратно");
    }
    
