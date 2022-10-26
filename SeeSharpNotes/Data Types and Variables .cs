// *********************************** C# Data Types ***********************************


//      int-- whole numbers: 1, -56, 948 
//      Double -- Decimal numbers: 239.43909 , -660.01 
//      char -- single characters: 1, &, L 
//      string  -- string of characters: dog, hello world, park
//      bool ---   true or false 



// *********************************** Creating Variables with Types ***********************************

// Variable ---  store values in our code 
// For first line below: Name = Variable 

// Example: 

// Create Variables 
string name = "Shadow";
string breed = "Golden Retriever";
int age = 5;
double weight = 65.22;
bool spayed = true;

//Print Variables to the console 
Console.WriteLine(name);
Console.WriteLine(breed); 
Console.WriteLine(age);
Console.WriteLine(weight); 
Console.WriteLine(spayed);

// Another Example: 

int evenNumber = 25;
int oddNumber = 45;
Console.WriteLine(evenNumber + oddNumber);
Console.WriteLine(oddNumber - evenNumber);



// *********************************** Converting Data Types ***********************************

//double myDouble = 3.2; 
//// Round myDouble to the nearest whole number 
//int myInt = (int)myDouble;

// Example
//Console.WriteLine("Enter your favorite number!: ");
//int faveNumber = Convert.ToInt32(Console.ReadLine()); 



// *********************************** Introduction to Working with Numbers ***********************************

//int 
// Defining an int 
// int (variableName) = 10; 

// Decimal Numbers: Float, Double, and Decimal 
// double = more precise than a float, but faster to process than a decimal 
// Defining a double 
// double (variableName) = 39.76876; 
// Defining a decimal 
// decimal (variableName) = 489872.76m;
// Don't forget the m character after the number. It tells C# that we are defining a decimal and not a double 

// Example 
// Number of Pizza Shops 
// int pizzaShops = 4332; 
// Number of Employees 
// int totalEmployees = 86928; 
// Revenue 
// double revenue = 390819.28; 

// Print Values to the console 
//Console.WriteLine(pizzaShops); 
//Console.WriteLine(totalEmployees); 
//Console.WriteLine(revenue);


// *********************************** Arithmetic Operators ***********************************

//addition = + 
//subtraction = - 
//multiplication = * 
//division = / 

//Example:
//int answer = 4 + 19;
//Console.WriteLine(answer); prints out 23 



// *********************************** Operator Shortcuts ***********************************

// incrementing by one = ++ 
// subtracting by one = -- 

// Example: 
// Declare step Variable 
// int steps = 0; 
// Two steps forward 
// steps = steps + 2; 
// One step back 
// steps = steps -1; 
// Print Result to the console 
// Console.WriteLine(steps); 


// *********************************** Modulo (%) ***********************************

// A modulo returns a remainder (what is left over when we divide a number by another number) 

//int eggs = 56;
//int createAmount = 12;
//int eggsLeftOver = eggs % crateAmount;
//Console.WriteLine(eggsLeftOver);    prints out 8 




// *********************************** Built In Methods ***********************************

//Math.Abs()   -- will find the absolute value of a number 
//Math.Sqrt()  -- will find the square root of a number 
//Math.Floor() -- will round the given double or decimal down to the nearest whole number 
//Math.Min()   -- returns the smaller of two numbers 

// Example 
// Starting Variables 
// int numberOne = 12932; 
// int numberTwo = -2828472; 
// Find the square root of number one and round the answer down so it doesn't have a decimal. Save this value to a new double variable numberOneSqrt 
// double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
// Do the same to numberTwo 
// double numberTwoSqrt= Math.Floor(Math.Sqrt (Math.Abs(numberTwo))); 
// Print the lowest number 
// Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));     returns: 113 

//Math.Pow()     -- class method that is used to raise a number to a specified power
// double math = Math.Pow(6, 2); 
//Console.WriteLine(math);    prints: 36 
//Math.Max()     -- finds the larger of two specified numbers 
//Math.Ceiling() -- find the smallest integral value greater than or equal to the specified number 

//Example: 
// double numberOne = 6.5; 
// double numberTwo = 4 ; 
// Raise numberOne to the numberTwo power 
//Console.WriteLine(Math.Pow(numberOne, numberTwo)); 
// Round numberOne up
// Console.WriteLine(Math.Ceiling(numberOne)); 
// Find the larger number between numberOne and numberTwo 
// Console.WriteLine(Math.Max(numberOne, numberTwo)); 




// *********************************** Working with Text: Building Strings ***********************************

// string = a group of characters surrounded by quotation marks
// string variableName = "puppy"; 

// *********************************** Escape character Sequences ***********************************

// When you need to include a quotes in string, you can use an escape sequence. An escape sequence places a backslash (\) before the inner quotation makrs, 
// string withSlash = "Bru said, \"Hello!\"";

// We can use escape characters to create a new line. That means that when we print the string to the console, it will print that line below the rest
// string NewLine = "Bru walked \n to the park; 

//Example: 
// Console.WriteLine(firstSentence); 
// Console.WriteLine("\n"); 
// Console.WriteLine(firstSpeech); 

// *********************************** String Concatenation ***********************************

// String concatenation is when we combine strings using the addition symbol (+) adding one string to another 

//Example 
// string beginning = "Bru" 
// string midle = "schi"; 
// string end = "Lechner"; 

// Concatenate the string and the variables 
// string story = beginning + middle + " " + end + "."; Prints to console: Bruschi Lechner. 


// *********************************** String Interpolation ***********************************

// String Interpolation enables us to insert our variable values and expressions in the middle of a string, without having to worry about spaces and punctuation 

// Example: 
// Declare the variables 
//string beginning = "Once upon a time,";
//string middle = "The kid climbed a tree";
//string end = "Everyone lived happily ever after.";

// Interpolate the string and the variables
//string story = $"{beginning} it was a beautiful day. {middle} and the birds flew through the sky. {end}";
// Print the story to the console 
// Console.WriteLine(story); Prints out "Once upon a time, it was a beautiful day. The kid climbed a tree and the birds flew through the sky. Everyone lived happily ever after." 





// *********************************** Get Info About Strings ***********************************

// .Length = how many characters exist in a string 
    // string userTweet = Console.ReadLine(); 
    // userTweet.Length;     // returns the length of the tweet 

// IndexOf = We can find the position of a specific character or substring. Starting position is at 0, the second thing in the string will return a 1. If it doesnt exist it will return a -1. If we pass it an empty string, it will return 0
    // string word = "radio"; 
    // word.IndexOf("a");    // returns 1 

