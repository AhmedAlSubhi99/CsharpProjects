using System;
using System.Buffers.Text;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Even or Odd
            //Ask the user to enter a number and check whether it is even or odd using an if-else statement.

            //int num1;
            //Console.WriteLine("Enter The Number");
            //num1 = int.Parse(Console.ReadLine());

            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("The number is Even");
            //}
            //else
            //{
            //  Console.WriteLine("The number is odd");
            //}

            //Console.WriteLine("--------------------------------------------------------------");

            // 2.Largest of Three Numbers
            //Write a program that takes three numbers as input and prints the largest one using if-else.

            //int num1, num2, num3;
            //Console.WriteLine("Enter The Number1");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The Number2");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The Number3");
            //num3 = int.Parse(Console.ReadLine());

            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine("The largest Number = " + num1);
            //}
            //else if (num2 > num3 && num2 > num1)
            //{
            //    Console.WriteLine("The largest Number = " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("The largest Number = " + num3);
            //}

            //Console.WriteLine("--------------------------------------------------------------");

            //3.Temperature Converter
            //Convert a given temperature from Celsius to Fahrenheit using the formula: F = (C×9 / 5)+32

            //double F, C;
            //Console.WriteLine("Enter The Celsius Degree");
            //C = double.Parse(Console.ReadLine());

            //F = ((C * 9 / 5) + 32);
            //Console.WriteLine("The Fahrenheit Degree is " + F);

            //Console.WriteLine("--------------------------------------------------------------");

            //4.Simple Discount Calculator
            //Ask the user to enter the price of an item. If the price is above $100, apply a 10 % discount; otherwise, no discount applies.Print the final price.

            //double price, FinalPrice;
            //Console.WriteLine("Enter The price");
            //price = double.Parse(Console.ReadLine());
            //double discount = 0;

            //if ( price > 100)
            //{
            //    discount = (price * 10 / 100) ;
            //    FinalPrice = price - discount
            //    Console.WriteLine("The price is" + FinalPrice);
            //}
            //else
            //{
            //    Console.WriteLine("no disccount applies, The price is " + price );
            //}

            //Console.WriteLine("--------------------------------------------------------------");

            // 5.Grading System
            // Take a student's score as input and print the corresponding grade: 
            //• 90 - 100: A
            //• 80 - 89: B
            //• 70 - 79: C
            //• 60 - 69: D
            //• Below 60: F

            //int StudentGrade;
            //char grade: ---> For add variable named by grade.
            //Console.WriteLine("Enter The grade");
            //StudentGrade = int.Parse(Console.ReadLine());

            //if (StudentGrade >= 90 )
            //{
            //    grade= "A";
            //    Console.WriteLine(grade);
            //}
            //else if ( StudentGrade >= 80)
            //{
            //    grade= "B";
            //    Console.WriteLine(grade);
            //}
            //else if ( StudentGrade >= 70)
            //{
            //    grade= "C";
            //    Console.WriteLine(grade);
            //}
            //else if (StudentGrade >= 60)
            //{
            //    grade= "D";
            //    Console.WriteLine(grade);
            //}
            //else
            //{
            //    grade= "F";
            //    Console.WriteLine(grade);
            //}

            //Console.WriteLine("--------------------------------------------------------------");

            //6.Swap Two Numbers
            //Ask the user to enter two numbers and swap them.

            //int num1, num2, s;
            //Console.WriteLine("Enter The num1");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The num2");
            //num2 = int.Parse(Console.ReadLine());

            //s = num1;
            //num1 = num2;
            //num2 = s;

            //Console.WriteLine("The Swap from num1 to num2 is" + s);

            //Console.WriteLine("--------------------------------------------------------------");

            //7. Days to Weeks and Days Converter
            //Ask the user to enter a number of days and convert it into weeks and remaining days.


            //int Days, Weeks , remainingDays;
            //Console.WriteLine("Enter The Num Of Day");
            //Days = int.Parse(Console.ReadLine());

            //Weeks = (Days % 365) / 7 ;
            //remainingDays = (Days % 365) % 7 ;

            //Console.WriteLine("Weeks = " + Weeks);
            //Console.WriteLine("remainingDays = " + remainingDays);

            //Console.WriteLine("--------------------------------------------------------------");

            // 8.Electricity Bill Calculator
            //Ask the user for the number of units consumed and calculate the electricity bill based on these rules: 
            // • Up to 100 units → $0.5 per unit 
            //  • 101 - 300 units → $0.75 per unit 
            //• 301 + units → $1 per unit

            //double unit, EB ;
            //Console.WriteLine("Enter The Num Of units");
            //unit = double.Parse(Console.ReadLine());

            //if (unit <= 100)
            //{
            //    EB = ((unit * 0.5) ) ;
            //    Console.WriteLine("EB = " + EB);
            //}
            //else if (300 >= unit && unit >= 101 )
            //{ 
            //    EB = (unit * 0.75 );
            //    Console.WriteLine("EB = " + EB);
            //}
            //else
            //{ 
            //   EB = (unit * 1);
            //   Console.WriteLine("EB = " + EB);
            //}

            //Console.WriteLine("--------------------------------------------------------------");

            // 9.Simple Calculator
            //Write a program that takes two numbers and an operator (+, -, *, /) as input and performs the operation.
            //note: char op = console.ReadKey().KeyChar; ----> for read operator in one single word(letter).

            //int num1, num2, result ;
            //string op;

            //Console.WriteLine("Enter The Num1");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The Num2");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operator");
            //op = (Console.ReadLine());

            //if (op == "+")
            //{
            //    result = num1 + num2;
            // Console.WriteLine("result = " + result);
            //}
            //else if (op == "-")
            //{
            //    result = num1 - num2;
            //    Console.WriteLine("result = " + result);
            //}
            //else if (op == "*")
            //{
            //    result = num1 * num2;
            //    Console.WriteLine("result = " + result);
            //}
            //else if (op == "/" )
            //{
            //    result = num1 / num2;
            //    Console.WriteLine("result = " + result);
            //}
            //else
            //{ 
            //    Console.WriteLine("result = no have operator " );

            //}//Console.WriteLine("--------------------------------------------------------------");

            //Simple Calculator(Switch-Case) 
            //C# Part2 Exercises 
            //  Ask the user for two numbers and an operator (+, -, *, /).
            // Use switch-case to perform the selected operation.

            //double num1, num2, result;
            //string op;

            //Console.WriteLine("Enter The Num1");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The Num2");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operator");
            //op = (Console.ReadLine());

            //switch (op)
            //{
            //    case "+":
            //        result = num1 + num2;
            //        Console.WriteLine("result = " + result);
            //        break;
            //    case "-":
            //        result = num1 - num2;
            //        Console.WriteLine("result = " + result);
            //        break;
            //    case "*":
            //        result = num1 * num2;
            //        Console.WriteLine("result = " + result);
            //        break;
            //    case "/":
            //        result = num1 / num2;
            //        Console.WriteLine("result = " + result);
            //        break;
            //    default:
            //        Console.WriteLine("result = no have operator ");
            //        break;

            //}

            //Console.WriteLine("--------------------------------------------------------------");


            //2.Basic ATM System 
            //• Use a starting balance of $1000.
            //• Allow users to Deposit, Withdraw, or Check Balance.  
            //• Withdraw should check if funds are available. 
            //• Display a menu with options:
            //   o 1.Withdraw Money
            //   o 2.Deposit Money
            //   o 3.Check Balance
            //   o 4.Exit
            //• Use switch-case to process the selected operation.
            //int Balance = 1000;
            //double money, money1;

            //char choice;

            //do
            //{ 
            // Console.Clear();
            // Console.WriteLine("Choose The Services : \n1. Withdraw Money \n2. Deposit Money \n3. Check Balance \n4. Exit");
            // int service = int.Parse(Console.ReadLine());



            //    switch (service)
            //    {
            //        case 1:
            //            Console.WriteLine("Withdraw Money");
            //            Console.WriteLine("How Money you need to Withdraw?");
            //            money1 = double.Parse(Console.ReadLine());
            //            if (Balance >= money1)
            //            {
            //                money = Balance - money1;
            //                Console.WriteLine("\nYour balance is " + money + "\nYour Withdraw is " + money1);
            //            }

            //            else
            //            {
            //                Console.WriteLine("Insufficient Balance");
            //            }
            //            break;
            //        case 2:
            //            Console.WriteLine("Deposit Money");
            //            Console.WriteLine("How Money you need to Deposit?");
            //            money1 = double.Parse(Console.ReadLine());
            //            money = Balance + money1;
            //            Console.WriteLine("\n.Your balance is " + money + "\n.Your Deposit is " + money1);
            //            break;
            //        case 3:
            //            Console.WriteLine("Check Balance");
            //            Console.WriteLine("Your Balance is " + Balance);
            //            break;
            //        case 4:
            //            Console.WriteLine("Exit");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            break;

            //    } 



            //  Console.WriteLine("Do you want to continue? Y/N");
            //  choice = char.Parse(Console.ReadLine());
            //} while (choice == 'y' || choice == 'Y');

            //Console.WriteLine("\nThank You For Choosing Us.");

            //Console.WriteLine("--------------------------------------------------------------");

            //3.Geometry Calculator
            //• Ask the user to choose a shape:
            //o 1.Circle(Calculate Area & Circumference)
            //o 2.Square(Calculate Area & Perimeter)
            //o 3.Triangle(Calculate Area)
            //• Use switch-case to perform the corresponding calculation.




            //char choice;

            //do
            //{
            //    Console.Clear();
            //   Console.WriteLine("Choose The Shapes : \n1. Circle \n2. Square \n3. Triangle  \n4. Exit");
            //   int Shapes = int.Parse(Console.ReadLine());

            //    switch (Shapes)
            //    {
            //        case 1:
            //            Console.WriteLine("Circle");
            //            double r, Area, Circumference;
            //            Console.WriteLine("Enter The Radius");
            //            r = double.Parse(Console.ReadLine());
            //            Area = 3.14 * r * r;
            //            Circumference = 2 * 3.14 * r;
            //            Console.WriteLine("The Area of Circle is " + Area);
            //            Console.WriteLine("The Circumference of Circle is " + Circumference);
            //            break;
            //        case 2:
            //            Console.WriteLine("Square");
            //            double s, Area1, Perimeter;
            //            Console.WriteLine("Enter The Side");
            //            s = double.Parse(Console.ReadLine());
            //            Area1 = s * s;
            //            Perimeter = 4 * s;
            //            Console.WriteLine("The Area of Square is " + Area1);
            //            Console.WriteLine("The Perimeter of Square is " + Perimeter);
            //            break;
            //        case 3:
            //            Console.WriteLine("Triangle");
            //            double b, h, Area2, Perimeter1;
            //            Console.WriteLine("Enter The Base");
            //            b = double.Parse(Console.ReadLine());
            //            Console.WriteLine("Enter The Height");
            //            h = double.Parse(Console.ReadLine());
            //            Area2 = 0.5 * b * h;
            //            Perimeter1 = b + h + Math.Sqrt(b * b + h * h);
            //            Console.WriteLine("The Area of Triangle is " + Area2);
            //            Console.WriteLine("The Perimeter of Triangle is " + Perimeter1);
            //            break;
            //        case 4:
            //            Console.WriteLine("Exit");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            break;
            //    }

            // Console.WriteLine("Do you want to continue? Y/N");
            // choice = char.Parse(Console.ReadLine());
            //} while (choice == 'y' || choice == 'Y') ;

            //Console.WriteLine("\nThank You Good Bye.");


            //Console.WriteLine("--------------------------------------------------------------");


            //4.Factorial of a Number
            //• Ask the user for a number N and calculate its factorial(N!).

            //int N;
            //double fact = 1;
            //Console.WriteLine("Enter The N");
            //N = int.Parse(Console.ReadLine());
            //fact = N;
            //for (int i = N - 1; i >= 1; i--)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine("The Factorial of " + N + " is " + fact);


            //Console.WriteLine("--------------------------------------------------------------");


            // 5.Sum of Even and Odd Numbers
            // • Ask the user to enter N. 
            // • Find the sum of all even and odd numbers from 1 to N .

            //int N, Even = 0, Odd = 0;
            //Console.WriteLine("Enter The N");
            // N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= N; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Even = Even + i;
            //    }
            //    else
            //    {
            //        Odd = Odd + i;
            //    }
            //}
            //Console.WriteLine("The Sum of Even Numbers from 1 to " + N + " is " + Even);
            //Console.WriteLine("The Sum of Odd Numbers from 1 to " + N + " is " + Odd);

            //Console.WriteLine("--------------------------------------------------------------");


            //6.Scientific Calculator(Switch - Case & Math Functions)
            //• Ask for an operation (sin, cos, tan, sqrt, log, pow). 
            //• Use switch-case to compute results using Math functions.

            //double num, result;
            //char choice;

            //do
            //{
            //    Console.WriteLine("Choose The Operation : \n1. sin \n2. cos \n3. tan \n4. sqrt \n5. log \n6. pow");
            //    int Operation = int.Parse(Console.ReadLine());


            //    switch (Operation)
            //    {
            //        case 1:
            //            Console.WriteLine("sin");
            //            Console.WriteLine("Enter The Number");
            //            num = double.Parse(Console.ReadLine());
            //            result = Math.Sin(num);
            //            Console.WriteLine("The sin of " + num + " is " + result);
            //            break;
            //        case 2:
            //            Console.WriteLine("cos");
            //            Console.WriteLine("Enter The Number");
            //            num = double.Parse(Console.ReadLine());
            //            result = Math.Cos(num);
            //            Console.WriteLine("The cos of " + num + " is " + result);
            //            break;
            //        case 3:
            //            Console.WriteLine("tan");
            //            Console.WriteLine("Enter The Number");
            //            num = double.Parse(Console.ReadLine());
            //            result = Math.Tan(num);
            //            Console.WriteLine("The tan of " + num + " is " + result);
            //            break;
            //        case 4:
            //            Console.WriteLine("sqrt");
            //            Console.WriteLine("Enter The Number");
            //            num = double.Parse(Console.ReadLine());
            //            result = Math.Sqrt(num);
            //            Console.WriteLine("The sqrt of " + num + " is " + result);
            //            break;
            //        case 5:
            //            Console.WriteLine("log");
            //            Console.WriteLine("Enter The Number");
            //            num = double.Parse(Console.ReadLine());
            //            result = Math.Log(num);
            //            Console.WriteLine("The log of " + num + " is " + result);
            //            break;
            //        case 6:
            //            Console.WriteLine("pow");
            //            double num1;
            //            Console.WriteLine("Enter The Number");
            //            num = double.Parse(Console.ReadLine());
            //            Console.WriteLine("Enter The Power");
            //            num1 = double.Parse(Console.ReadLine());
            //            result = Math.Pow(num, num1);
            //            Console.WriteLine("The pow of " + num + " is " + result);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            break;
            //    }


            //    Console.WriteLine("Do you want to continue? Y/N");
            //    choice = char.Parse(Console.ReadLine());
            //} while (choice == 'y' || choice == 'Y');

            //Console.WriteLine("\nThank You Good Bye.");

            //Console.WriteLine("--------------------------------------------------------------");

            //7.Print Pattern(For Loop)
            //•Ask the user for a number N and print a right - angled triangle
            //Example: (for N = 5)
            //        *
            //        **
            //        ***
            //        ****
            //        *****

            //int N;
            //Console.WriteLine("Enter The N");
            //N = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Pattern is ");
            //for (int i = 1; i <= N; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            // 10. Factorial of a Number
            //Write a program that takes a number as input and prints its factorial.

            //int num, fact;

            //Console.WriteLine("Enter The Num");
            //num = int.Parse(Console.ReadLine());
            //fact = 1;

            //for (int i = 1; i <= num; i++)
            //{
            //    fact = fact * i;
            //    Console.WriteLine(fact);
            //}

            //Console.WriteLine("--------------------------------------------------------------");

            //int i, n, x;

            //Console.WriteLine("Enter The i");
            //i = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The n");
            //n = int.Parse(Console.ReadLine());

            //do
            //{
            //    x = i * n;
            //    Console.WriteLine("{0} * {1} = {2} ", i, n, x);
            //    n--;
            //} 
            //while (n >= 0);



            //Console.WriteLine("--------------------------------------------------------------");


            //8.Print a Pyramid Pattern(For Loop)
            //• Ask the user for N and print a pyramid
            // Example: (for N = 4)
            //        *
            //       ***
            //      *****
            //     *******

            //int N;
            //Console.WriteLine("Enter The N");
            //N = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Pattern is ");
            //if (N % 2 == 0)
            //{
            //    for (int i = 1; i <= N; i++)
            //    {
            //        for (int j = 1; j <= N - i; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int k = 1; k <= 2 * i - 1; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i <= N; i++)
            //    {
            //        for (int j = 1; j <= N - i; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int k = 1; k <= 2 * i - 1; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }

            //int i, n, x;

            //Console.WriteLine("Enter The i");
            //i = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The n");
            //n = int.Parse(Console.ReadLine());

            //while (n <= 100)
            //{
            //    x = i * n; 
            //    Console.WriteLine("{0} * {1} = {2} ", i, n, x);
            //    n++;
            //}


            //Console.WriteLine("--------------------------------------------------------------");



            //9.Print a Diamond Pattern(For Loop)
            //• Ask the user for N and print a diamond pattern 
            //Example: (for N = 3)
            //        *
            //       ***
            //      *****
            //       ***
            //        *


            //int N;
            //Console.WriteLine("Enter The N");
            //N = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Pattern is ");
            //if (N % 2 == 0)
            //{
            //    for (int i = 1; i <= N; i++)
            //    {
            //        for (int j = 1; j <= N - i; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int k = 1; k <= 2 * i - 1; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //    for (int i = N - 1; i >= 1; i--)
            //    {
            //        for (int j = 1; j <= N - i; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int k = 1; k <= 2 * i - 1; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i <= N; i++)
            //    {
            //        for (int j = 1; j <= N - i; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int k = 1; k <= 2 * i - 1; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //    for (int i = N - 1; i >= 1; i--)
            //    {
            //        for (int j = 1; j <= N - i; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int k = 1; k <= 2 * i - 1; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}


            //Console.WriteLine("--------------------------------------------------------------");


            //10.Guess Game with helper
            //Generate a random number(1 - 100) and ask the user to guess the number.  
            //• If guess is too high → "Try Lower!"
            //• If guess is too low → "Try Higher!"
            //• If guess is correct → "You Win!"
            //Use a while loop to keep asking.

            //int num, guess, count = 0;

            //num = random.Next(1, 100);

            //do
            //{
            //    Console.WriteLine("Enter The Guess Number");
            //    guess = int.Parse(Console.ReadLine());
            //    count++;
            //    if (guess > num)
            //    {
            //        Console.WriteLine("Try Lower!");
            //    }
            //    else if (guess < num)
            //    {
            //        Console.WriteLine("Try Higher!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You Win!");
            //    }
            //} while (guess != num);

            //Console.WriteLine("The Number of Guesses is " + count);


            //Console.WriteLine("--------------------------------------------------------------");



        }
    }
}
