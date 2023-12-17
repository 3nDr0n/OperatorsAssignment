using System;


// cerating Employee class
public class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // Overloading the equality operator (==) to compare Employee objects based on their Id property
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both objects are null or if their Id properties are equal
        return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
               !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) &&
               employee1.Id == employee2.Id;
    }

    // Overloading the inequality operator
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}