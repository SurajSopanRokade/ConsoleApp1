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