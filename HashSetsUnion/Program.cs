// See https://aka.ms/new-console-template for more information

// Hash sets are dictionaries without values. So Running contains method is very fast.
// In dictionaries and hashSets Contains method operates with a Big O of 1.

using HashSetsUnion.EqualityComparererCreationAttempt;
using System.Collections;
using System.Collections.Specialized;

IEqualityComparer comparer = new HashSetsUnion.EqualityComparererCreationAttempt.Comparer();

//Console.WriteLine(comparer.GetHashCode(6)); // This runs the method in Comparer
Console.WriteLine(comparer.GetHashCode()); // This runs the method on the object.

OrderedDictionary oD = new OrderedDictionary(comparer); // Ordered dictionary does not order with keys LoL.
oD.Add("a", 2);
oD.Add('c', 3);
oD.Add('b', 4);
oD.Add(3, 5);
Console.WriteLine("Values in the ordered dictionary are: ");
foreach (var item in oD)
{
    Console.WriteLine((item));
}
HashSet<string> hashSet = new HashSet<string>() { "a", "b", "c" };
Console.WriteLine("Values in the hash set are: ");
foreach (var hash in hashSet)
{
    Console.WriteLine(hash);
}
HashSet<string> hashSet2 = new HashSet<string>(new HashSet<string>() { "a","b","c"});
List<int> intListesi = new List<int>();
IntComparer intComparer = new();
Dictionary<int,int> intDictionary = new Dictionary<int, int>(intComparer) { [10] = 10, [0] = 0, [1] = 1, [3] = 3,
                                                                [2] = 2 };

Console.WriteLine("Keys in the dictonary.");
foreach (var keyValuePair in intDictionary)
{
    Console.WriteLine(keyValuePair.Key);
}


TDemo(4);
Console.WriteLine(TDemo("ere"));
Stack<String> stack = new Stack<String>();
bool result = stack.Contains("a");

if (result == true)
{
    result = false;
}


HashSet<T> CreateUnion<T>(HashSet<T> set1, HashSet<T> set2) //where T : class, new()
{
    HashSet<T> union = new(set1);
    foreach (var item in set2)
    {
        union.Add(item);
    }
    return union;
}

string TDemo<T>(T type)// where T :  Type
{
    return "ses";
}
