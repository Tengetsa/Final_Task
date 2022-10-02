// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

void Task()
{
    string[] array = new string[6] { "Hello", "12", "gir", "World", "123", "ver" };
    string[] array2 = new string[array.Length];

    PrintArray(array);
    Console.Write(" -> ");
    FillArray(array, array2);
    PrintArray(array2);
}

void FillArray(string[] array, string[] array2)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length <= 3)
        {
            array2[i] = array[i];
        }
    }
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

Task();
