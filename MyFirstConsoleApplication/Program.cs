using System.Security.Cryptography.X509Certificates;

string myname = "My name is Fanfan Jean Renel , I am from Haiti";
string location = "I am currently living in Port-au-Prince, Haiti.";
Console.WriteLine( myname + location);
DateOnly today = DateOnly.FromDateTime(DateTime.Now);
// Remove the slash from the date
string dateWithoutSlash = today.ToString("yyyyMMdd");
// Convert the date to an integer
int toDayDateAsInt = int.Parse(dateWithoutSlash);
// christmas date this year
DateOnly christmas = new DateOnly(today.Year, 12, 25);
// Remove the slash from the christmasdate
string christmasDateWithoutSlash = christmas.ToString("yyyyMMdd");
// Convert the christmasdate to an integer
int christmasDateAsInt = int.Parse(christmasDateWithoutSlash);
// Check if today is before or after christmas
if (toDayDateAsInt < christmasDateAsInt)
{

    // number of days until christmas
    int daysUntilChristmas = christmasDateAsInt - toDayDateAsInt;
    Console.WriteLine("Today is before Christmas. There are " + daysUntilChristmas + " days until Christmas." + "\n");
}
else if (toDayDateAsInt > christmasDateAsInt)
{
    Console.WriteLine("Today is after Christmas.");
}
else
{
    // If today is Christmas, print a special message
    Console.WriteLine("Today is Christmas.");
    Console.WriteLine("Merry Christmas!");
}
// This program that we are going to look at will read in the width and height of a window
// and then print out the amount of wood and glass required to make a window that will fit in a hole of that size.
Console.WriteLine("Simple Window Calculator.");
double width, height, woodLength, glassArea;
string widthString, heightString;
Console.WriteLine("Enter the width of the window in feet: ");
widthString = Console.ReadLine();
width = double.Parse(widthString);
Console.WriteLine("Enter the height of the window in feet: ");
heightString = Console.ReadLine();
height = double.Parse(heightString);
woodLength = 2 * ( width + height ) * 3.25 ;
glassArea = 2 * ( width * height ) ;
Console.WriteLine ( "The length of the wood is " +
woodLength + " feet" ) ;
Console.WriteLine( "The area of the glass is " +
glassArea + " square metres" ) ;
// Cause the program to pause in the console.
Console.WriteLine("Press any key to exit.");
Console.ReadKey(true);