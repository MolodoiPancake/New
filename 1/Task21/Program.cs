Console.Clear();
Console.Write("Ведите x ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите y ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите z ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите x1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());
double n = Math.Pow (x - x1, 2);
double b = Math.Pow (y - y1, 2);
double m = Math.Pow (z - z1, 2);

Console.WriteLine(Math. Sqrt (n + b + m));


