// ["hello", "2", "world", ":-)"]-> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] ->[]
string[] NewArr(  string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
            count++;
    }
    string[] newArray = new string[count];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            newArray[k] = arr[i];
            k++;
        }
    }
    return newArray;
}
string[] arr={"hello", "2", "world", ":-)"}; // задаем первоначальный массив
System.Console.WriteLine(String.Join(",",NewArr(arr)));// выводим новый массив в консоль