// Нахождение второго по счету числа в 3-хзначном 
System.Console.WriteLine("Число отрицательное(Да/Нет)?");
if (Console.ReadLine() == "Нет") 
{int number = ReadInt("Введите 3-хзначное число: ");
int count = number.ToString().Length;

if (count < 3 || count > 3)
{
Console.WriteLine("Число введенное Вами не является 3-хзначным");
}
else
{
Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}}
else
{int number = ReadInt("Введите 3-хзначное число со знаком - : ");
int count = number.ToString().Length;

if (count < 4 || count > 4)
{
Console.WriteLine("Число введенное Вами не является 3-хзначным");
}
else
{
Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}}