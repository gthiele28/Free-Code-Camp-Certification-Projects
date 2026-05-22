//Compiler-Generated Exceptions
// ArrayTypeMismatchException: thrown if an array can't store a given element
// DivideByZeroException: thrown when an integral value is divided by 0
// FormatException: thrown when the format of an argument is invalid
// IndexOutOfRangeException: thrown when the index passed for an array is greater than length or less than zero
// InvalidCastException: thrown when an explicit conversion fails at runtime
// NullReferenceException: thrown when code references an object with a null value
// OverflowException: thrown when an arithmetic operation (in a checked context) overflows (goes over max possible stored value)

//Examples:

//ArrayTypeMismatch
string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs

//DivideByZero
int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); // DivideByZeroException occurs

//Format
int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs

//IndexOutOfRange
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs

//InvalidCast
object obj = "This is a string";
int num = (int)obj;

//NullReference
int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2;
string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());

//OverFlow
decimal x = 400;
byte i;

i = (byte)x; // OverflowException occurs
Console.WriteLine(i);