Console.Clear();
string[] ArrayStrings = new string[] { };
Console.Write("Введите количество элементов массива - строк:");
int n = int.Parse(Console.ReadLine());
ArrayStrings = new string[n];
for (int i = 0; i < ArrayStrings.Length; i++)
{
    Console.Write($" Введите {i + 1} строку: ");
    ArrayStrings[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("массив введенных данных:");
Console.WriteLine($"{PrintArray(ArrayStrings)}");
Console.WriteLine();

int length = 3;