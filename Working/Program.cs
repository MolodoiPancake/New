

int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);
double count = 0;
double average = 0;



    Console.WriteLine(count);

PrintArray(count);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-10, 11);
            }   
        }
}

void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write((count + j));
        {

            average = count /  array.GetLength(1);
        }
            
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
