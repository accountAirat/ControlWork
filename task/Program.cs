int ElementCounting(string[] arr, int standard)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= standard)
            count++;
    }
    return count;
}
void FillNewArray(string[] arr, string[] newArr, int standard)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= standard)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
}

string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
int standardSize = 3;
string[] newArray = new string[ElementCounting(array, standardSize)];
FillNewArray(array, newArray, standardSize);
