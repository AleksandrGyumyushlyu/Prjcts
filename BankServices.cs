using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts // All comments should be temporary for now, they should be like in Funcs and EngUtils with tags
{
    internal class BankServices
    {
        BasicAccount[] accounts;

        public BankServices(int accountsAmount)
        {
            this.accounts = new BasicAccount[accountsAmount];
        }

        /// Access all accounts (accounts array)
        public BasicAccount[] GetAccounts()
        {
            return this.accounts;
        }

        /// Overwrite accounts array with another array
        public bool SetAccounts(BasicAccount[] accounts)
        {
            if (accounts != null && accounts.Length != 0)
            {
                this.accounts = accounts;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UnitTest()
        {

        }
    }
}
