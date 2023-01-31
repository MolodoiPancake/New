string[] FirstArray = new string[5] {"1234", "2", "hello", "world", ":3"};
string[] SecondArray = new string[FirstArray.Length];
void SecondArrayWithIF(string[] FirstArray, string[] array2)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
    if(FirstArray[i].Length <= 3)
        {
        SecondArray[count] = FirstArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Clear();
SecondArrayWithIF(FirstArray, SecondArray);
PrintArray(SecondArray);
