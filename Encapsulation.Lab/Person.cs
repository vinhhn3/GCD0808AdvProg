namespace Encapsulation.Lab
{
  class Person
  {
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    public decimal Salary { get; private set; }

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
