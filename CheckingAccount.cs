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

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string ownerID, double overdraft = CheckingAccount.DEFAULT_OVERDRAFT, double balance = 0)
        {
            this.bankNum = bankNum;
            this.branchNum = branchNum;
            this.accountNum = accountNum;
            this.ownerID = ownerID;
            this.balance = balance;
            this.overdraft = overdraft;
        }

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string ownerID) : this(bankNum, branchNum, accountNum, ownerID, CheckingAccount.DEFAULT_OVERDRAFT) { }

        public CheckingAccount(BasicAccount baseAcct , double overdraft = CheckingAccount.DEFAULT_OVERDRAFT) : this(baseAcct.GetBankNum(), baseAcct.GetBranchNum(), baseAcct.GetAccountNum(), baseAcct.GetOwnerID(), overdraft, baseAcct.GetBal()) { }

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

        public double GetOverDraft()
        {
            return this.overdraft;
        }

        public bool SetOverdraft(double newOverdraft)
        {
            if (newOverdraft >= 0)
            {
                this.overdraft = newOverdraft;
                return true;
            }
            else
            {
                return false;
            }
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
            if (sum >= 0 && GetBal() - sum >= (GetOverDraft() * -1))
            {
                this.balance -= sum;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Card number: {GetBankNum()}{GetBranchNum()}{GetAccountNum()}{GetOwnerID()}\nBalance: {GetBal()}\nMax overdraft: {GetOverDraft()}";
        }

        public static void UnitTest()
        {
            CheckingAccount chkAc = new CheckingAccount(53, 57, 3802, "0123");
            Console.WriteLine(chkAc);

            Console.WriteLine(chkAc.Deposit(150) ? "Deposited successfull" : "Failed to deposit");
            Console.WriteLine(chkAc.GetBal());
            Console.WriteLine(chkAc.Deposit(-1) ? "Deposited successfull" : "Failed to deposit");
            Console.WriteLine(chkAc.GetBal());

            Console.WriteLine(chkAc.Withdraw(-1) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(chkAc.GetBal());
            Console.WriteLine(chkAc.Withdraw(150) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(chkAc.GetBal());
            Console.WriteLine(chkAc.Withdraw(2000) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(chkAc.GetBal());
        }

    }
}
