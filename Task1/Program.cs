// написать программу которая из имеющегося массива строк
// формирует массив из строк, длинна которых меньше либо 
// равна 3 символам
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


using static System.Console;
Clear();

Write("Введите массив строк через пробел: ");
string[] array = ReadLine()!.Split(" ");

string[] result = Array2(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [\"{string.Join("\", \"", result)}\"]");

string[] Array2(string[] enter, int n) 
{
    string[] outs = new string[ArrayIndex(enter, n)];
    for(int i = 0, j = 0; i < enter.Length; i++)
    {
        if(enter[i].Length <= n) 
        {
            outs[j] = enter[i];
            j++;
        }
    }
    return outs;
}

int ArrayIndex(string[] enter, int n) 
{
    int count = 0;
    for(int i = 0; i < enter.Length; i++) 
    {
        if(enter[i].Length <= n) 
        {
            count++;
        }
    }
    return count;
}
