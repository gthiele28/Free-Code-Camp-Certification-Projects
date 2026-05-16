bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
//Below line causes: error CS0103: The name 'value' does not exist in the current context
//Console.WriteLine($"Outside the code block: {value}");
//Variables don't keep existing outside of a code block, meaning that if int was declared (even just 'int value;') outside the block there wouldve been no error caused

//bool flag = true;
if (flag) Console.WriteLine(flag);
//If only one line, you don't need brackets to define the block

string name = "steve";
if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

//Challenge: Debug
int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
bool found = false;

foreach (int number in numbers)
{

    total += number;

    if (number == 42)
    {
       found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");