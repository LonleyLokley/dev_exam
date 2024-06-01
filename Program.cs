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
            System.Console.WriteLine(counter2);
            NewArray[counter2] = arr[i];
            counter2++;
        }
    }
    return arr;
}




