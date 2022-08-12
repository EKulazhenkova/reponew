Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());
int a = 0;

while (true)
    if (a > N)
    {
        break
    }
if (a % 2 == 0)
{
    Console.WriteLine("четные числа");
    Console.Write(a);
}
int a = (a + 1);
