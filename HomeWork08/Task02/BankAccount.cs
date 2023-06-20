using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork08.Task02
{
    public partial class BankAccount
    {
        private readonly string _accountNumber;
        private string _accountHolderName;
        private Balance _balance;


        public BankAccount (string  accountNumber)
        {
              _accountNumber = accountNumber;
        }

        public string GetAcountNumber()
        {
            return _accountNumber;
        }
        public string AccountHolderName
        {
            get 
            {
                return _accountHolderName;
            }
            set
            {
                _accountHolderName = value;
            }
        }

        public Balance Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }



        public void Deposit(string currency, double amount)

        {
            bool throwExeption = false;
            if(_balance.Currency.ToString () == currency.ToUpper())
            {
                _balance.Amount += amount;
            }
            else
            {
                foreach(Currency cur in Enum.GetValues(typeof(Currency)))
                {
                    if(cur.ToString() == currency.ToUpper())
                    {
                        _balance.Amount += (amount * (int)cur);
                        return;
                    }
                }
                throwExeption = true;
            }
            if (throwExeption)
            {
                throw new ArgumentException("Please Enter Valid Currency: USD, GEL or EUR");
            }
            
        }

        public void Withdraw(string currency, double amount)
        {
            bool throwExeption = false;
            if (_balance.Currency.ToString() == currency.ToUpper())
            {
                _balance.Amount -= amount;
            }
            else
            {
                foreach (Currency cur in Enum.GetValues(typeof(Currency)))
                {
                    if (cur.ToString() == currency.ToUpper())
                    {
                        if(_balance.Amount - (amount * (int)cur) < 0)
                        {
                            throw new Exception("You don't have enough money on deposit");
                        }
                        _balance.Amount -= (amount * (int)cur);
                        return;
                    }
                }
                throwExeption = true;
            }
            if (throwExeption)
            {
                throw new ArgumentException("Please Enter Valid Currency: USD, GEL or EUR");
            }
        }

        public double BalanceCheck()
        {
            return _balance.Amount;
        }
    }



    public partial class BankAccount
    {
        public void TransferFunds(BankAccount target, string currency, double amount)
        {
            bool throwExeption = true;

            foreach (Currency cur in Enum.GetValues(typeof(Currency)))
            {
                if (cur.ToString() == currency.ToUpper())
                {
                    throwExeption = false;
                }
            }

            if (throwExeption)
            {
                throw new ArgumentException("Please Enter Valid Currency: USD, GEL or EUR");
            }
            if(this._balance.Amount - amount >= 0)
            {
                this.Withdraw(currency, amount);
                target.Deposit(currency, amount);
            }
            else
            {
                Console.WriteLine("You don't have enough money");
            }
            
        }
    }







    public struct Balance
    {
        private Currency _currency;
        private double _amount;

        public Currency Currency
        {
            get
            {
                return _currency;
            }
            set
            {
                _currency = value;
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            }
            set 
            { 
                _amount = value;
            }
        }
    }


    public enum Currency
    {
        USD = 2,
        GELL = 1,
        EUR = 3

    }
}
