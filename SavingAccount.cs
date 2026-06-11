using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    public class SavingAccount : BasicAccount
    {
        private Date savingEndDate;

        
        public SavingAccount(int bankNum, int branchNum, int accountNum, string ownerID, Date savingEndDate, double balance) : base(bankNum, branchNum, accountNum, ownerID)
        {
            this.balance = balance;
            this.savingEndDate = savingEndDate;
        }

        public SavingAccount(int bankNum, int branchNum, int accountNum, string ownerID, Date savingEndDate) : this(bankNum, branchNum, accountNum, ownerID, savingEndDate, 0) { }

        public SavingAccount(BasicAccount baseAcct, Date savingEndDate) : this(baseAcct.GetBankNum(), baseAcct.GetBranchNum(), baseAcct.GetAccountNum(), baseAcct.GetOwnerID(), savingEndDate, baseAcct.GetBal()) { }

        public Date GetEndDate()
        {
            return this.savingEndDate;
        }

        public bool SetEndDate(Date newEndDate)
        {
            if (newEndDate.CompareTo(GetEndDate()) > 0)
            {
                this.savingEndDate = newEndDate;
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

        public bool WithdrawAll(Date withdrawalDate)
        {
            if (withdrawalDate.CompareTo(GetEndDate()) >= 0)
            {
                this.balance = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Card number: {GetBankNum()}{GetBranchNum()}{GetAccountNum()}{GetOwnerID()}\nBalance: {GetBal()}\nSavings end date: {GetEndDate()}";
        }

        public static void UnitTest()
        {
            SavingAccount svAc = new SavingAccount(53, 57, 3802, "0123", new Date());
            Console.WriteLine(svAc);

            Console.WriteLine(svAc.SetEndDate(new Date(27, 5, 2026)) ? "End date changed!" : "End date change failed");
            Console.WriteLine(svAc.GetEndDate());
            Console.WriteLine(svAc.SetEndDate(new Date(23, 5, 2026)) ? "End date changed!" : "End date change failed");
            Console.WriteLine(svAc.GetEndDate());

            Console.WriteLine(svAc.WithdrawAll(new Date(23, 5, 2026)) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(svAc.WithdrawAll(new Date(27, 5, 2026)) ? "Withdrawal was successfull" : "Failed to withdraw");
        }
    }
}
