//Программа, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

Console.Clear();

int number = new Random().Next(99,1000);

Console.WriteLine(number);

int firstDigit = number / 100;
int lastDigit = number % 10;

//Console.WriteLine($"{firstDigit}{lastDigit}");

//Console.WriteLine((firstDigit*10)+lastDigit);

Console.Write(firstDigit);
Console.Write(lastDigit); 