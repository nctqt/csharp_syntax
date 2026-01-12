// See https://aka.ms/new-console-template for more information

using Humanizer;


// learning the basics, examples of syntax that I find interesting

Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

// write a literal int
Console.WriteLine(123);
// notice the typing after the vaule, gives us a float, no typing defaults to Double
Console.WriteLine(0.25F);
// bool
Console.Write(true);
Console.Write(" ");
Console.Write(false);
Console.WriteLine(" ");

// the 'var' keyword can be used to save keystrokes, it still hard types the variable
var amount = 123;
Console.WriteLine(amount);
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

// escape characters are just like C
// '@' before a string removes the need to escape spaces and tabs, '+' to concat
Console.WriteLine(@".      example");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
var test = "こんばんは";
Console.WriteLine(test);

// '$' and '{}' for interpolation
// '$' and '@' can be combined
Console.WriteLine($@"hello         {firstName}");

// packages, add specific package version
// dotnet add package Humanizer --version 2.7.9 
// update to latetst package
// dotnet add package Humanizer
Console.WriteLine("Quantities:");
HumanizeQuantities();

Console.WriteLine("\nDate/Time Manipulation:");
HumanizeDates();

static void HumanizeQuantities()
{
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));
}

static void HumanizeDates()
{
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}