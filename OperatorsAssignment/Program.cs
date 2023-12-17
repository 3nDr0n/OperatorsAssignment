using System;

class Program
{
    static void Main()
    {
        //creating employee objects
        Employee employee1 = new Employee(1, "Mike", "Kovacs");
        Employee employee2 = new Employee(2, "Lajos", "Szabo");
        Employee employee3 = new Employee(1, "Mike", "Kovacs");

        // Comparing employees using the overloaded equality operator
        bool areEqual = employee1 == employee2;
        Console.WriteLine($"Employee 1 and Employee 2 are equal: {areEqual}");

        areEqual = employee1 == employee3;
        Console.WriteLine($"Employee 1 and Employee 3 are equal: {areEqual}");
        Console.ReadLine();
    }
}