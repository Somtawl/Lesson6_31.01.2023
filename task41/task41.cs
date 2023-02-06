Console.WriteLine("Введите любые целые числа");
int[] SomeArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int NumCount = 0;
for (int i = 0; i < SomeArray.Length; i++)
{
    if (SomeArray[i] > 0) NumCount = NumCount + 1;
}
Console.WriteLine("В массиве {0}, {1} чисел больше 0", String.Join(" ",SomeArray),NumCount);