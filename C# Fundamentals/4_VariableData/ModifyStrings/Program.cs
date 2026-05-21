string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

//another example
message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

openingPosition = message.IndexOf(openSpan);
closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

//Using IndexOf() and LastIndexOf() helper methods
message = "(What if) I am (only interested) in the last (set of parentheses)?";
openingPosition = message.LastIndexOf('(');
openingPosition += 1;

closingPosition = message.LastIndexOf(')');
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

Console.WriteLine();

//Retrieving all instances of substrings in parentheses
message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break; //exit if no more parentheses

    openingPosition += 1;
    closingPosition = message.IndexOf(')');
    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

Console.WriteLine();

//IndexOfAny(): takes list or multiple strings/chars as argument, returns index of the first point where any one of them is found
message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };
int index = message.IndexOfAny(charsToFind);
Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

Console.WriteLine();

//Another example
message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

Console.WriteLine();

//More Complex Example
message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

openSymbols = [ '[', '{', '(' ];

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

closingPosition = 0;

while (true)
{
    openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

//2 Important Things to Remember:
//LastIndexOf() returns last position of a character/string inside another string
//IndexOfAny() returns the first position of an array of char that occurs inside another string

Console.WriteLine();

//Using the Remove() and Replace() Methods

//Using Remove()
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20); //Deletes starting at index 5 up to before index 20 (5 included, 20 isn't)
Console.WriteLine(updatedData);

//Using Replace()
message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " "); //Any instance of "--" becomes " "
message = message.Replace("-", ""); //Any instance of "-" becomes "" (more or less same as Remove("-"))
Console.WriteLine(message);

Console.WriteLine();

//Challenge: extract, replace, and remove data from an input string
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string qOpen = "<span>";
const string qClose = "</span>";

const string outOpen = "<h2>";
const string outClose = "</div>";

int qOpenIndex = input.IndexOf(qOpen) + qOpen.Length;
int qCloseIndex = input.IndexOf(qClose);
int qLength = qCloseIndex - qOpenIndex;

int outOpenIndex = input.IndexOf(outOpen);
int outCloseIndex = input.IndexOf(outClose);
int outLength = outCloseIndex - outOpenIndex;

quantity = input.Substring(qOpenIndex, qLength);
output = input.Substring(outOpenIndex, outLength);

Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output);
