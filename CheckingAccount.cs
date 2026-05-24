using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    internal class CheckingAccount
    {
        private int bankNum;
        private int branchNum;
        private int accountNum;
        private string ownerID;
        private double balance;
        private double overdraft;
        private const double DEFAULT_OVERDRAFT = 1500;

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string ownerID, double overdraft)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.ownerID = ownerID;
            this.balance = 0;
            this.overdraft = overdraft;
        }

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string ownerID) : this(bankNum, branchNum, accountNum, ownerID, CheckingAccount.DEFAULT_OVERDRAFT) { }

        public int GetBankNum()
        {
            return this.bankNum;
        }

        public int GetBranchNum()
        {
            return this.branchNum;
        }

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

        public double GetOverDraft()
        {
            return this.overdraft;
        }

        public void SetOverdraft(double newOverdraft)
        {
            this.overdraft = newOverdraft >= 0 ? newOverdraft : this.overdraft;
        }

        public override string ToString()
        {
            return $@" ________________________________
                      |                                |
                      | {GetBankNum()}{GetBranchNum}{}
                      |________________________________|";
        }

    }
}
