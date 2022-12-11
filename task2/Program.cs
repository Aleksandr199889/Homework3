Console.Write("Введите xa");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите xb");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ya");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите yb");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите za");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите zb");
int zb = Convert.ToInt32(Console.ReadLine());
double x = Math.Pow((xb-xa), 2);
double y = Math.Pow((yb-ya), 2);
double z = Math.Pow((zb-za), 2);
double AB = Math.Sqrt(x + y + z);
Console.WriteLine(AB);
//do