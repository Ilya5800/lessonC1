int n = Convert.ToInt32(Console.ReadLine());
int Summ()
{
    
    int sum = 0;
    while (n>0)
    {
        sum += n %10;
        n /=10;
    }
    return sum;
  
   
}
 System.Console.WriteLine(Summ());