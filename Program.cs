Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
String[] array = new string[n];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите значение {i+1}: ");
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3) count++;
}
Console.WriteLine($"Введенный массив: [{string.Join(", ", array)}]");
String[] array1 = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array1[j] = array[i];
        j++;
    }
}
Console.WriteLine($"Новый массив: [{string.Join(", ", array1)}]");