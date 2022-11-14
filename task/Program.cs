int ElementCounting(string[] arr, int standard)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= standard)
        {
            Console.WriteLine(arr[i] + " " + arr[i].Length);
            count++;
        }
    }
    return count;
}

Console.Clear();
string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
int standardSize = 3;
Console.WriteLine(string.Join(", ", array));
Console.Write(ElementCounting(array, standardSize));
