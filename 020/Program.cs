//

int Part(double x, double y)
{

//int part =0;

if (x>0 && y>0) return 1;
if (x>0 && y<0) return 2;
if (x<0 && y<0) return 3;
if (x<0 && y>0) return 4;
 return 0;


}

void Pause()
{
    System.Console.WriteLine("Press any Key");
    Console.ReadKey();
}

Pause();
double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
Part(x,y);
System.Console.WriteLine("Part:"+Part(x,y));

