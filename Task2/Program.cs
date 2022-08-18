// Кажись понял, но не идеально...

// Console.WriteLine("Введи х первой точки");
// string x = Convert.ToInt32.ReadLine();
// Понял, вроде, но не доделал. Отвлекли...

// Console.WriteLine("Введи y первой точки");

// Console.WriteLine("Введи z первой точки");
// Console.WriteLine("Введи х второй точки");
// Console.WriteLine("Введи y второй точки");
// Console.WriteLine("Введи z второй точки");

int x1 = Coord("x", "A");
int y1 = Coord("y", "A");
int z1 = Coord("z", "A");
int x2 = Coord("x", "Б");
int y2 = Coord("y", "Б");
int z2 = Coord("z", "Б");

int Coord(string adress, string Name)
{
    Console.Write($"Введите координату {adress} точки {Name}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double length = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));

Console.WriteLine("Длина отрезка " + "{0:0.00}", length);
