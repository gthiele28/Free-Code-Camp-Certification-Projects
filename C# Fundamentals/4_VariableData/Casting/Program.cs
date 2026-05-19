//2 techniques for datatype conversion
//Best one depends on:
//1. Is it possible that changing the type will cause an error?
//2. Is it possible that changing the type will cause information loss?


//error CS0029: Cannot implicitly convert type 'string' to 'int'
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

//Since any int can be easily expressed as a decimal, the compiler is able to convert it easily
decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

//The above examples (int -> string, int -> decimal) are examples of implicit conversion
//In these cases, although conversion isn't performed directly (explicitly) the compiler 'knows' that they will prevent an error
//This only works when the new datatype can easily hold the current value (aka a Widening Conversion)

//Casting (explicit conversion)
myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

//Using the casting operator '()' to surround a datatype forces a conversion to that type
//This will cause the conversion to be done, even if data/precision is lost (float -> int)

myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
//In the above, one decimal point of precision is lost since decimals can store more data than floats

//ToString() - Every data type has a tostring method, and it isn't always necessary, it can be helpful for others (or you in the future)
int first2 = 5;
int second2 = 7;
string message = first2.ToString() + second2.ToString();
Console.WriteLine(message);

//x.Parse() method - forces the argument into type x, can cause errors
//x.TryParse() - slower, but will avoid errors
string first3 = "5";
string second3 = "7";
int sum = int.Parse(first3) + int.Parse(second3);
Console.WriteLine(sum);

//Convert.ToXXXX() - the convert class, which has methods to convert between many different classes
//Best for converting fractional numbers into whole numbers
string value1 = "5";
string value2 = "7";
int result2 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result2);

//m marks end to decimal type numbers, since decimal can avoid fractional rounding but double is used as default by compiler when a fractional number is seen
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value3 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value3);


//Exercise: Examine the TryParse() method

string toConvert = "102";
int converted = 0;
if (int.TryParse(toConvert, out converted))
{
   Console.WriteLine($"Measurement: {converted}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + converted}");

//Try a value that can't be converted
toConvert = "bad";
converted = 0;
if (int.TryParse(toConvert, out converted))
{
   Console.WriteLine($"Measurement: {converted}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
if (converted > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + converted}");

//Challenge: combine string array values as strings and as integers

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal finalSum = 0.0m;
string concat = "";

foreach (string curr in values)
{
   decimal convertD;
   if (decimal.TryParse(curr, out convertD)) 
   {
      finalSum += convertD;
   } else 
   {
      concat += curr;
   }
}

Console.WriteLine($"Message: {concat}");
Console.WriteLine($"Total: {finalSum}");

//Challenge: output math operations as specific number types
int num1 = 11;
decimal num2 = 6.2m;
float num3 = 4.3f;

int res1 = Convert.ToInt32(num1 / num2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {res1}");

decimal res2 = num2 / (decimal)num3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {res2}");

float res3 = (float)num3 / (float)num1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {res3}");