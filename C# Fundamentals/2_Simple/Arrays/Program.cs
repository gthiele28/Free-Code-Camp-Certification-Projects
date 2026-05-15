//Initialization
string[] fraudulentOrderIDs = new string[3];

//Initial assignments
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

//System.IndexOutOfRangeException
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");


//Reassign
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//Initialize and assign at once
string[] fraudulentOrderIDs1 = [ "A123", "B456", "C789" ];

//Same thing, from an older version of the language (both this and above are valid)
string[] fraudulentOrderIDs2 = { "A123", "B456", "C789" };

// .Length: returns length of array object, like len(arr) in python, etc.
//Note: C# LOVES capital letters to start basically everything, don't forget that
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

Console.WriteLine("\n");

//ITERATING THROUGH AN ARRAY:
string[] names = { "Rowena", "Robin", "Bao" };

//Foreach loop: name will take on value of each string in names, not the index
//NOTE: foreach is a separate loop type in C#
foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("\n");

//Exercise: implement and sum an array using foreach
int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

foreach(int item in inventory)
{
    bin++; //Add 1 to bin (same as basically always)
    sum += item;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}

Console.WriteLine($"The sum of inventory is: {sum}");

Console.WriteLine("\n");

//Exercise: Challenge activity for nested iteration/selection statements
string[] arr = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
int track = 0;

foreach (string orderid in arr)
{
    if (orderid.StartsWith("B")) //StartsWith: checks if string's start matches passed argument, can take a string of any length, returns True/False
    {
        track++;
        Console.WriteLine($"OrderID number {track} ({orderid}) starts with 'B'!");
    }
}