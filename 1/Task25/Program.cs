Console.Clear();
Console.Write("Введте первое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введте второе число ");
int m = Convert.ToInt32(Console.ReadLine()), count = n;

for(int i = 1; i < m; i++)
{   
    n = n * count;
    
}
Console.WriteLine(n);