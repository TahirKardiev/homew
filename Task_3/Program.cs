string clir; double a;
Console.WriteLine ("Enter a number "); clir = Console.ReadLine();
a = double.Parse(clir);
if (a % 2 == 1)
{
    Console.WriteLine ("odd");
}
else
{
    Console.WriteLine ("even");
}
