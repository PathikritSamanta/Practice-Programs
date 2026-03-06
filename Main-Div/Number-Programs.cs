using System;
using System.Collections;
using BeginnerFriendly;
public class Fibonacci: CHash
{
    public string ProgramName=> "C# Program to Generate Fibonacci Series";
    public void Execute()
    {
        Console.Write("Enter the range for fibonacci series: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=0,c=1,d=0;
for(int i = 1; i <= a; i++)
{
    Console.Write($"{b}, ");
    d=b+c;
    b=c;
    c=d;
}
    }
}
public class Factorial: CHash
{
    public string ProgramName=> "C# Program to Print the Factorial of a Given Number";
    public void Execute()
    {
        Console.Write("Enter a factorial: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=a;
Console.Write($"Value of {a}! is ");
while(a!=1)
{
    b*=(a-1);
    a--;
}
Console.Write($"{b}.");
    }
}
public class PrimeNum: CHash
{
    public string ProgramName=> "C# Program to Print all the Prime Numbers Between 1 to 100";
    public void Execute()
    {
        Console.Write("Prime numbers between 1 to 100: ");
bool a=true;
for(int i = 2; i <= 99; i++)
{
    for(int j = 2; j <= 99; j++)
    {
        if(i!=j && i % j == 0)
        {
            a=false;
            break;
        }
    }
        if(a)
        {
            Console.Write($"{i}, ");
        }
        a=true;  
}
    }
}
public class LargestPrime: CHash
{
    public string ProgramName=> "C# Program to Find the Largest Prime Factor of a Number";
    public void Execute()
    {
        Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=0;
for(int i = 2; i <= a; i++)
{
    while (a % i == 0)
    {
        b=i;
        a/=i;
    }
}
Console.Write($"Its largest prime factor is {b}");
    }
}
public class PerfectNum: CHash
{
    public string ProgramName=> "C# Program to Check Whether a Given Number is Perfect Number";
    public void Execute()
    {
        Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=0,i=1;
while (i != a){
    if (a % i == 0) {
        b+=i;
        i++;
    }
    else {
        i++;
    }
}
if (a == b){
    Console.Write($"{a} is a perfect number.");
}
else{
    Console.Write($"{a} is not a perfect number.");
}
    }
}
public class Armstrong: CHash
{
    public string ProgramName=> "C# Program to Check Armstrong Number";
    public void Execute()
    {
         Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=a,c=0,i=0;
double d=0;
        while (a != 0){
            a/=10;
            i++;
        }
        a=b;
while (a != 0){
    d=Math.Pow(a%10,i);
    c+=(int)d;
    a/=10;
}
if (b == c){
    Console.Write($"{b} is an Armstrong number.");
}
else{
    Console.Write($"{b} is not an Armstrong number.");
    }
    }
}
public class ArmstrongNum: CHash{
    public string ProgramName=> "C# Program to Print Armstrong Number Between 1 to 1000";
    public void Execute()
    {
        int b=0,c=0,i=0;
        double d=0;
        Console.Write("Armstrong numbers between 1 to 1000: ");
       for(int j=1;j<=1000;j++){
        b=j;
        while (j!= 0){
            j/=10;  i++;
        }
        j=b;
while (j != 0){
    d=Math.Pow(j%10,i);
    c+=(int)d;
    j/=10;
}
if (b == c){
    Console.Write($"{c}, ");
    c=0; i=0;  j=b;
}
else{
   c=0; i=0; j=b;
}} 
    }
}
public class NumberSum: CHash
{
    public string ProgramName=> "C# Program to Generate the Sum of N Numbers";
    public void Execute()
    {
        Console.Write("Enter a range for sum of N numbers: ");
int a=Convert.ToInt32(Console.ReadLine());
int sum=0;
for(int i = 1; i <= a; i++)
{
    sum+=i;
}
Console.Write($"Sum of first {a} natural numbers is {sum}.");
    }
}
public class NaturalSum: CHash
{
    public string ProgramName=> "C# Program to Find the Sum of First 50 Natural Numbers Usibg For Loop";
    public void Execute()
    {
        int sum=0;
for(int i = 1; i <= 50; i++)
{
    sum+=i;
}
Console.Write($"Sum of first 50 natural numbers is {sum}.");
    }
}
public class Factors: CHash
{
    public string ProgramName=> "C# Program to Find the Factors of the Given Number";
    public void Execute()
    {
        Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write($"The factors of {a} are ");
for(int i = 1; i <= a; i++)
{
    if (a % i == 0)
    {
        Console.Write($"{i}, ");
    }
}
    }
}
public class Absolute: CHash
{
    public string ProgramName=> "C# Program to Print the Absolute value of a Number";
    public void Execute()
    {
        Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a >=0){
    Console.Write($"Its absolute value is {a}.");
}
else{
    Console.Write($"Its absolute value is {-a}.");
}
    }
}
public class RandomNum: CHash
{
    public string ProgramName=> "C# Program to Generate Random Numbers";
    public void Execute()
    {
        Console.Write("Press enter to generate a random number: ");
Console.ReadLine();
Random num=new Random();
int a=num.Next(0,1000000000);
Console.Write($"Your random number is {a}");
    }
}
public class Amicable: CHash
{
    public string ProgramName=> "C# Program to Check Whether the Given Number is a Amicable Number or Not";
    public void Execute()
    {
      Console.Write("Enter first number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b=Convert.ToInt32(Console.ReadLine());
int c=0,d=0;
for(int i = 1; i <a; i++){
    if (a % i == 0){
        c+=i;
    }
}
for(int j = 1; j < b; j++){
    if (b % j == 0){
        d+=j;
    }
}
if (a==d||b==c){
    Console.Write($"{a} and {b} are amicable numbers.");
}
else{
  Console.Write($"{a} and {b} are not amicable numbers.");   
}  
    }
}
public class SqrCbr: CHash
{
    public string ProgramName=> "C# Program to Find Square Root and Cube Root of a Number";
    public void Execute()
    {
        Console.Write("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
double sq=Math.Sqrt(a);
double cb=Math.Cbrt(a);
Console.Write($"Square root of {a} is {sq}.\nCube root of {a} is {cb}.");
    }
}