/* VARIABLE NAME RULES:
- Only alphanumeric characters and underscores allowed (no -, $, etc)
- Must begin with alphabetical letter or underscore
    - Underscore conventionally used to denote private instance fields
- Must NOT be a preexisting keyword (i.e. no variable named float, string, etc.)
- Names are case-sensitive (x and X would be different variables)

CONVENTIONS:
- Use camelCase, lower-case for first word then capitalize others, no spaces/underscores between
- Choose descriptive/meaningful names representing kind of data held in variable, not just its type (orderComplete > isComplete)
- Should be one or more words, don't abbreviate (orderAmount > odrAmt)
- Don't include data type of the variable (popular style in the past, not used today)
*/

/* EFFECTIVE COMMENTS EXAMPLE: */

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

//DON'T ALWAYS TRUST COMMENTS! THEY MAY NOT BE UP-TO-DATE AFTER MANY CHANGES + UPDATES!!!

/* WHITESPACE */

//Whitespace is ignored by the compiler

// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

//Without whitespace, code can be hard to read!
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

//Compare to:
dice = new Random();

//Remove int here to avoid error
roll1 = dice.Next(1, 7);
roll2 = dice.Next(1, 7);
roll3 = dice.Next(1, 7);

total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

//NOTE: People love to put each bracket on its own line (shoutout CS61B style guide grading lol).  Just do it for convienience

//Exercise: improve readability of code

/* STARTING POINT:

string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

*/

/* 
The below code takes an initial message str, converts it into an array of characters (chars),
Reverses it, then counts the 'o' characters and converting the array back into a string,
Then prints both the now-reversed string and the number of times 'o' appears.
*/

string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage) 
{ 
    if (i == 'o') 
    { 
        x++;
    } 
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");