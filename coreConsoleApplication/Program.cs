// Variable and Data Type

Console.WriteLine("Hello, World!");
Console.WriteLine("Let's Learn C# Programming");

string name = "Jes Aldrin Rabanal";
int age = 22;
float discount = 1000.50F;
double contactNumber = 1234567890;
char gender = 'M';
Boolean isValid = true;

Console.WriteLine("Name:" + name);
Console.WriteLine("Age:" + age);
Console.WriteLine("Discount:" + discount);
Console.WriteLine("Contact Number:" + contactNumber);
Console.WriteLine("Gender:" + gender);
Console.WriteLine("Is Valid:" + isValid);

// ****************************************** //

// Operators and Operators Precedence
/*
float baseSalary = 5000;
float hra = 0.30F;
float netSalary = (baseSalary - (baseSalary * hra));
Console.WriteLine("Base Salary: " + baseSalary);
Console.WriteLine("Net Salary: " + netSalary);

int temperature = 50;
if (temperature < 20)
    Console.WriteLine("Its Very Cold Outside.");
else
    Console.WriteLine("Its Moderate Outside.");

bool isLoggedIn = false;
bool isEmailVerified = true;
bool cardInfo = true;
if (isLoggedIn && isEmailVerified && cardInfo)
    Console.WriteLine("Allowed to make a purchase");
else
    Console.WriteLine("Stop Purchase");
*/

// ****************************************** //

// Conditional Statements
/*
bool isAuthenticated = true;
if (isAuthenticated)
    Console.WriteLine("You are logged in.");
else
    Console.WriteLine("You are not logged in.");

string result = isAuthenticated ? "You are logged in." : "You are not logged in.";
Console.WriteLine(result);

int temperature = 50;
if (temperature < 20)
    Console.WriteLine("Its Very Cold Outside.");
else if (temperature >= 20 && temperature <= 50)
    Console.WriteLine("Its Moderate Outside.");
else
    Console.WriteLine("Its too hot outside.");

string userType = "admin";
switch(userType)
{
    case "admin":
        Console.WriteLine("You have full access.");
        break;

    case "subadmin":
        Console.WriteLine("You can create or delete courses");
        break;

    case "user":
        Console.WriteLine("You can access the courses.");
        break;

    default:
        Console.WriteLine("Trial User.");
        break;
}
*/

// ****************************************** //

// Loops
/*
string[] names = new string[5] {"King Kochhar", "Sarah Bowling", "John Smith", "Roger Lee", "James Lee"};

int i;
for(i = 0; i < names.Length; i++)
    Console.WriteLine(names[i]);

Console.WriteLine();

for(i = 4; i >= 0; i--)
    Console.WriteLine(names[i]);

Console.WriteLine();

i = 0;
while (i < names.Length)
{
    Console.WriteLine(names[i]);
    i++;
}
*/

// ****************************************** //

// Jump Statements
/*
for(int i = 0; i < 10; i++)
{
    if (i == 5) break;
    Console.WriteLine("Hello World "+ i);
}

for (int i = 0; i < 10; i++)
{
    if (i == 5) continue;
    Console.WriteLine("Hello World " + i);
}

string userType = "admin";
switch (userType)
{
    case "admin":
        Console.WriteLine("You have full access.");
        goto case "user";

    case "subadmin":
        Console.WriteLine("You can create or delete courses");
        break;

    case "user":
        Console.WriteLine("You can access the courses.");
        break;

    default:
        Console.WriteLine("Trial User.");
        break;
}
*/

// ****************************************** //

// Arrays
/*
int[] marks = new int[5] { 45,56,65,67,78 };
marks[0] = 25;
marks[1] = 50;
marks[2] = 55;
marks[3] = 60;
marks[4] = 40;

foreach(int mark in marks)
    Console.WriteLine(mark);

for(int i = 0; i < marks.Length; i++)
    Console.WriteLine(marks[0]);

Console.WriteLine();

int[,] multiArray = new int[3,4] 
{ { 1,2,3,4 }, { 1,2,3,4 }, { 1,2,3,4 } };

for(int i = 0; i <= 2; i++)
{
    for(int j = 0; j <= 3; j++)
    {
        Console.Write(multiArray[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[2];
*/

// ****************************************** //

// Strings
/*
using System.Text;

string str1 = "Hello World";
string str2 = "C# Programming";
Console.WriteLine(str1);
Console.WriteLine(str1.Length);
string str3 = string.Concat(str1, str2);
Console.WriteLine(str3);
Console.WriteLine(str1.Equals(str2));

// Immutable String
string s1 = "C# Programming";
string s2 = "Java Programming";

// Mutable String
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("C# Programming");
stringBuilder.Append("Java Programming");
*/