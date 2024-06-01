PrintResult(Check(Input()));


string[] Input()
{
    Console.WriteLine("Введите 5 случайных строк через (Пробел):");
    string[] arrayNumber = Console.ReadLine().Split(' ');
    return arrayNumber;
}


string[] Check(string[] arr)
{
    int counter = 0;
    foreach (string item in arr)
    {
        if (item.Length <= 3) counter++;
    }
    string[] NewArray = new string[counter];
    int counter2 = 0;
    for (int i = 0; i < 5; i++)
    {
        if (arr[i].Length <= 3)
        {
            NewArray[counter2] = arr[i];
            counter2++;
        }
    }
    return NewArray;
}


void PrintResult(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}
