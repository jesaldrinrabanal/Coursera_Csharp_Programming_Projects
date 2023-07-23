using coreAdvancedConcepts;
using System.Linq.Expressions;

/*
// Calculation.cs - Handling Exception in Console Application

Calculation calculation = new Calculation();
//calculation.calculate(100, 0);
calculation.calculateAnother();
*/

// ****************************************** //

/*
// Anonymous Type

var obj = new
{
    firstName = "Jes Aldrin",
    lastName = "Rabanal",
    salary = 30000,
    address = new { streetName = "Sangandaan", city = "Caloocan City"},
    projects = new[]
    {
        new { projectName = "Lifestyletravel.ph", projectDuration = "3 Months" },
        new { projectName = "ARIS", projectDuration = "5 Months" }
    }
};

Console.WriteLine(obj.firstName);
Console.WriteLine(obj.lastName);
Console.WriteLine(obj.salary);
Console.WriteLine(obj.address.streetName);
Console.WriteLine(obj.address.city);
foreach(var project in obj.projects)
{
    Console.WriteLine(project.projectName + ": " + project.projectDuration);
}
*/

// ****************************************** //

// DelegateExample.cs - Delegates

/*CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
CalculateDelegate c2 = new CalculateDelegate(DelegateExample.multiplication);

c1(100);
Console.WriteLine(DelegateExample.getNumber());

c2(200);
Console.WriteLine(DelegateExample.getNumber());*/

/*
CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);

c1(100);
Console.WriteLine(DelegateExample.getNumber());
c1 += new CalculateDelegate(DelegateExample.addition);
c1 += new CalculateDelegate(DelegateExample.multiplication);

c1(100);
Console.WriteLine(DelegateExample.getNumber());
*/

// ****************************************** //

/*
// EventsExample.cs - Events

// The Subscriber Model
EventsExample events =  new EventsExample();
events.event_OddNumber += new EventsExample.delegate_OddNumber(EventMessage);
events.addition();
Console.ReadLine();

static void EventMessage()
{
    Console.WriteLine("Event Executed: Odd Number");
}
*/

// ****************************************** //

/*
// AnonymousMethod.cs - Anonymous Methods
AnonymousMethodExample.InvokeMethod();
*/

// ****************************************** //

/*
// Expression Lambda

var numbers = new int[] { 2, 5, 6, 5, 1, 3, 5, 7 };
var count = numbers.Count(x => x == 5);
Console.WriteLine(count);

// Statement Lambda

List<int> numbers2 = new List<int> { 2, 5, 6, 5, 1, 3, 5, 7 };
count = numbers.Count(x => { return x == 5; });
Console.WriteLine(count);
*/

// ****************************************** //

// Expression Tree

Func<string, string, string> stringJoins = (str1, str2) => string.Concat(str1, str2);

Expression<Func<string, string, string>> stringJoinExpr = (str1, str2) => string.Concat(str1, str2);

var func = stringJoinExpr.Compile();
var result = func("Hello", "World");
Console.WriteLine(result);

// OR

result = stringJoinExpr.Compile()("Hello", "Everyone");
Console.WriteLine(result);
