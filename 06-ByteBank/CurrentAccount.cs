namespace _06_ByteBank
{
    public class CurrentAccount
    {
        private Customer holder;
        public int agencyNumber { get; set; }
        public int accountNumber { get; set; }
        private double _bankBalance = 100;

        public double BankBalance
        {
            get
            {
                return _bankBalance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _bankBalance = value;
            }
        }

        internal Customer Holder { get => holder; set => holder = value; }

        public bool WithdrawalAmount(double value)
        {
            if (_bankBalance < value)
            {
                return false;
            }
            else
            {
                _bankBalance -= value;
                return true;
            }

        }

        public void BankDeposit(double value)
        {
            this._bankBalance += value;
        }

        public bool BankTransfer(double value, CurrentAccount targetAccount)
        {
            if (this._bankBalance < value)
            {
                return false;
            }
            else
            {
                this._bankBalance -= value;
                targetAccount.BankDeposit(value);
                return true;
            }
        }
    }
}
