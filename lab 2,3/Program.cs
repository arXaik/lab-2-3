//Петросян Араик 22-Исп-2/1 2.1
Console.WriteLine("Введите х");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вариант функции");
double variant = double.Parse(Console.ReadLine());
double a, b, z;
switch (variant)
{
    case 1:
        a = 0.1;
        b = 0.5;
        z = Math.Exp(2.5 * 0.1 * 0.5);
        break;
    case 2:
        a = 1.2;
        b = 2.5;
        z = Math.Exp(2.5 * 1.2 * 2.5);
        break;
    case 3:
        a = 2.5;
        b = 1.5;
        z = Math.Exp(2.5 * 2.5 * 1.5);
        break;
    default:
        a = 1;
        b = 1;
        z = 1;
        break;
}
if (x <= a)
{
    double y = 3.5 * Math.Pow(Math.Sin(Math.Pow((b * x + z), 3)), 2);
}
if (a < x && x  < Math.Pow(b, 2.5))
{
    double y = Math.Log10(a + b * b * b * x);
}
if (x >= Math.Pow(b, 2.5))
{
    double y = Math.Pow(Math.Cos(Math.Pow(a, b) + x * z), 2) + a * a;
}
Console.WriteLine();
