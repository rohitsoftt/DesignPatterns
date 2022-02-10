// See https://aka.ms/new-console-template for more information
using IteratorProgram.Classes;

Console.WriteLine("Hello, World!");
var collection = new DaysInMonthCollection();

foreach(var item in collection)
{
    Console.WriteLine(item);
}