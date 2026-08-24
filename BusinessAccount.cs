using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    public class BusinessAccount : CheckingAccount
    {
        protected const double DEFAULT_OVERDRAFT = 5000;
        private string businessName;

        public BusinessAccount(int bankNum, int branchNum, int accountNum,
            string ownerID, string businessName, double overdraft, double balance)
            : base(bankNum, branchNum, accountNum, ownerID, overdraft, balance)
        {
            this.businessName = businessName;
        }

        public BusinessAccount(int bankNum, int branchNum, int accountNum,
            string ownerID, string businessName)
            : this(bankNum, branchNum, accountNum, ownerID, businessName, BusinessAccount.DEFAULT_OVERDRAFT, 0) { }

        public BusinessAccount(CheckingAccount chkAck, string businessName)
            : this(chkAck.GetBankNum(), chkAck.GetBranchNum(), chkAck.GetAccountNum(), chkAck.GetOwnerID(), businessName) {}

        public BusinessAccount(CheckingAccount chkAck, string businessName, double overdraft)
            : this(chkAck.GetBankNum(), chkAck.GetBranchNum(), chkAck.GetAccountNum(),
                  chkAck.GetOwnerID(), businessName, overdraft, chkAck.GetBal()) { }

        public string GetBizName()
        {
            return this.businessName;
        }

        public bool SetBizName(string newBizName)
        {
            if (newBizName != "")
            {
                this.businessName = newBizName;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool AtRisk()
        {
            return -this.GetBal() >= this.GetOverDraft() * 0.9;
        }

        public override string ToString()
        {
            return $"Business Card:\nBusiness Name: {this.GetBizName()}\n{base.ToString()}";
        }

        public static void UnitTest()
        {
            CheckingAccount chkAc = new CheckingAccount(53, 57, 3802, "0123");
            Console.WriteLine(chkAc);
            BusinessAccount bizAck = new BusinessAccount(chkAc, "Valve");

            Console.WriteLine(bizAck.Deposit(150) ? "Deposited successfull" : "Failed to deposit");
            Console.WriteLine(bizAck.GetBal());
            Console.WriteLine(bizAck.Deposit(-1) ? "Deposited successfull" : "Failed to deposit");
            Console.WriteLine(bizAck.GetBal());

            Console.WriteLine(bizAck.Withdraw(-1) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(bizAck.GetBal());
            Console.WriteLine(bizAck.Withdraw(150) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(bizAck.GetBal());
            Console.WriteLine(bizAck.Withdraw(6000) ? "Withdrawal was successfull" : "Failed to withdraw");
            Console.WriteLine(bizAck.GetBal());
            Console.WriteLine(bizAck.Deposit(1500) ? "Deposited successfull" : "Failed to deposit");
            Console.WriteLine(bizAck.GetBal());
            Console.WriteLine(bizAck);

            BusinessAccount bizAck2 = new BusinessAccount(53, 57, 3806, "4567", "Mike the Plumber");
            Console.WriteLine(bizAck2);

            Console.WriteLine(bizAck.TransferMoney(bizAck2, 750) ? "Transfer was successfull" : "Failed to transfer");
            Console.WriteLine(bizAck2);

            Console.WriteLine(bizAck.TransferMoney(chkAc, 750) ? "Transfer was successfull" : "Failed to transfer");
            Console.WriteLine(chkAc);
        }
    }
}
