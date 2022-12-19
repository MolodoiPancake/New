// Task 36
Console.Clear();
int[] Array = new int[5]; 
int count = 0;

{
for(int i = 0; i < 5; i++)
{
   Array[i] = new Random().Next(10,50);
}
Console.WriteLine($"{string.Join(",", Array)}");

for(int i = 1; i < 5; i+=2)
{ 
   
   count = count + Array[i];
}
}
Console.Write(count);