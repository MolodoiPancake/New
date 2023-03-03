int InputNumber(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}
int Akkerman(int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if (n == 0 && m > 0)
{
return Akkerman(m - 1, 1);
}
else
{
return Akkerman(m - 1, Akkerman(m, n - 1));
}
}

int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int AkkermanFunction = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {AkkermanFunction} ");
    
  
