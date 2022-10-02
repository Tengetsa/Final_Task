// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

void Task()
{
string[] array = new string[6] {"Hello", "12", "gir", "World", "123", "ver"};

PrintArray(array);
Console.WriteLine();
PrintReferenceArray(array);
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

void PrintReferenceArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]} ");
        }
    }
    Console.Write("]");
}

Task();
