
int FindMin ( int a, int b, int c, int d);
   int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
{
 
if (a <= b && a <=c && a<=d )
{
    return a;
}
if (b <= a && b <=c && b<=d )
{
    return b;
}
if (c <= a && c <=b && c<=d )
{
    return c;
}
else 
{
    return d;
}
}



 System.Console.WriteLine(FindMin);