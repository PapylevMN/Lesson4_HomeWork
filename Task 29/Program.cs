int [] enterarrayrandom(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int [] enterarrayman(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i} элемент массива :");
        array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}

void printarray(int [] array, int num)
{
    for (int i = 0; i < num-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[num-1]);
}

Console.Write("Введите размерность массива :");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Для заполнения массив вручную - Нажмите '1'");
Console.WriteLine("Или любую клавишу для заполнения случайными числами");
string choice = Console.ReadLine();
int [] array;
if (choice == "1") 
{
    array = enterarrayman(n);
}
else
{
    array = enterarrayrandom(n);
}
printarray(array, n);


