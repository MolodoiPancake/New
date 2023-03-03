Console.Clear();
Console.Write("Введите первое значение ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение ");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0 + n; i <= m; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);
