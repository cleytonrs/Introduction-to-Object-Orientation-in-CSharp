public class CurrentAccount
{
    public string holder;
    public int agencyNumber;
    public int accountNumber;
    public double bankBalance = 100;

    public bool WithdrawalAmount(double value)
    {
        if (this.bankBalance < value)
        {
            return false;
        }
        else
        {
            this.bankBalance -= value;
            return true;
        }

    }

    public void BankDeposit(double value)
    {
        this.bankBalance += value;
    }

    public bool BankTransfer(double value, CurrentAccount targetAccount)
    {
        if (this.bankBalance < value)
        {
            return false;
        }
        else
        {
            this.bankBalance -= value;
            targetAccount.BankDeposit(value);
            return true;
        }
    }
}