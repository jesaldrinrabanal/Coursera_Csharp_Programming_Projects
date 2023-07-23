using coreObjectOrientedConcepts;

/*
// Student.cs - Classes and Objects, Encapusulation and Abstraction

Student student = new Student();
//student.acceptDetails();
student.displayDetails();
//Console.WriteLine(student.studentId);

Console.WriteLine();

// Constructor

Student student1 = new Student(102, "Aldrin");
student1.displayDetails();
*/

// ****************************************** //

/*
// Marks.cs - Inheritance

Marks marks = new Marks();
marks.acceptDetails();
marks.displayDetails();
*/

// ****************************************** //

/*
// BankAccount.cs & SavingAccount.cs - Abstract Clasess

SavingAccount savingAccount = new SavingAccount();
savingAccount.getMessage();
savingAccount.deposit();
savingAccount.withdraw();
savingAccount.balance();

Console.WriteLine();

// IBankAccount.cs, IManageAccount.cs & SavingAcc.cs

SavingAcc savingAcc = new SavingAcc();
savingAcc.openAccount();
savingAcc.deposit();
savingAcc.withdraw();
savingAcc.balance();
savingAcc.closeAccount();
*/

// ****************************************** //

/*
// Calculate.cs - Static Class and Static Methods

Console.WriteLine(Calculate.count);
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.decrement());
*/

// ****************************************** //

/*
// IntExtensions.cs - Extension Methods

int number = 100;

bool result = number.IsGreaterThan(1000);
Console.WriteLine(result);
*/

// ****************************************** //

/*
// EmployeeMethods.cs & EmployeeProps.cs - Partial Class and Partial Methods

var employee = new Employee();
Console.WriteLine(employee.EmpId);
Console.WriteLine(employee.EmpName);
employee.DisplayDetails();
*/

// ****************************************** //

// User.cs - Properties
/*
User user = new User();
user.Name = "Jes Aldrin Rabanal";
user.Age = 22;
//user.CompanyName = "ABC";
Console.WriteLine(user.Name);
Console.WriteLine(user.CompanyName);
Console.WriteLine(user.Age);
*/

// ****************************************** //

/*
// StringIndexerType.cs - Indexers

StringIndexerType stringIndexerType = new StringIndexerType();
stringIndexerType[0] = "String One";
stringIndexerType[1] = "String Two";
stringIndexerType[2] = "String Three";
stringIndexerType[3] = "String Four";

for(int i = 0; i < 10; i++)
    Console.WriteLine(stringIndexerType[i]);
*/

// ****************************************** //

// EnumDemo.cs - Enum

EnumDemo enumDemo = new EnumDemo();
enumDemo.display();