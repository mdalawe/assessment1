// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, alawe");



Console.Write("Input a number");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 4; i++) 
{
    Console.WriteLine(i);
}

int sum = 0;
for(int i=1; i <= 4; i++)
{
    sum += i;
    Console.WriteLine(sum);
}



















/*
2
Console.WriteLine("enter a number");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2==0)

{
    Console.WriteLine("the number is odd");
}
else
{
    Console.WriteLine("the number is even");
}
*/


/*
5
int a =6;
int b =3;
Console.WriteLine(6+ "*" +3 +"=" +6 * 3);
*/

/*
3
int a = 5;
int b = 6;
int c = 7;

if(a > b)
{
    Console.WriteLine("A is the largest");
}
else if (b > c)
{
    Console.WriteLine("B is the largest");
}
else 
Console.WriteLine("C is the largest");
*/

/*
1
int x =4;
int y =5;
Console.WriteLine(x + y);
*/