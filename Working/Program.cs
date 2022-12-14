Console.Clear();
int[] Array = new int[5]; 
int count = 0;

{
for(int i = 0; i < 5; i++)
{
   Array[i] = new Random().Next(100,1000);
}
Console.WriteLine($"{string.Join(",", Array)}");

for(int i = 0; i < 5; i++)
{ 
   if(Array[i] % 2 == 0)
   count++;
   
}
}
Console.Write(count);
// имя массива.Get.Length(0)
// имя массива.Get.Length(1)