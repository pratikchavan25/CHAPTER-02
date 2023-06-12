// See https://aka.ms/new-console-template for more information
// 2.Swap values of two integer variables without using a third variable ?

int a = 20;
int b = 300;

Console.WriteLine("before swapping");
Console.WriteLine("a = " + b);
Console.WriteLine("b = " + b);

a = a ^ b;
b = a ^ b;
a = a ^ b;

Console.WriteLine("after swapping");
Console.WriteLine("a = " + b);
Console.WriteLine("b = " + b);
