// Нахождение 3 по счету цифры числа, сообщить если третьей цифры нет.  
System.Console.WriteLine("Число отрицательное(Да/Нет)?");
if (Console.ReadLine() == "Нет")
{
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
{
Console.Write("Число введенное Вами содержит только 2 цифры, результат - ");
}
    else
    {
    int c = 1;
    for (int i = b; i > 3; i--)
     {
       c = c * 10;
     }

        result = (a / c) % 10;
    }
return result;
}}
else 
{
int number = ReadInt("Введите число со знаком - : ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 4)
    {
        Console.Write("Число введенное Вами содержит только 2 цифры, результат - ");
    }
else
    {
    int c = 1;
    for (int i = b; i > 4; i--)
    {
     c = c * 10;
    }

        result = (a / c) % 10;
    }
return result;
}}