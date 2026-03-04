using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using BeginnerFriendly;
using System.Collections;
public class EvenorOdd : CHash{
public string ProgramName=> "C# Program to Check Whether a Given Number is Even or Odd";
public void Execute()
    {
        Console.Write("Enter a number: ");
        int a=Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is an even number.");
        }
        else
        {
            Console.WriteLine($"{a} is an odd number.");
        }
    }
}
public class OddRange: CHash
{
    public string ProgramName => "C# Program to Print Odd Numbers in a Given Range";
    public void Execute()
    {
        Console.Write("(Write Starting range first, enter and then ending range followed by enter)\nEnter a range: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
for(int i = a; i <= b; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i}, ");
    }
}
    }
}
public class IdentifyNum: CHash
{
    public string ProgramName=> "C# Program to Check Whether a Number is Positive or Not";
    public void Execute()
    {
       Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a < 0)
{
    Console.Write($"{a} is a negative  number.");
}
else if (a>0)
{
    Console.Write($"{a} is a positive  number.");
}
else
{
     Console.Write($"{a} is neither positive nor negative.");
}
    }
}
public class LargerNum: CHash
{
    public string ProgramName=> "C# Program to Find the Largest of Two Numbers";
    public void Execute()
    {
      Console.Write("Enter first number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"{a} is larger than {b}.");
}
else
{
     Console.Write($"{b} is larger than {a}.");
}  
    }
}
public class SwapNum: CHash
{
    public string ProgramName=> "C# Program to Swap Two Numbers";
    public void Execute()
    {
        Console.Write("Enter first number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write($"Before swapping, first number is {a} and second number is {b}.");
a+=b;
b=a-b;
a-=b;
Console.Write($"\nAfter swapping, first number is {a} and second number is {b}.");
    }
}
public class DivbyTwo: CHash
{
    public string ProgramName=> "C# Program to Check if a Number is Divsible by 2";
    public void Execute()
    {
        Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.Write($"{a} is divisible by 2.");
}
else
{
    Console.Write($"{a} is not divisible by 2.");
}
    }
}
public class AddMul: CHash
{
    public string ProgramName => "C# Program to Find the Sum of all Multiples of 3 and 5";
    public void Execute()
    {
        Console.Write("(Enter the range till which you want the table to run, then enter)\nEnter range for multiples of 3: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter range for multiples of 5: ");
int b=Convert.ToInt32(Console.ReadLine());
int c=0;
for(int i = 1; i <= a; i++)
{
    c+=3*i;
}
for(int j = 1; j <= b; j++)
{
    c+=5*j;
}
Console.Write($"Sum of the multiples of 3 and 5 in that range is {c}");
    }
}
public class Seventeen: CHash
{
    public string ProgramName=> "C#Program to Print all the Multiples of 17 Which are Less Than 100";
    public void Execute()
    {
        int a=0,i=1;
 while(a<100){
    a=17*i;
    i++;
    if (a < 100)
    {
        Console.Write($"{a} ");
    }
}
    }
}
public class DigitSum: CHash
{
    public string ProgramName=> "C# Program to Find Sum of Digits of a Number";
    public void Execute()
    {
        Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=0;
while (a != 0)
{
  b+= a%10;
  a/=10;
}
Console.Write($"The sum of its digits is {b}.");
    }
}
public class ReverseNum: CHash
{
    public string ProgramName=> "C# Program to Reverse a Number";
    public void Execute()
    {
        Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=0;
while (a != 0)
{
    b*=10;
    b+=a%10;
    a/=10;
}
Console.Write($"The reversed number is {b}.");
    }
}
public class Palindrome: CHash
{
    public string ProgramName=> "C# Program to Reverse a Number and Check if it is a Palindrome";
    public void Execute()
    {
       Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=0,i=a;
while (a != 0){
    b*=10;
    b+=a%10;
    a/=10;
}
if (i == b){
    Console.Write($"The reversed number is {b}. Thus, {i} is a palindrome number.");
}
else{
      Console.Write($"The reversed number is {b}. Thus, {i} is not a palindrome number.");
} 
    }
}
public class AddBinary: CHash
{
    public string ProgramName=> "C# Program to Find the Sum of Two Binary Numbers";
    public void Execute()
    {
        Console.Write("Enter first binary number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second binary number: ");
int b=Convert.ToInt32(Console.ReadLine());
int i=1,num1=0,num2=0;
while (a != 0||b!=0)
{
  num1+=(a%10)*i;
  num2+=(b%10)*i;
  i*=2;
  a/=10;
  b/=10;
}
num1+=num2;
int x=1,res=0;
while (num1/2!=0||num1%2!=0)
{
  res+=((num1%2)*x);
  x*=10;
  num1/=2;
}
Console.Write($"Addition of both binary numbers: {res}");
    }
}
public class MulBinary: CHash
{
    public string ProgramName=> "C# Program to Multiply Two Binary Numbers";
    public void Execute()
    {
        Console.Write("Enter first binary number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second binary number: ");
int b=Convert.ToInt32(Console.ReadLine());
int i=1,num1=0,num2=0;
while (a != 0||b!=0)
{
  num1+=(a%10)*i;
  num2+=(b%10)*i;
  i*=2;
  a/=10;
  b/=10;
}
num1*=num2;
int x=1,res=0;
while (num1/2!=0||num1%2!=0)
{
  res+=((num1%2)*x);
  x*=10;
  num1/=2;
}
Console.Write($"Multiplication of both binary numbers: {res}");
    }
}
public class CalcNum: CHash
{
    public string ProgramName=> "C# Program to Calculate the Sum, Multiplication, Division and Subtraction of Two Numbers";
    public void Execute()
    {
        Console.Write("Enter first number: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second number: ");
double b=Convert.ToDouble(Console.ReadLine());
Console.Write($"Addition: {a+b}\nSubtraction: {a-b}\nMultiplication: {a*b}\nDivision: {a/b}");
    }
}
public class ExpMul: CHash
{
    public string ProgramName=> "C# Program to Perform Multiplication of Exponents of Same Base";
    public void Execute()
    {
        Console.Write("Enter a base: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first exponent: ");
int e1=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second exponent: ");
int e2=Convert.ToInt32(Console.ReadLine());
double res=Math.Pow(a,e1+e2);
Console.Write($"The multiplication of {a}^{e1} and {a}^{e2} is equal to {res}.");
    }
}
public class ExpDiv: CHash
{
    public string ProgramName=> "C# Program to Perform Division of Exponents of Same Base";
    public void Execute()
    {
        Console.Write("Enter a base: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first exponent: ");
int e1=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second exponent: ");
int e2=Convert.ToInt32(Console.ReadLine());
double res=Math.Pow(a,e1-e2);
Console.Write($"The division of {a}^{e1} and {a}^{e2} is equal to {res}.");
    }
}
public class MulTable: CHash
{
    public string ProgramName=> "C# Program to Print Multiplication Table";
    public void Execute()
    {
        Console.Write("Enter the number you want a table of: ");
int a=Convert.ToInt32(Console.ReadLine());
 Console.Write("(Enter the range till which you want the table to run, then enter)\nEnter a range: ");
 int b=Convert.ToInt32(Console.ReadLine());
 int c=0;
 for(int i = 1; i <= b; i++)
{
    c=a*i;
    Console.Write($"{a} x {i} = {c}\n");
}
    }
}