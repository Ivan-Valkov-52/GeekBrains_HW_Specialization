int GiveLenghtNewArray(string[] array, int value)
{
    int newLenghtArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            newLenghtArray++;
        }
    }
    return newLenghtArray;
}

string[] GetArray(string[] array, int value)
{
    int index = 0;
    string[] newArray = new string[GiveLenghtNewArray(array, value)];
    foreach (string el in array)
    {
        if (el.Length <= value)
        {
            newArray[index] = el;
            index++;
        }
    }
    return newArray;
}

int value = 3;
Console.WriteLine("Заданный массив: ");
string[] array = { "12", "l o", "maqni", ":-)", "321k", "шлё", "dkwe" };
Console.WriteLine("[" + string.Join(", ", array) + "]");
string[] newArray = GetArray(array, value);
Console.WriteLine("Новый массив: ");
Console.WriteLine("[" + string.Join(", ", newArray) + "]");
