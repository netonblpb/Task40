// В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

Console.Clear();

Random rnd = new Random();

Console.Write("На сколько элементов задаём массив? ");
int elem = int.Parse(Console.ReadLine());
int[] array = new int[elem];

for (int i = 0; i < elem; i++)
{
    array[i] = rnd.Next(1, 10);
    Console.Write(array[i] + "\t");
}

int min = array[0];
int max = array[0];
for (int j = 1; j < elem; j+=2)
{
    if (array[j] <= min) min = array[j];
    else if (array[j] >= max) max = array[j];
}
int result = max - min;

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом - {result}");