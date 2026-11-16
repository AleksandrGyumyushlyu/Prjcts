using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    public abstract class BasicAccount
    {
        private int bankNum;
        private int branchNum;
        private int accountNum;
        private string ownerID;
        protected double balance;

        public BasicAccount(int bankNum, int branchNum, int accountNum, string ownerID)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.ownerID = ownerID;
            this.balance = 0;
        }

        public int GetBankNum()
        {
            return this.bankNum;
        }

        public int GetBranchNum()
        {
            return this.branchNum;
        }

        public int GetAccountNum()
        {
            return this.accountNum;
        }

        public string GetOwnerID()
        {
            return this.ownerID;
        }

        public double GetBal()
        {
            return this.balance;
        }

        public virtual bool Deposit(double sum)
        {
            if (sum >= 0)
            {
                this.balance += sum;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferMoney(BasicAccount otherAck, double sum)
        {
            if (this.Withdraw(sum))
            {
                otherAck.Deposit(sum);
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract bool Withdraw(object o);

        public abstract bool AtRisk();

        public override string ToString()
        {
            return $"Card number: {GetBankNum()}{GetBranchNum()}{GetAccountNum()}{GetOwnerID()}\nBalance: {GetBal()}\n";
        }
    }
}

        // Withdraw implementation if account is like a debit card which for some reason doesn't exist idk whyy
        // {
        //     if (sum >= 0 && GetBal() - sum >= 0)
        //     {
        //         this.balance -= sum;
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
