int n;
n=Convert.ToInt32(Console.ReadLine());
 int[] array =new int[n];
 for(int i=0;i<n;i++){
    array[i]=Convert.ToInt32(Console.ReadLine());
 }
 int min=999999,max=-999999;
  int cnt=1;
 for (int i = 0; i<n; i++) {
      if(max<array[i]) {
                max=i;
            }  
            if(min>array[i]){
                min=i;
            } 
  }
 for (int i = min; i<=max; i++) {
      System.Console.WriteLine(array[i]);
  }