Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(num);

if(number.Length == 5)
{
     if(number[0] == number[4] && number[1] == number[3])
     {
         Console.Write($"Ваше число {num} полиндром!");
     }
     else Console.Write($"Ваше число {num} не полиндром!");
 }
else Console.WriteLine("Введите правильное число!"); 
