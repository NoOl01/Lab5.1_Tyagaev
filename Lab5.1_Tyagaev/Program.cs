Console.Write("Введите первую строку: ");
char[] array1 = Console.ReadLine().ToCharArray();
Console.Write("Введите вторую строку: ");
char[] array2 = Console.ReadLine().ToCharArray();
bool areAnagrams = AreAnagrams(array1, array2);
if (areAnagrams)
{
    Console.WriteLine("Эти строки являются анаграммами.");
}
else
{
    Console.WriteLine("Эти строки не являются анаграммами.");
}
static bool AreAnagrams(char[] array1, char[] array2)
{
    if (array1.Length != array2.Length)
    {
        return false;
    }
    Array.Sort(array1);
    Array.Sort(array2);
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            return false;
        }
    }
    return true;
}