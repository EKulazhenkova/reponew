Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());
int index = 0;
int[] numbers = {1:N}

while (index < N)
{
    if (numbers[index] % 2 == 0)  
    
    Console.WriteLine("четное число");
    Console.Write(numbers[index]);
  
}
index = (index + 1);
