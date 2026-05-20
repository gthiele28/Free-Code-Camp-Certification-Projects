string[] pallets = [ "B14", "A11", "B12", "A13" ];

//Sorting
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Reversing
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Clearing
pallets =  ["B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Converting a string to an array of characters
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);

// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

//Splitting into an array of strings
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

//Challenge: reverse each word in a message
string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramWords = pangram.Split(' ');

for (int i = 0; i < pangramWords.Length; i++)
{
    char[] letters = pangramWords[i].ToCharArray();
    Array.Reverse(letters);
    pangramWords[i] = new string(letters);
}

pangram = String.Join(" ", pangramWords);
Console.WriteLine(pangram);

//Challenge: sort and tag ids
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');

for (int i = 0; i < orders.Length; i++) 
{   
    Console.Write(orders[i]);
    if (orders[i].Length != 4) {
        Console.Write("\t- Error");
    }
    Console.WriteLine();
}
