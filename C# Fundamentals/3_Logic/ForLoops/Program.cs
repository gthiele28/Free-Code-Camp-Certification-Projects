//Fine control over loop index i is possible
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

//Break: exits loop early
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

//Using an index to loop through an array (backwards)
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

//Don't redefine this, leave it commented
//string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    //error CS1656: Cannot assign to 'name' because it is a 'foreach iteration variable'
    // if (name == "David") name = "Sammy";
    break; //Delete this + uncomment above line to see error
}

//Unlike foreach, editing the array using for is possible
//string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);

//string[] names = { "Alex", "Eddie", "David", "Michael" };

//Another version of the same thing as above, just with more whitespace and brackets
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

//Challenge: fizzbuzz

for (int i = 1; i < 23; i++) 
{
    if (i % 3 == 0 && i % 5 == 0) 
    {
        Console.WriteLine($"{i} - FizzBuzz");
    } else if (i % 3 == 0) 
    {
        Console.WriteLine($"{i} - Fizz");
    } else if (i % 5 == 0) 
    {
        Console.WriteLine($"{i} - Buzz");
    } else {
        Console.WriteLine($"{i}");
    }
}