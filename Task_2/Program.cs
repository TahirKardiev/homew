{
double a, b, c; string clir; double max; 
{
Console.Write("Введите число A : "); clir = Console.ReadLine();
a = double.Parse(clir);
Console.Write("Введите число B : "); clir = Console.ReadLine();
b = double.Parse(clir);
Console.Write("Введите число C : "); clir = Console.ReadLine();
c = double.Parse(clir);
if (a >= b)
 {
    if (c >= a)
    {
       max = c;
    }
    else
    {
       max = a;
    }
 }
 else
 {
    if (c >= b)
    {
       max = c;
    }
    else
    {
       max = b;
    }
 }
Console.WriteLine($" {max} "); 
}
Console.Write("Нажмите любую клавишу ..."); Console.ReadKey(true);
}