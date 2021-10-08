using System.Collections.Generic;

namespace ATMSequenceDiagram
{
  class Database
  {
    Dictionary<string, decimal> Accounts;
    public Database()
    {
      Accounts = new Dictionary<string, decimal>();
    }

    public decimal GetBalance(string accountNumber)
    {
      return Accounts[accountNumber];
    }

    public void AddAccount(string accountNumber, decimal balance)
    {
      Accounts[accountNumber] = balance;
    }
  }
}
