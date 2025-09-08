using System.Collections;

namespace Assignment_4_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[] numbers = { 1, 2, 2, 3, 1, 4, 5, 2, 3, 1, 5, 5 };
            //Hashtable hashtable = new Hashtable();
            //foreach (int item in numbers)
            //{
            //    if (hashtable.ContainsKey(item))
            //    {
            //        hashtable[item] = (int?)hashtable[item] + 1;
            //    }
            //    else
            //    {
            //        hashtable[item] = 1;
            //    }
            //}
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"Element {item.Key}: {item.Value} times");
            //}
            #endregion
            #region Q2
            //Hashtable hashtable = new Hashtable() { ["Youssef"] = 100 , ["Amr"] = 20, ["Ali"]=10 , ["Mona"] = 30};
            //object? maxKey = null;
            //int maxValue = int.MinValue;
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    int value = (int?)item.Value ??0;
            //    if (value > maxValue)
            //    {
            //        maxValue = value;
            //        maxKey = item.Key;
            //    }
            //}
            //Console.WriteLine($"Key with highest value: {maxKey}, Value: {maxValue}");
            #endregion
            #region Q3
            //Hashtable hashtable = new Hashtable() { ["key1"] = "apple", ["key2"] = "banana", ["key3"]="apple"};
            //Console.Write("Enter target value: ");
            //string target = Console.ReadLine() ??"";
            //bool found = false;
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    if ((string?)item.Value == target)
            //    {
            //        Console.WriteLine(item.Key);
            //        found = true;
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("Key not found");
            //}
            #endregion
            #region Q4
            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            //foreach (string word in words)            
            //{
            //    char[] chars = word.ToCharArray();
            //    Array.Sort(chars);
            //    string key = new string(chars);
            //    if (!groups.ContainsKey(key))
            //    {
            //        groups[key] = new List<string>();
            //    }
            //    groups[key].Add(word);
            //}
            //Console.WriteLine("Grouped Anagrams:");
            //foreach (var group in groups.Values)
            //{
            //    Console.WriteLine("[ " + string.Join(", ", group) + " ]");
            //}
            #endregion
        }
    }
}
