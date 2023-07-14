Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
String[] array = new string[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите значение {i+1}:");
    array[i] = Console.ReadLine();
}
Console.WriteLine($"Введенный массив: [{string.Join(", ", array)}]");