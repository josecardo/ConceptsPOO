// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

try
{
    Console.WriteLine(new Date(2022, 2, 11));
    Console.WriteLine(new Date(1976, 6, 39));
    Console.WriteLine(new Date(1984, 45, 2));
}
catch (Exception error)
{

    Console.WriteLine(error.Message); 
}