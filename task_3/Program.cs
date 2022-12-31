Console.Clear();
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int count = 1;

while(count < N)
{
int num = Convert.ToInt32(Math.Pow(count, 3));
Console.Write($"{num}, ");
count++;
}
Console.Write($"{Math.Pow(N, 3)}");