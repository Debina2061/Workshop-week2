using System.Collections.Generic;
List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };
fruits.Add("Orange");
fruits.Remove("Mango");

Console.WriteLine("Fruits in the list:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitDict = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Mango" },
    { 3, "Banana" }
};
fruitDict.Add(4, "Orange");

Console.WriteLine("\nFruit Dictionary:");
foreach (var kvp in fruitDict)
{
    Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
}
