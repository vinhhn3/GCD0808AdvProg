namespace ATMSequenceDiagram
{
  class User
  {
    private decimal _balance;
    public User()
    {
      _balance = 0;
    }
    public decimal CheckBalance(string accountNumber, ATM atm)
    {
      var result = atm.BalanceInquiry(accountNumber);
      return result;
    }

    public void Withdraw(string accountNumber, decimal amount, ATM atm)
    {
      if (atm.RequestWithdraw(accountNumber, amount))
      {
        _balance += amount;
      }
    }

    public decimal GetBalance()
    {
      return _balance;
    }
  }
}
