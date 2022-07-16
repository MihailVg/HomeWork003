// Задача N2, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты x, y и z, обозначающие первую точку: ");
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double z = double.Parse(Console.ReadLine());

Console.Write("Введите координаты x1, y1 и z1, обозначающие вторую точку: ");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());

double numberA = x - x1;
double numberB = y - y1;
double numberC = z - z1;

double Distance = Math.Sqrt(numberA * numberA + numberB * numberB + numberC * numberC);

Console.WriteLine("Расстояние между точками равно: " + Distance);
