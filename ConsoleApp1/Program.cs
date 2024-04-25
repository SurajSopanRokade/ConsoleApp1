/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

//short s1 = 100; // 2 bytes
//int no = 10; //4 bytes
//long l1 = 455453; // 8 bytes
//float f1 = 20.33F;  // 4 bytes
//double d1 = 45.55; //8 bytes
//decimal d2 = 47.88M; //16 bytes

//print the output

//Console.WriteLine("integer number is "+no+" decimal value is "+d2); //concatination using + sign

//using placeholder
//Console.WriteLine("integer number is {0} and float value is {1}", no, f1);

//String interpolation -->$ OR

//Console.WriteLine($"integer number is {no} and float value is {f1}");

// accept value from user --> console.Readline() --> return string

/*Console.WriteLine("Enter your name");
String name = Console.ReadLine();

Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your salary");
double salary = Convert.ToDouble(Console.ReadLine());*/

//Console.write line("Hello"+name);
//Console.WriteLine($"Hello {name}, your age is {age} and salary is {salary}");

//working with property
//property initializer syntax
/*using ConsoleApp1;
using System.ComponentModel;*/

/*Product2 p1 = new Product2();
p1.Code = 101;
p1.Name = "Mouse";
p1.Price = 999;

Console.WriteLine($"{p1.Code}, {p1.Name}, {p1.Price}");*/

// object initializer syntax
/*Product p2 = new Product { Code = 102, Name = "Keyboard", Price = 399 };
Console.WriteLine($"{p2.Code}, {p2.Name}, {p2.Price}");*/

//create book class with auto implemented properties
//create object with property syntax and object initializer syntax
//display book details

/*Book b = new Book();
b.bid = 1;
b.price = 234;
b.bname = "abc";
b.bauth = "def";

Console.WriteLine($"{b.bid},{b.bname},{b.bauth},{b.price}"); 

Book b2  = new Book { bid=3, price=2345, bauth="jfghjd", bname="dgfug"};

Console.WriteLine($"{b2.bid},{b2.bname},{b2.bauth},{b2.price}");*/

/*using ConsoleApp1;

Employee emp = new Employee(1, "Amol", 2000, 1000, 250);
emp.CalculateSalary();
Console.WriteLine(emp.Display());

//object of child class

Manager manager = new Manager(2, "suraj", 3000, 2000, 500, 1000);
manager.CalculateSalary();
Console.WriteLine(manager.Display());

//create ref of base class but object of child class
Employee emp1 = new Manager(3, "Kishor", 4000, 2000, 500, 2000);
emp1.CalculateSalary();
Console.WriteLine(emp1.Display());*/

// dynamic / run time binding in polymorphism / in method overriding
// e1.calculateSalary -> at run time method get bind with object


// Method overloading
// same method name but different parameter
//it is in same class
// it is for ease of developer as multiple method names no need to remember
//return type is not considered in method overloading
//we can overload the constructor, static methods also

/*using ConsoleApp1;

Calculation calculation = new Calculation();
calculation.Addition(10, 20);
calculation.Addition(20, 30, 45);
calculation.Addition(30, 3.4);

//method overloading also called as static polymorphism or early binding or compiletime binding
//at compiletime compiler knows which method has to execute based on parameter list
//good example of method overloading is Console.WriteLine();
Console.WriteLine("suraj");*/

// how to restrain inheritance

// sealed --> it is used to restrict the inheritance in c#. in java we use final keyword
//it is also used to restrict method override

//public sealed class Employee
//{
//}
//why sealed
//if we dont want anyone to modify basic feature
// eg. employee ka salarycal

//for variable Const and readonly

//Difference between overloading and overriding
//1. in same class               it is in child class
//2. parameters are diff         it is same
//3. return type not consider    it should be same
//4. static can overload         cannot override static
//5. it is early binding         it is late/ dynamic binding

//const                           Readonly
//1. Must assign the value         It is optional
//2. const is compile time const   value fixed at runtime (inside constructor)
//3. const can be a local variable readonly must be data member/ instance member


// abstract class
// abstract means which does not have implementation
// a. In class if we have a method which doesnot have implementation we will make a method as an abstract method
// b. If class contain abstract method class must be abstract class
// c. Abstract may contain abstract as well as non abstract methods
// d. If any child class extends the abstract class needs to provide defination/ imp to the abstract method
// e. we cannot create object of abstract class

/*using ConsoleApp1;

*//*Circle c = new Circle(5);
c.CalculateArea();
Console.WriteLine(c.print());*//*

Rectangle r = new Rectangle(23, 3);
r.CalculateArea();
Console.WriteLine(r.Print());*/

/*using ConsoleApp1;

Job j1 = new Job(10000);
Console.WriteLine(j1.PayTax());

Business b1 = new Business(10000);
Console.WriteLine(b1.PayTax());*/
//Explicit interface implementation
//If two different interfaces have a same method signature & one class implements
//both the interfaces , then we will use explicit interface implementation


/*//working with explicite interface implemenation
using ConsoleApp1;

ICustomer c1 = new Transaction();
Console.WriteLine(c1.Print()); // customer interface method get call

IOrder o1 = new Transaction();
Console.WriteLine(o1.Print()); // order interface method get call*/


// Partial class in c#
// 1. it is incomplete class
// 2. when two different files have a same class names, but code is different methods are different
// 3. so we will make the class public
// 4. it is for faster development
// 5. one class may have multiple task

/*using ConsoleApp1;

Calc c1 = new Calc();
Console.WriteLine(c1.Add(34,45));
Console.WriteLine(c1.Sub(67,45));*/

//Partial methods in c#
//a. It is used to create method hooks in c# (chain)
//b. partial method are by default private
//c. Partial keyworld must be written for both the methods in files
//d. must have void return type
//e. signiture must be same
//One class may have multiple task to implement, we can share task with multiple developers,
//so we can integrate in one project with same name of class, with partial keyword


/*using ConsoleApp1;

Calc c1 = new Calc();
c1.Sub(67, 45);
c1.Div(10, 5);*/


//Array in c#
//a. Array is collection of similar data elements which stores data at contiguous memory location
//b. Size needs to define at compiletime
//c. Zero index based

// eg. store rollno od 30 students
// store rainfall for a week --> 7 days
// int [] arr1 = new int [5] {10, 20, 30, 40, 50} this only syntax is allowed in array
// 
/*int[] arr1 = new int[5] {10,20,30,40,50 }; // adding size is optional if we initialized it
Console.WriteLine(arr1[3]);
arr1[4] = 500;
Console.WriteLine(arr1[4]);

//print all the values

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arr1[i]);
}
int[] arr2 = new int[10];// Size initialization is must*/

//create an array of product class with 5 products and display the details
//product -> properties
/*int[] arr1 = new int[5] { 10, 20, 30, 40, 50 };
//foreach loop
foreach (int item in arr1)
{
    Console.WriteLine(item);
}*/

/*using ConsoleApp1;

        Product3[] products = new Product3[]{
            new Product3("Visual Studio", "Integrated development environment (IDE) from Microsoft", 499, ".NET Development"),
            new Product3("SQL Server", "Relational database management system from Microsoft", 999, "Database"),
            new Product3("Azure DevOps", "Cloud-based services for collaboration on software development projects", 789, "Development Tools"),
            new Product3("ASP.NET Core", "Cross-platform, high-performance, open-source framework for building modern, cloud-based, Internet-connected applications", 0, "Web Development"),
            new Product3("Entity Framework Core", "Object-relational mapping framework from Microsoft", 0, "Data Access")
        };


for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine("Product " + (i + 1) + ":");
    Console.WriteLine("Name: " + products[i].name);
    Console.WriteLine("Description: " + products[i].description);
    Console.WriteLine("Price: $" + products[i].price);
    Console.WriteLine("Category: " + products[i].category);
    Console.WriteLine("------------------------");
}*/


/*int[] arr1 = new int[] { 80, 45, 12, 78, 1 };
int[] arr2 = new int[3];

Console.WriteLine("Before sort");
foreach (int i in arr1)
{
    Console.WriteLine(i);
}
Console.WriteLine("After sort");
Array.Sort(arr1);
foreach (int i in arr1)
{
    Console.WriteLine(i);
}
Console.WriteLine("After reverse");
Array.Reverse(arr1);
foreach (int i in arr1)
{
    Console.WriteLine(i);
}
// copy the 3 elements 45,12,1 in the new array

Array.Copy(arr1, 2, arr2, 0, 3);

Console.WriteLine("Copied elements:");
foreach (int i in arr2)
{
    Console.WriteLine(i);
}

Array.Clear(arr1);
Console.WriteLine("After clear");
foreach (int i in arr1)
{
    Console.WriteLine(i);
}

Console.WriteLine("_________________________________________________________________________");
string[] arr3 = new string[] { "suraj", "amit", "yogesh", "abhishek"};
string[] arr4 = new string[3];

Console.WriteLine("Before sort");
foreach (string i in arr3)
{
    Console.WriteLine(i);
}
Console.WriteLine("After sort");
Array.Sort(arr3);
foreach (string i in arr3)
{
    Console.WriteLine(i);
}
Console.WriteLine("After reverse");
Array.Reverse(arr3);
foreach (string i in arr3)
{
    Console.WriteLine(i);
}
// copy the 3 elements 45,12,1 in the new array

Array.Copy(arr3, 1, arr4, 0, 3);

Console.WriteLine("Copied elements:");
foreach (string i in arr4)
{
    Console.WriteLine(i);
}

Array.Clear(arr1);
Console.WriteLine("After clear");
foreach (int i in arr1)
{
    Console.WriteLine(i);
}*/

//2d array
//maintain data in row and column format
// eg. Matrix
//syntax           row, column
/*int[,] arr = new int[3, 4];
int[,] arr2 = new int[3, 4]
{
    {1,2,3,4 },
    {10,20,30,40 },
    {100,200,300,400 }
};

arr2[2, 3] = 4000;

// nested for loop

for (int i = 0; i < arr2.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        Console.Write($"arr2[{i},{j}] ---> {arr2[i,j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine("Using for each");
foreach (int i in arr2)
{
    Console.WriteLine(i);
}
// code to addition of 3 by 3 matrix
//accept data from user
int[,] arr1 = new int[3, 3];
int[,] arr3 = new int[3, 3];
int[,] sum = new int[3, 3];


Console.WriteLine("Enter elements for arr1");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Enter element [{i}, {j}]: ");
        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}


Console.WriteLine("Enter elements for arr3");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Enter element [{i}, {j}]: ");
        arr3[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}


Console.WriteLine("Sum : ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        sum[i, j] = arr1[i, j] + arr3[i, j];
        Console.Write(sum[i, j]);
    }
    Console.WriteLine();
}*/

//Jagged Array
//It is called as an array of arrays in c#
// we can keep row size fixed 


//syntax
using ConsoleApp1;
using System.Collections;
using System.Text;

/*int[][] arr = new int[4][];  // rows are fixed 

arr[0] = new int[] { 1, 2, 3, 4, 5 };  //0th row has 5 columns
arr[1] = new int[] {10,20,30};
arr[2] = new int[] { 100, 200};
arr[3] = new int[] { 1000 };

//row
for (int i = 0; i < arr.Length; i++)  // arr.length return size of row
{
    for(int j = 0; j < arr[i].Length; j++)   // col
    {
        Console.Write($"{arr[i][j]}"+"\t");
    }
    Console.WriteLine();
}

Console.WriteLine("____________________________For each loop_______________________________");
foreach (int[] item in arr)
{
    foreach (int i in item)
    {
        Console.Write($"{i}"+"\t");
    }
    Console.WriteLine();
}*/

//String
//a. Collection of characters
//b. It is immutable
//c. String is a reference type in c#
//d. IsEmptyOrNull(), concat(), charAt(), tocharArry(), toUpper(), toLower(), indexOf(), LastindexOf()
//substring(), contains(), split(), trim(), Replace(), remove(), clear(), capacity(), length

/*string str = "Hello to all";
// need to convert string to tochararray
char[] c=str.ToCharArray();
//split --> string to string[] using condition
string[] result = str.Split(' ');
//result[0]="hello"
//result[1]="to"
//result[2]="all"
Console.WriteLine("Split string array");
foreach (string r in result)
{
    Console.WriteLine(r);
}
Console.WriteLine("Character array");
foreach (char r1 in c)
{
    Console.WriteLine(r1);
}
if (string.IsNullOrEmpty(str))
{
    Console.WriteLine("String is empty or null");
}
else
{
    Console.WriteLine("String is not null");
}*/

//String builder
//a. It is a mutable class
//b. Not thread safe
//c.performance is slow
//d.String builder always alocate more memory

/*StringBuilder sb= new StringBuilder();
sb.Append("Hello");
sb.Clear();

// hw  Understand difference between lenght and capcity

Console.WriteLine("Capacity : "+sb.Capacity);
Console.WriteLine("Length : "+sb.Length);*/

//Collections in c#
//Why we need collections
//1. when size is unknown that time we cannot use an array
//


//Collections
//Collections

/*When we want to process / mange objects dynamically (run time) we will use collections






                                 Collections


Non Generic Collection → when we want to manage different types of objects or elements we will use non generic collections
Dissimilar type of data
		
			Classes
ArrayList
Stack
Queue
Hashtable
 

                        Interfaces
IEnumerable
IEnumerator
IComparable
ICompareotr
IList
ICollection



Boxing
Unboxing
*/

//ArrayList
/*using System.Collections;*/
/*int[] arr = new int[] { 1, 2, 3 };
ArrayList list = new ArrayList();*/ // u can also set default value of arraylist
//methods of arraylist

/*list.Add(10);
list.Add(20.3);
list.Add("Hello");
list.Add(new Product { ID = 1, Name = "pen", price = 10 });*/

/*list.Add(10);
list.Add(20);
list.Add(30);
list.AddRange(arr);
Console.WriteLine("_________________________________________________________");
foreach (int i in list)
{
    Console.WriteLine(i);
}*/

/*list.RemoveAt(2);  // remove element based on index
list.Remove(10);  // remove based on object / element present in the collection
Console.WriteLine("_________________________________________________________");
foreach (int i in list)
{
    Console.WriteLine(i);
}

list.RemoveRange(1, 3);  // remove multiple values from collection
Console.WriteLine("_________________________________________________________");
foreach (int i in list)
{
    Console.WriteLine(i);
}
list.Clear(); //remove all the elements*/

/*list.Sort();  //asc
list.Reverse();  //desc
Console.WriteLine("_________________________________________________________");
foreach (int i in list)
{
    Console.WriteLine(i);
}
Console.WriteLine($"Total elements in list = {list.Count}"); */ // length of list we use .count

//Stack
//LIFO -->Last in first out
//Push()--> add stack
//pop--> remove from stack
//count -->to get total count of elements
//peek()--->select top element of stack

/*Stack stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);

//to remove top element
stack.Pop();

Console.WriteLine(stack.Peek());

foreach (int i in stack)
{
    Console.WriteLine(i);
}
*/

/*Person p1 = new Person();
try
{
    p1.acceptAge(17);
}
catch (AgeException ex) 
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex) // we can handle it with Exception class because we passed it to base class
{
    Console.WriteLine(ex.Message);
}*/

//Accept name from user and check if name is null or empty raise an exception
//message: name is required

/*Person2 p = new Person2();
try
{
    p.Accept("Suraj");
}
catch(NameException ex)
{
    Console.WriteLine(ex.Message);
}*/

//Delegates and events in c#
//Delegates
//a. It is reference type in c#
//b. It is used to hold the method reference (address)
//c. Delegets need to delcared in the namespace
//d. syntax of delegate must match with szntax of method -> return type and parameters

//hold method reference
/*Calculator c= new Calculator();
//create object of delegate and pass the method name to hold the address

MyDelegate mydelegate = new MyDelegate(c.Add);
int result = mydelegate.Invoke(20, 40);
Console.WriteLine(result);*/

//types of delegate
//1. Singlecast delegate -> one delegate hold one method reference.
//2. Multicast delegate -> one delegate holds multiple method references.
//  a. method syntax & delegate syntax must be same

/*mydelegate += new MyDelegate(c.Sub);

int result2 = mydelegate.Invoke(20, 10);
Console.WriteLine(result2);

//Internally create invokation list and hold all method ref in sequence
mydelegate += new MyDelegate(c.Mul);

int result3 = mydelegate.Invoke(20, 10);
Console.WriteLine(result3);
//to get invokation list to retrive the methods from delegate
Delegate[] list = mydelegate.GetInvocationList();
foreach (Delegate item in list)
{
    Console.WriteLine(item.Method);
    Console.WriteLine(item.DynamicInvoke(45, 35));
}*/

//Event
//a. Actions raised by the user is called event in programming
//b. Expamle click , change , hover etc ...
//c. Event is a member of class/ interface
//d. Event needs to bind with delegate

//will create bank class
//define some dafault balance
// withdraw
//event --> low balance
//5000-->6000

//class, delegate, event

//1. event raise
//2. notification to delegate
//3. it call method and show msg

/*Bank b = new Bank();
MyMessage msg = new MyMessage();
//if lowbalance event raised then call the myBankDelegate then delegate will call balance msg method
b.LowBalance += new MyBankDelegate(msg.BalanceMsg);
Console.WriteLine("Initial balance");
Console.WriteLine(b);

b.Withdraw(1000);
Console.WriteLine("After withdraw 1000");
Console.WriteLine(b);

b.Withdraw(6000);
Console.WriteLine("After withdraw 6000");
Console.WriteLine(b);
*/