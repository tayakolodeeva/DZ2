// Нахождение является ли день недели (обозначенный цифрой от 1 до 7) выходным.
int number = ReadInt("Введите цифру от 1 до 7: ");
Console.WriteLine(dayOfTheWeek(number));
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
string dayOfTheWeek(int a)
{
if (a > 0 || a < 8)
{
if (a == 7 || a == 6)
{
Console.Write(a+ " - выходной ");
}
else
{
Console.Write(a+ " - рабочий");
}
}
else
{
Console.Write("Введенная цифра должна находиться в диапазоне от 1 до 7");
}
return " день.";
}
