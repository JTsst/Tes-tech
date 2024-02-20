
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
/*int multiplyNumber;
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
*/
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

// switch statements 
//switch (expression) is the same as if (expression == value)
//case value: is the same as if (expression == value) 
//break; is the same as break;
//switch comparisons done with <, >, <=, >=, ==, !=, and the is and as operators

// opgave 11
/*
int a, b, c;
double d, x1, x2;

Console.WriteLine("give me the first number a");
a = int.Parse (Console.ReadLine()!);
Console.WriteLine("give me the second number b");
b = int.Parse (Console.ReadLine()!);
Console.WriteLine("give me the third number c");
c = int.Parse (Console.ReadLine()!);

d = b*b - 4*a*c;

if (d < 0){
    Console.WriteLine("d is less than 0 and it is = " + d + " so");
    Console.WriteLine("no real roots");
    
}
else if (d == 0){
    x1 = -b / (2*a);
    Console.WriteLine("there is only one root and that is = " + x1);
}
else {
    x1 = (-b + Math.Sqrt(d)) / (2*a);
    x2 = (-b - Math.Sqrt(d)) / (2*a);
    Console.WriteLine("there is two roots");
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}
*/
//opgave 12 
/*int rollNo, marksChem, marksPhy, marksPC, totalMarks;
string studentName, division="";
double studentAverage;

Console.WriteLine("give roll number");
rollNo = int.Parse (Console.ReadLine()!);
Console.WriteLine("give student name");
studentName = Console.ReadLine()!;
Console.WriteLine("give marks in chemistry");
marksChem = int.Parse (Console.ReadLine()!);
Console.WriteLine("give marks in physics");
marksPhy = int.Parse (Console.ReadLine()!);
Console.WriteLine("give marks in computer application");
marksPC = int.Parse (Console.ReadLine()!);

totalMarks = marksChem + marksPhy + marksPC;
studentAverage = totalMarks / 3;

switch (studentAverage){
    case < 35:
        division = "fail";
        break;
    case < 48:
        division = "pass";
        break;
    case < 60:
        division = "second division";
        break; 
    case >= 60:
        division = "first division";
        break;
}
Console.WriteLine("roll number " + rollNo);
Console.WriteLine("student name " + studentName);
Console.WriteLine("your total mark is " + totalMarks);
Console.WriteLine("your average is " + studentAverage);

switch (studentAverage){
    case < 35:
        division = "fail";
        break;
    case < 48:
        division = "pass";
        break;
    case < 60:
        division = "second division";
        break; 
    case >= 60:
        division = "first division";
        break;
}

Console.WriteLine("your division is " + division);
*/
//opgave 13
/*int temperature;
Console.WriteLine("give me the temperature of the weather");
temperature = int.Parse (Console.ReadLine()!);

switch (temperature){
    case < 0:
    Console.WriteLine("freezing weather");
    break;
    case < 10:
    Console.WriteLine("very cold weather");
    break;
    case < 20:
    Console.WriteLine("cold weather");
    break;
    case < 30:
    Console.WriteLine("normal in temp");
    break;
    case < 40:
    Console.WriteLine("its hot");
    break;
    default:
        Console.WriteLine("its TOO HOT");
        break;
}
*/
//opgave 14
/*int side1, side2, side3;

Console.WriteLine("give me the first side");
side1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("give me the second side");
side2 = int.Parse (Console.ReadLine()!);
Console.WriteLine("give me the third side");
side3 = int.Parse (Console.ReadLine()!);

if (side1 == side2 && side2 == side3){
    Console.WriteLine("this is an equilateral triangle");
}
else if (side1 == side2 || side2 == side3 || side1 == side3){
    Console.WriteLine("this is an isosceles triangle");
}
else {
    Console.WriteLine("this is a scalene triangle");
}
*/
//opgave 15
/*int number1, number2, number3, total;
Console.WriteLine("give me the first number");
number1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("give me the second number");
number2 = int.Parse (Console.ReadLine()!);
Console.WriteLine("give me the third number");
number3 = int.Parse (Console.ReadLine()!);

total = number1 + number2 + number3;

switch (total){
    case 180:
        Console.WriteLine("this is a valid triangle");
        break;
    default:    
        Console.WriteLine("this is not a valid triangle");
        break;
}
*/
//opgave 16
/*char word;
Console.WriteLine("give me a letter");

word = Convert.ToChar(Console.ReadLine()!.ToLower());
switch (word){
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
    case 'y':
        Console.WriteLine("this is a vowel");
        break;
    default:
        Console.WriteLine("this is a consonant");
        break;
}
*/
//opgave 17
/*int number1, number2, total;
Console.WriteLine("tell me how much money you have");
number1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("tell me how much you want to spend");
number2 = int.Parse (Console.ReadLine()!);

total = number1 - number2;
switch(total){
    case < 0:
        Console.WriteLine("you lost "+ total + " money");
        break;
    case > 0: 
        Console.WriteLine("you gained "+ total + " money");
        break;
    default: 
        Console.WriteLine("you have "+ total + " money");
        break;
}
*/

//opgave 18
/*string customerName, customerID;
int units;
double charge, surcharge = 0, netAmount, amountCharge = 0;

Console.WriteLine("give me your name");
customerName = Console.ReadLine()!;
Console.WriteLine("give me your ID");
customerID = Console.ReadLine()!;
Console.WriteLine("give me the units you used");
units = int.Parse (Console.ReadLine()!);

switch(units){
    case < 199:
        charge = 1.20;
        break;
    case < 400:
        charge = 1.50;
        break;
    case < 600:
        charge = 1.80;
        break;
    default: 
        charge = 2.00;
        break;
}
amountCharge = units * charge;
if (amountCharge > 400){
    surcharge = amountCharge * 0.15;
}
netAmount = amountCharge + surcharge;

Console.WriteLine("customer ID " + customerID);
Console.WriteLine("customer name " + customerName);
Console.WriteLine("units used " + units);
Console.WriteLine("amount charges per unit " + charge);
Console.WriteLine("surcharge amount " + surcharge);
Console.WriteLine("net amount paid by the customer " + netAmount);
*/
/*char grade;
Console.WriteLine("give me your grade");
grade = Convert.ToChar(Console.ReadLine()!.ToLower());
switch (grade){
    case 'e':
        Console.WriteLine("excellent");
        break;
    case 'v':
        Console.WriteLine("very good");
        break;
    case 'g':
        Console.WriteLine("good");
        break;
    case 'a':
        Console.WriteLine("average");
        break;
    case 'f':
        Console.WriteLine("fail");
        break;
    default:
        Console.WriteLine("invalid grade");
        break;
}
*/
//opgave 20
/*int numberDay;
Console.WriteLine("give me a number between 1-7 then ill tell you what day it is");
numberDay = int.Parse (Console.ReadLine()!);
switch (numberDay){
    case 1:
        Console.WriteLine("monday");
        break;
    case 2:
        Console.WriteLine("tuesday");
        break;
    case 3:
        Console.WriteLine("wednesday");
        break;
    case 4:
        Console.WriteLine("thursday");
        break;
    case 5:
        Console.WriteLine("friday");
        break;
    case 6:
        Console.WriteLine("saturday");
        break;
    case 7:
        Console.WriteLine("sunday");
        break;
    default:
        Console.WriteLine("invalid number");
        break;
}
*/
// for loop opgave 1 
/*for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
*/
// opgave 2
/*int i, sum = 0;
for (i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    sum = sum + i;
}

Console.WriteLine(sum);
*/
// opgave 3
/*int i, sum = 0, n;
Console.WriteLine("give me a number");
n = int.Parse (Console.ReadLine()!);
for (i = 1; i <= n; i++)
{
    Console.WriteLine(i);
    sum = sum + i;
}

Console.WriteLine(sum);
*/
// opgave 4
/*int i, n, sum = 0;
double average;

Console.WriteLine("input 10 numbers");
for (i = 1; i <= 10; i++)
{
    Console.WriteLine("Number-{0} :",i);
    n = int.Parse (Console.ReadLine()!);
    sum = sum + n;
}
average = sum / 10.0;
Console.WriteLine("the sum of 10 numbers is : {0}", sum);
Console.WriteLine("the average of 10 numbers is : {0}", average);
*/
// opgave 5
/*int i,ctr;
    Console.Write("Input number of terms : ");
    ctr= Convert.ToInt32(Console.ReadLine());	
    for(i=1;i<=ctr;i++)
{
	 Console.Write("Number is : {0} and cube of the {1} is :{2} \n",i,i, (i*i*i));     
}
*/

//whileloop opgave 1.1

/*int i, sumeven = 0, sumodd = 0, n = 0;
Console.WriteLine("give me a number and even and odd will be sumed up to that number");
while(n == 0)
{
    Console.WriteLine("give me a number");
    i = int.Parse (Console.ReadLine()!);
    if (i % 2 == 0){
        sumeven = sumeven + i;
        Console.WriteLine("even number {0} and odd number {1}",sumeven,sumodd);
    }
    else {
        sumodd = sumodd + i;
        Console.WriteLine("even number {0} and odd number {1}",sumeven,sumodd);
    }
    
}
*/
// opgave 1.2
/*int i1, i2, HCF, n = 0;

while(n == 0){
    Console.WriteLine("give me a number");
    i1 = int.Parse (Console.ReadLine()!);
    Console.WriteLine("give me another number");
    i2 = int.Parse (Console.ReadLine()!);

    if(i1 % 2 == 0 | i2 % 2 == 0){
        
    }

}
*/
// vinterferie opgave 
/*
int i = 5, j = 10, n = 0, sum = -2 ;
i = j + j;

if (i == 10){
    n = 1;
}
else if (i == 15){
    n = 2;
}
else if (i == 20){
    n = 3;
}
else {
    n = 4;
}
sum = n + i - j;
sum = sum++;
Console.Write(sum);
*/
// opgave 
/*Console.WriteLine("input a number");
int number = Convert.ToInt32(Console.ReadLine());

If (number > 0)
{
Console.WriteLine("the input is bigger then 0")
    if (number > 10)
    { 
     number = number/2;
    }
Console.WriteLine($"the output is {number}",number) 
}
*/
Console.WriteLine("input a number");
int number = Convert.ToInt32(Console.ReadLine());

if(number>0)
{
    Console.WriteLine("the input is bigger then 0");
    if(number>10)
    {
        number = number/2;
    }
    Console.WriteLine($"the output is {number}");
}


