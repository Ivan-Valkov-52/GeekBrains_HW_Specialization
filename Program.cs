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



Console.WriteLine("Заданный массив: ");
string[] array = { "12", "l o", "maqni", ":-)", "321k", "шлё", "dkwe" };
Console.WriteLine("[" + string.Join(", ", array) + "]");
