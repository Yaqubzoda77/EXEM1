int n, Sum=0, cnt=1; 
n = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i<=n; i++)
{
    cnt= 1;
    for(int j = 1; j<=i; j++)
    {
        cnt = cnt*2;
    }
    Sum+=cnt;
}
System.Console.WriteLine(Sum);