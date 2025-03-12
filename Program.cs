using System;
using System.Buffers.Text;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

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
            //}
        }
    }
}
