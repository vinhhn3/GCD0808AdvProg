using System;

namespace ATMSequenceDiagram
{
  class Program
  {
    static void Main(string[] args)
    {
      User user = new User();
      Database database = new Database();
      database.AddAccount("123", 100);
      database.AddAccount("456", 200);

      ATM atm = new ATM(database);

      //Console.WriteLine(user.CheckBalance("123", atm));
      Console.WriteLine("Before Withdraw");
      Console.WriteLine(user.GetBalance());
      user.Withdraw("123", 50, atm);

      Console.WriteLine("After withdraw");
      Console.WriteLine(user.GetBalance());

      Console.WriteLine("Before Withdraw");
      Console.WriteLine(user.GetBalance());
      user.Withdraw("456", 500, atm);

      Console.WriteLine("After withdraw");
      Console.WriteLine(user.GetBalance());


      Console.ReadKey();
    }
  }
}
