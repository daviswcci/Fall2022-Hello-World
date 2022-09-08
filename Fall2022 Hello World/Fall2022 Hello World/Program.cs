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
// Exponentiation: Math.Pow();
// Modulo: %
// -- Returns the remainder after dividing by a particular number
var time = 13 % 12; // time has a value of 1 here.
Console.WriteLine(time);

// Booleans
// Boolean is a data type where the only values are 'true' vs 'false' - 'on' vs 'off' - 1 vs 0
var isSunny = true;

// Equality ==
// Checks to see if the value of Instructor is the same as the value "Davis"
var isDavis = Instructor == "Davis"; // Davis == Davis -> true

// Not Eqaul !=
// Checks to see if two things ARE NOT equal, returns true if the two values are not the same
var isGavin = Instructor != "Davis";

// Comparison
// Checks to see if a value is greater than, less than, or GE or LE
// G: >
// L: <
// GE: >=
// LE: <=
var isGreaterThan = 25 >= 25; // checking is it greater than OR is it equal to?
// Is 25 greater than or equal to 25?
// Is 25 greater than 25? -> false
// Is 25 equal to 25? -> true
// Since one part was true, the whole statement was true

// Boolean Operators
// We have some specific operators defined for actions between two boolean values

// OR operator ||  ( | if you want to run both sides)
// The OR operator returns true if the left is true OR the right is true
// true || false -> true
// false || true -> true
// true || true -> true
// false || false -> false
var willGoOutside = isSunny || isDavis; // true || true -> true

// AND operator && ( & if you want to run both sides)
// The AND operator returns true if the left AND the right values are true
// true && false -> false
// false && true -> false
// true && true -> true
// false && false -> false
var isRainy = true;
var isCold = true;
var willNotDrive = isRainy && isCold; // true && true -> true

// NOT operator !
// Returns the opposite of a given boolean value
// !true -> false
// !false -> true
var willDrive = !willNotDrive;

// Exclusive OR (XOR) operator ^
// Only returns true when the left or right are true, false when both are true.
// true ^ false -> true
// false ^ true -> true
// true ^ true -> false
// false ^ false -> false

// Parsing
// Transforming a variable from another type (often a string) into another (often an integer)
var parsedValue = int.Parse("15"); // integer 15
Console.WriteLine(parsedValue + 5);

// Increment




//bool one = true
//bool two = false
//bool three = true

// (one && !two)
// true && true -> true

// (three || (two && three))
// true || false -> true

// !two && (!three && (one || two)) || three
// true && false || true -> true
// false || true -> true
Console.WriteLine(!false && (!true && (true || false)) || true);


// one && two && three
// false

// one || two || three
// true
