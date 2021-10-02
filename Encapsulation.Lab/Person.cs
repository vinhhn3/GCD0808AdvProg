using System;

namespace Encapsulation.Lab
{
  class Person
  {
    private string _firstName;
    private string _lastName;
    private int _age;
    private decimal _salary;

    public string FirstName
    {
      get
      {
        return _firstName;
      }
      set
      {
        if (value.Length < 3)
        {
          throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
        }
        _firstName = value;
      }
    }
    public string LastName
    {
      get
      {
        return _lastName;
      }
      set
      {
        if (value.Length < 3)
        {
          throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
        }
        _lastName = value;
      }
    }
    public int Age
    {
      get
      {
        return _age;
      }
      set
      {
        if (value <= 0)
        {
          throw new ArgumentException("Age cannot be zero or a negative integer!");
        }
        _age = value;
      }
    }
    public decimal Salary
    {
      get
      {
        return _salary;
      }
      set
      {
        if (value < 460)
        {
          throw new ArgumentException("Salary cannot be less than 460 leva!");
        }
        _salary = value;
      }
    }

    public Person()
    {
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
      FirstName = firstName;
      LastName = lastName;
      Age = age;
      Salary = salary;
    }

    public override string ToString()
    {
      return $"{FirstName} {LastName} is {Age} years old, receives ${Salary} ";
    }

    public void IncreaseSalary(decimal percentage)
    {
      if (Age < 30)
      {
        Salary = Salary + Salary * (percentage / 200);
      }
      else
      {
        Salary = Salary + Salary * (percentage / 100);
      }
    }
  }
}
