// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Laura",
    LasttName = "Carrillo",
    BirthDate = new Date(1980,6,25),
    HiringDate = new Date(2015,1,15),
    IsActive = true,
    salary = 25000000.58M    
};

Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Sandra",
    LasttName = "Morales",
    BirthDate = new Date(1970, 11, 15),
    HiringDate = new Date(2018, 9, 1),
    IsActive = true,    
    Sales = 350000000M,
    CommisionPercentaje = 0.03F
};

Console.WriteLine(employee2);
