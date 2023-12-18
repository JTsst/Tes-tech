
// this is how to write comments
// See https://aka.ms/new-console-template for more information
//is cake really a lie? 
/* yes
no
idk */


// this is how to write console 
//console.writeline is a new line
//console.write is not a new line 
//Console.WriteLine("Cake is a lie!");

//Console.Write("potato is a lie! ");

//Console.WriteLine("i am a lie?");

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
/*
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
*/
/*
int x = 4;


bool isFour = x == 4;

Console.WriteLine("x os 4 " + isFour);
*/

/* opgave 7
int Firstnumber, Secondnumber;

Console.WriteLine("give me the first number");
Firstnumber = int.Parse (Console.ReadLine()!);

Console.WriteLine("give me the second number");
Secondnumber = int.Parse (Console.ReadLine()!);

Console.WriteLine(Firstnumber +" + "+ Secondnumber + " = " + (Firstnumber + Secondnumber));

Console.WriteLine(Firstnumber +" - "+ Secondnumber + " = " + (Firstnumber - Secondnumber));

Console.WriteLine(Firstnumber +" * "+ Secondnumber + " = " + (Firstnumber * Secondnumber));

Console.WriteLine(Firstnumber +" / "+ Secondnumber + " = " + (Firstnumber / Secondnumber));

Console.WriteLine(Firstnumber +" mod "+ Secondnumber + " = " + (Firstnumber % Secondnumber));
*/

// opgave 8 Write a C# Sharp program that prints the multiplication table of a number as input.
int multiplyNumber;
Console.WriteLine("give me a number to multiply");
multiplyNumber = int.Parse (Console.ReadLine()!);// int.Parse is to convert string to int
Console.WriteLine(multiplyNumber +" * "+ 0 + " = " + (multiplyNumber * 0));
Console.WriteLine(multiplyNumber +" * "+ 1 + " = " + (multiplyNumber * 1));
Console.WriteLine(multiplyNumber +" * "+ 2 + " = " + (multiplyNumber * 2));
Console.WriteLine(multiplyNumber +" * "+ 3 + " = " + (multiplyNumber * 3));
Console.WriteLine(multiplyNumber +" * "+ 4 + " = " + (multiplyNumber * 4));
Console.WriteLine(multiplyNumber +" * "+ 5 + " = " + (multiplyNumber * 5));
Console.WriteLine(multiplyNumber +" * "+ 6 + " = " + (multiplyNumber * 6));
Console.WriteLine(multiplyNumber +" * "+ 7 + " = " + (multiplyNumber * 7));
Console.WriteLine(multiplyNumber +" * "+ 8 + " = " + (multiplyNumber * 8));
Console.WriteLine(multiplyNumber +" * "+ 9 + " = " + (multiplyNumber * 9));
Console.WriteLine(multiplyNumber +" * "+ 10 + " = " + (multiplyNumber * 10));

/* opgave 9
int avnumber1, avnumber2, avnumber3, avnumber4;
Console.WriteLine("give me the first number");
avnumber1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("give me the second number");
avnumber2 = int.Parse (Console.ReadLine()!);
Console.WriteLine("give me the third number");
avnumber3 = int.Parse (Console.ReadLine()!);
Console.WriteLine("give me the fourth number");
avnumber4 = int.Parse (Console.ReadLine()!);
Console.WriteLine("the average of " + avnumber1 + ", " + avnumber2 + ", " + avnumber3 + ", " + avnumber4 + " is " + (avnumber1 + avnumber2 + avnumber3 + avnumber4) / 4);
*/
/* opgave 1-5 1
string letter1,letter2,letter3;
Console.WriteLine("give me the first letter");
letter1 = Console.ReadLine()!;
Console.WriteLine("give me the second letter");
letter2 = Console.ReadLine()!;
Console.WriteLine("give me the third letter");
letter3 = Console.ReadLine()!;
Console.WriteLine(letter3 + letter2 + letter1);
*/
// opgave 1-5 2
/*
int width = 0; // Replace 0 with the desired value for width
int numbertri = width;
Console.WriteLine("give me the a number");
numbertri = int.Parse (Console.ReadLine()!);


int height = width;

Console.WriteLine();
for (int row=0; row < height; row++)
{
    for (int col=0; col < width; col++)
    {
        Console.Write(numbertri);
    }
    Console.WriteLine();
    width--;
}
{
    Console.WriteLine(numbertri);
}
*/




/*
// if statements
int x = 4;
int numberif = x;
if (numberif == 4)
{
    Console.WriteLine("numberif is 4");
}
*/
/*
// if else statements
int x = 4;
int numberifelse = x;
if (numberifelse > 5)
{
    Console.WriteLine("numberifelse is greater than 5");
}
else
{
    Console.WriteLine("numberifelse is less than 5");
}
*/

