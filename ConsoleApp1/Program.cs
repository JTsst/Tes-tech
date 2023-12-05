
// this is how to write comments
// See https://aka.ms/new-console-template for more information
//is cake really a lie? 
/* yes
no
idk */


// this is how to write console 
//console.writeline is a new line
//console.write is not a new line 
Console.WriteLine("Cake is a lie!");

Console.Write("potato is a lie! ");

Console.WriteLine("i am a lie?");

//data types: int, string, bool, double, float, char, decimal, long, short, byte, uint, ulong, ushort, sbyte
/*int is a whole number
string is a text
bool is true or false
double is a decimal number
float is a decimal number up 7 digits
char is a single character
decimal is a decimal number up to 28 digits
long is a whole number
short is a whole number
byte is a whole number
uint is a whole number
ulong is a whole number
ushort is a whole number
sbyte is a whole number
*/

//variables 
int x;
// it need to be given a value
x = 7;
int y = 3, z = 5;
//console.writeline(x); is without "" so it will print the value of x
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine("x = "+ x + " and y = " + y + " and z = " + z);

int d = x + y - z * x / y % z;
Console.WriteLine("result of d is = " + d);

float e = 5.5f;
Console.WriteLine("e = " + e);

string str = "i am a lie"+" and i am not a lie";

Console.WriteLine(str);