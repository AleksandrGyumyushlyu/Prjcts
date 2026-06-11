using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    public class BusinessAccount : CheckingAccount
    {
        private string ownerName;

        public BusinessAccount(int bankNum, int branchNum, int accountNum, string ownerID, string ownerName,  double overdraft, double balance) : base(bankNum, branchNum, accountNum, ownerID, overdraft, balance)
        {
            this.ownerName = ownerName;
        }

        public BusinessAccount(int bankNum, int branchNum, int accountNum, string ownerID, string ownerName) : this(bankNum, branchNum, accountNum, ownerID, ownerName, CheckingAccount.DEFAULT_OVERDRAFT, 0) { }

    }
}
