var array = new int[] { 1, 2, 5, 3, 2, 4, 5, 6, 2, 1, 4, 6, 6, 6, 7, 1, 3, 4 };

var result = Algo.FindCountOfElements(array);

foreach(var item in result)
{
    Console.WriteLine($"{item.Key}:{item.Value}");
}

public static class Algo
{
    public static Dictionary<int, int> FindCountOfElements(int[] array)
    {
        if(array is null)
        {
            throw new ArgumentNullException();
        }

        var dictionary = new Dictionary<int, int>();

        foreach (var item in array)
        {
            if (!dictionary.ContainsKey(item))
            {
                dictionary.Add(item, 0);
            }
        }

        foreach(var item in array)
        {
            dictionary[item] += 1;
        }

        return dictionary;
    }
}