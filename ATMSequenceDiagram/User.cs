namespace ATMSequenceDiagram
{
  class User
  {
    public decimal CheckBalance(string accountNumber, ATM atm)
    {
      var result = atm.BalanceInquiry(accountNumber);
      return result;
    }

    public void Withdraw(decimal amount, ATM atm)
    {

    }
  }
}
