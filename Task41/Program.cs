Console.Clear();
int[] n = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
foreach(int element in n )
{
    if(element > 0)
    count++;
}
Console.WriteLine(count);