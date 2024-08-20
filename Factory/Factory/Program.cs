// See https://aka.ms/new-console-template for more information

using Factory;
using Factory.Factory;

ICollection<IEmployee> employees = new List<IEmployee>();
SeedData(employees);

Console.WriteLine("Hello, World!");
return;

static void SeedData(ICollection<IEmployee> employees)
{
    var teacher = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1,
        "Rob",
        "Robi",
        4000);

    employees.Add(teacher);

    var teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "jey",
        "Robi",
        4000);

    employees.Add(teacher2);

    var headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3,
        "Jenny",
        "Thomas",
        5000);

    employees.Add(headOfDepartment);

    var deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4,
        "Brenda",
        "Mullins",
        6000);

    employees.Add(deputyHeadMaster);

    var headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5,
        "Mohsen",
        "Miri",
        8000);

    employees.Add(headMaster);
}