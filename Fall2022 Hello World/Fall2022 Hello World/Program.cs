// What is this stuff?
// What is a 'console' application?
// What's with the fancy coloring?
// I am ignored :(
Console.WriteLine("Hello, World!");

// Variables and Objects

// Variable Declaration
// Variable declaration is stating that we have a variable and giving it an associated name
// if you are just doing variable declaration, you must state the variable type first

// variableType variableName;
string Instructor;

// Variable Assignment
// Variable assignment is giving a variable a value (of the appropriate type) for us to reference later

// variableName = value;
Instructor = "Gavin";
// Variable Reassignment
Instructor = "Davis";

// All together now!
// if we use 'var', C# will understand that Age is an integer based on the value from the right of the equal sign.

// var/variableType variableName = value;
var Age = 24;
// this will print out the value 24 to the console
Console.WriteLine(Age);

// Operators
// Performs some kind of basic operation/action on some values
// ex. 5 + 13 -> 18

// Assignment Operator
// single equal sign
// Use this to assign the value of a variable

// Arithmetic
// Addition/String Concatenation: +
var studentCount = 5 + 13;
Console.WriteLine(studentCount);
var stringExample = "hello!" + 15;
Console.WriteLine(stringExample);
// Subtraction: -
// Multiplication: *
// Division: /
var averageClassSize = studentCount / 4f; // 18 divided by 3 -> 6 || 18 divided by 4 -> 4 || 18 divided by 4f -> 4.5f
Console.WriteLine(averageClassSize);
// Exponentiation: ^
// Modulo: %
// -- Returns the remainder after dividing by a particular number
var time = 13 % 12; // time has a value of 1 here.
Console.WriteLine(time);

// Equality

// Comparison

// Increment

// Parsing
// Transforming a variable from another type (often a string) into another (often an integer)
var parsedValue = int.Parse("15"); // integer 15
Console.WriteLine(parsedValue + 5);