/* Задача:
Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры: 
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


int n = 4;
int size = 15;
string[] arrayOne = new string[size];
FillRandArray(arrayOne);

if (SizeSecondArray(arrayOne) == 0)
{
    Console.WriteLine("элементов для переноса в новый массив - нет");
}
else
{
    Console.Clear();
    Console.WriteLine($"Первоначальный массив, заполненный рандомными значениями и новый массив, включающий в себя значения из первоначального, равные или меньше 3-х символов");
    Console.WriteLine();
    string[] arrayTwo = NeedsElemArray(arrayOne);
    Console.WriteLine($"[{String.Join(", ", arrayOne)}] => [{String.Join(", ", arrayTwo)}]");
    Console.WriteLine();
}

void FillRandArray(string[] array)
{
    Random rand = new Random();
    string Symbols = "0123456789@#$%^&*()qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1, 8);
        for (int j = 0; j < randElemSize; j++)
        {
            array[i] += Symbols[rand.Next(0, Symbols.Length)];
        }
    }
}
int SizeSecondArray(string[] array)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length < n)
        {
            secondSize++;
        }
    }
    return secondSize;
}
string[] NeedsElemArray(string[] array)
{
    string[] arrayTwo = new string[SizeSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if (array[i].Length < n)
        {
            arrayTwo[j] = array[i];
            j++;
        }
    }
    return arrayTwo;
}
