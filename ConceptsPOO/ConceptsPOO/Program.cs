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

//Console.WriteLine(employee1);

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

//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Pedro",
    LasttName = "Narvaes",
    BirthDate = new Date(1990, 8, 10),
    HiringDate = new Date(2001, 1, 9),
    IsActive = true,
    Hours = 123.6F,
    HourValue = 12369.25M
};

//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Mauricio",
    LasttName = "Lopera",
    BirthDate = new Date(1960, 9, 21),
    HiringDate = new Date(2019, 6, 8),
    IsActive = true,
    Base = 360.5896M,
    Sales = 58000000M,
    CommisionPercentaje = 0.015F    
};

//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4 
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll = employee.GetValuetoPay();
}

Console.WriteLine("                                 ===============");
Console.WriteLine($"TOTAL                           {$"{payroll:c2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "Iphone 13",
    Id = 1,
    Price = 5300000m,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 32000m,
    Quantity = 17.5f
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);




