using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    internal class BasicAccount
    {
        private int bankNum;
        private int branchNum;
        private int accountNum;
        private string ownerID;
        private double balance;

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

        public bool Deposit(double sum)
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

        public bool Withdraw(double sum)
        {
            if (sum >= 0 && GetBal() - sum >= 0)
            {
                this.balance -= sum;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
