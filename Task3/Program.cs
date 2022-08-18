Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 0;

Console.Write("Кубы: ");

while(a < N)
{
    b = Convert.ToInt32(Math.Pow(a, 3));
    Console.Write(b + ", ");
    a++;

    if(a == N)
    { 
      b = Convert.ToInt32(Math.Pow(a, 3));
      Console.Write(b);
    }
}    
