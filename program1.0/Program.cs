// Нахождение второго по счету числа в трехзначном  
Console.WriteLine ("Введите 3-х значное число-");
int number, numberTwo;
number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <999)
{numberTwo = Convert.ToInt32(number/10%10);
Console.WriteLine($"Второе по счету число {numberTwo}");}
else
{
Console.WriteLine($"Необходимо ввести 3-х значное число"); 
}
