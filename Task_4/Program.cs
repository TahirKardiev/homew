double a, i = 1; string clir;
Console.WriteLine ("Enter a number "); clir = Console.ReadLine ();
a = double.Parse (clir);
while (i <= a)
 { 
   if(i % 2 == 0) 
   {
        Console.WriteLine(i);
   }
    i = i + 1;
 }