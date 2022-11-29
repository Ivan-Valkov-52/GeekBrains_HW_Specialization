int GiveLenghtNewArray(string[] array)
{
    int newLenghtArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newLenghtArray++;
        }
    }
    return newLenghtArray;
}

string[] GetArray(string[] array)
{
    int index = 0;
    string[] newArray = new string[GiveLenghtNewArray(array)];
    foreach (string el in array)
    {
        if (el.Length <= 3)
        {
            newArray[index] = el;
            index++;
        }
    }
    return newArray;
}

Console.WriteLine("Заданный массив: ");
string[] array = { "12", "l o", "maqni", ":-)", "321k", "шлё", "dkwe" };
Console.WriteLine("[" + string.Join(", ", array) + "]");
string[] newArray = GetArray(array);
Console.WriteLine("Новый массив: ");
Console.WriteLine("[" + string.Join(", ", newArray) + "]");
