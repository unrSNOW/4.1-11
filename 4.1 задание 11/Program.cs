//int[] mas= { 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1 };
//Dictionary<int, int> countDict = new Dictionary<int, int>();
//foreach (int num in mas)
//{
//    if (countDict.ContainsKey(num))
//    {
//        countDict[num]++;
//    }
//    else
//    {
//        countDict[num] = 1;
//    }
//}
//foreach (var item in countDict)
//{
//    if (item.Value > 2)
//    {
//        mas = Array.FindAll(mas, x => x != item.Key);
//    }
//}
//Console.WriteLine("Результирующий массив:");
//foreach (int num in mas)
//{
//    Console.Write(num + " ");
//}



string[] mas = { "1010", "1100", "1010", "0110", "1100", "1010", "0011", "1100", "1010", "0110", "1100", "1010" };
Dictionary<string, int> counts = new Dictionary<string, int>();
foreach (string n in mas)
{
    if (!counts.ContainsKey(n))
    {
        counts[n] = 1;
    }
    else
    {
        counts[n]++;
    }
}
List<string> elementsToRemove = counts.Where(pair => pair.Value > 2).Select(pair => pair.Key).ToList();
foreach (string element in elementsToRemove)
{
    mas = mas.Where(num => num != element).ToArray();
}
Console.WriteLine("Массив после удаления элементов, встречающихся более двух раз:");
foreach (string binaryNumber in mas)
{
    Console.WriteLine(binaryNumber);
}
