int n = ReadInt("Введите количество элементов массива: ");
string[] firstArray = new string[n];

for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент: ");
    firstArray[i] = Console.ReadLine();
}

string[] secondArray = new string[firstArray.Length];

void Array(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

Array(firstArray, secondArray);
PrintArray(secondArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}