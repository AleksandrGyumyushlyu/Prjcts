using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    public class BasicAccount
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

        public virtual bool Withdraw(double sum)
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

        public override string ToString()
        {
            return $"Card number: {GetBankNum()}{GetBranchNum()}{GetAccountNum()}{GetOwnerID()}\nBalance: {GetBal()}\n";
        }

        public static void UnitTest()
        {
            BasicAccount bsAcct = new BasicAccount(53, 57, 3802, "0123");
            Console.WriteLine(bsAcct);

            Console.WriteLine(bsAcct.Deposit(150) ? "Deposited successfull" : "Failed to deposit");
            Console.WriteLine(bsAcct.GetBal());
            Console.WriteLine(bsAcct.Deposit(-1) ? "Deposited successfull" : "Failed to deposit");
            Console.WriteLine(bsAcct.GetBal());

            Console.WriteLine(bsAcct.Withdraw(-1) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(bsAcct.GetBal());
            Console.WriteLine(bsAcct.Withdraw(150) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(bsAcct.GetBal());
            Console.WriteLine(bsAcct.Withdraw(2000) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(bsAcct.GetBal());
        }
    }
}
