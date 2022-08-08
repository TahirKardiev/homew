{
double a, b; string clir;
{
Console.Write("Введите число A : "); clir = Console.ReadLine();
a = double.Parse(clir);
Console.Write("Введите число B : "); clir = Console.ReadLine();
b = double.Parse(clir);
if (a > b)
{  
Console.WriteLine($"{a}");
}
else if (a < b)
{ 
Console.WriteLine($"{b}");
}
else
{ 
Console.WriteLine("the numbers are equal");
}
Console.Write("Нажмите любую клавишу ..."); Console.ReadKey(true);
}
}