int n   ,cnt=1;
n = Convert.ToInt32(Console.ReadLine());
int [] Anouther = new int[n];
for (int i = 0; i < n; i++)
{
Anouther[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
  if (Anouther[i] != Anouther[i+1] && Anouther[i] != Anouther[i-1] )
  {
    cnt++;
  }
  
}
System.Console.WriteLine(cnt);