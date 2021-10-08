namespace ATMSequenceDiagram
{
  class ATM
  {
    private Database _database;
    public ATM()
    {

    }

    public ATM(Database database)
    {
      _database = database;
    }
    public decimal BalanceInquiry(string accountNumber)
    {
      var result = _database.GetBalance(accountNumber);
      return result;
    }

    public bool RequestWithdraw(string accountNumber, decimal amount)
    {
      return _database.ProcessWithdraw(accountNumber, amount);
    }
  }
}
