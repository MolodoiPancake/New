Console.Clear();
Console.Write("Введте первое число ");
int n = Convert.ToInt32(Console.ReadLine()); int i = 1, count = 0;
while(i < n + 1)
{
    count = count + n % 10;
    n = n / 10;

}
Console.WriteLine(count);