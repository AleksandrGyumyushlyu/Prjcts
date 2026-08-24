using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    public class CheckingAccount : BasicAccount
    {
        protected const double DEFAULT_OVERDRAFT = 1500;
        private double overdraft;

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string ownerID, double overdraft, double balance) : base(bankNum, branchNum, accountNum, ownerID)
        {
            this.overdraft = overdraft;
            this.balance = balance;
        }

        public CheckingAccount(int bankNum, int branchNum, int accountNum, string ownerID) : this(bankNum, branchNum, accountNum, ownerID, CheckingAccount.DEFAULT_OVERDRAFT, 0) { }

        public CheckingAccount(BasicAccount baseAcct, double overdraft = CheckingAccount.DEFAULT_OVERDRAFT) : this(baseAcct.GetBankNum(), baseAcct.GetBranchNum(), baseAcct.GetAccountNum(), baseAcct.GetOwnerID(), overdraft, baseAcct.GetBal()) { }


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

        public override bool Withdraw(double sum)
        {
            if (sum >= 0 && this.GetBal() - sum >= -this.GetOverDraft())
            {
                this.balance -= sum;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool AtRisk()
        {
            return this.GetBal() < 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Max overdraft: {GetOverDraft()}";
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
