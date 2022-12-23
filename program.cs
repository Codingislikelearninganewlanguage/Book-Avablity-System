// See https://aka.ms/new-console-template for more information
using System.Linq;
Console.WriteLine("Please enter book number");
var booktitle = Console.ReadLine();
int[] booknumber = { 1234, 2345, 3049, 3023, 29382 };
var booktitleparsed = int.Parse(booktitle);
if (booknumber.Contains(booktitleparsed))
{
    Console.WriteLine("Book is avabalie");

}
else
{
    Console.WriteLine("Book is not avabalie");
}
