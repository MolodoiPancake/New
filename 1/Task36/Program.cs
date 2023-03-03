// Task 36
Console.Clear();
Console.Write("");
int n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n]; 
int count = 0;

{
for(int i = 0; i < Array.Length; i++)
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