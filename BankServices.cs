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
        int lastFreeIndex;
        protected const int DEFAULT_ACKS_AMOUNT = 100;

        public BankServices(int accountsAmount)
        {
            this.accounts = new BasicAccount[accountsAmount];
            lastFreeIndex = 0;
        }

        public BankServices() : this(DEFAULT_ACKS_AMOUNT) {}

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

        public bool Add(BasicAccount account)
        {
            if (this.lastFreeIndex < this.GetAccounts().Length)
            {
                this.GetAccounts()[this.lastFreeIndex] = account;
                this.lastFreeIndex++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetInfoOf(int accountNumber)
        {
            foreach (BasicAccount account in this.GetAccounts())
            {
                if (account != null && account.GetAccountNum() == accountNumber)
                {
                }
                return account.ToString();
            }
            return "";

        }

        public int AccountsAmount(int accountNumber)
        {
            string id = "";
            int accountCount = 0;

            foreach (BasicAccount account in this.GetAccounts())
            {
                if (account != null && account.GetAccountNum() == accountNumber)
                {
                    id = account.GetOwnerID();
                    break;
                }
            }

            foreach (BasicAccount account in this.GetAccounts())
            {
                if (account != null && account.GetOwnerID() == id)
                {
                    accountCount++;
                }
            }

            return accountCount;
        }

        public BasicAccount[] UserAccountsByID(string id)
        {
            int accountCount = 0, i = 0;

            foreach (BasicAccount account in this.GetAccounts())
            {
                if (account != null && account.GetOwnerID() == id)
                {
                    accountCount++;
                }
            }

            if (accountCount == 0)
            {
                return null;
            }

            BasicAccount[] accounts = new BasicAccount[accountCount];

            foreach (BasicAccount account in this.GetAccounts())
            {
                if (account != null && account.GetOwnerID() == id)
                {
                    accounts[i] = account;
                    i++;
                }
            }

            return accounts;
        }

        public string[] GetUniqueIDs()
        {
            string[] checkedIDs = new string[this.lastFreeIndex];
            int lastFreeIDIndex = 0;
            bool alreadyChecked = false;

            if (this.lastFreeIndex == 0) // If there's no registered accounts then NULL
            {
                return null;
            }

            foreach (BasicAccount account in this.GetAccounts())
            {
                alreadyChecked = false;

                if (account != null)
                {
                    for (int i = 0; i < lastFreeIDIndex && !alreadyChecked; i++)
                    {
                        if (account.GetOwnerID() == checkedIDs[i])
                        {
                            alreadyChecked = true;
                        }
                    }

                    if (!alreadyChecked)
                    {
                        checkedIDs[lastFreeIDIndex] = account.GetOwnerID();
                        lastFreeIDIndex++;
                    }
                }
            }

            return checkedIDs;
        }

        public string GetRichestID()
        {
            string[] allIDs = this.GetUniqueIDs();

            if (allIDs == null) // If no ID's then empty string cuz nothing to give out
            {
                return "";
            }

            double[] moneyCounts = new double[allIDs.Length];
            int richestPersonIndex = 0;
            double mostMoney = 0;
            bool firstCheck = true;


            for (int i = 0; i < allIDs.Length; i++)
            {
                BasicAccount[] userAccounts = this.UserAccountsByID(allIDs[i]);
                if (userAccounts != null)
                {
                    foreach (BasicAccount account in userAccounts)
                    {
                        if (account != null)
                        {
                            moneyCounts[i] += account.GetBal();
                        }
                    }
                }
            }

            for (int i = 0; i < moneyCounts.Length; i++)
            {
                if (firstCheck)
                {
                    mostMoney = moneyCounts[i];
                    richestPersonIndex = i;
                    firstCheck = false;
                }
                else if (moneyCounts[i] > mostMoney)
                {
                    mostMoney = moneyCounts[i];
                    richestPersonIndex = i;
                }
            }

            return allIDs[richestPersonIndex];
        }

        public BasicAccount[] RiskAccounts()
        {
            int riskAccountsCount = 0;
            int i = 0;

            foreach (BasicAccount account in this.GetAccounts())
            {
                if (account != null && account.AtRisk())
                {
                    riskAccountsCount++;
                }
            }

            BasicAccount[] riskAccounts = new BasicAccount[riskAccountsCount];

            foreach (BasicAccount account in this.GetAccounts())
            {
                if (account != null && account.AtRisk())
                {
                    riskAccounts[i] = account;
                    i++;
                }
            }

            return riskAccounts;
        }

        public static void UnitTest()
        {
            BankServices bankAdmin = new BankServices();
            bankAdmin.Add(new BasicAccount(1234, 1234, 1111, "1234"));
            bankAdmin.GetAccounts()[0].Deposit(200);
            bankAdmin.Add(new BasicAccount(1234, 1234, 2222, "1234"));
            bankAdmin.GetAccounts()[1].Deposit(150);
            bankAdmin.Add(new BasicAccount(1234, 1234, 3333, "2345"));
            bankAdmin.GetAccounts()[2].Deposit(200);
            bankAdmin.Add(new BasicAccount(1234, 1234, 4444, "2345"));
            bankAdmin.GetAccounts()[3].Deposit(200);
            Console.WriteLine(bankAdmin.GetInfoOf(1111));

            Console.WriteLine(bankAdmin.AccountsAmount(1111));
            Console.WriteLine(bankAdmin.AccountsAmount(4444));

            foreach (BasicAccount account in bankAdmin.UserAccountsByID("1234"))
            {
                Console.WriteLine(account);
            }

            foreach (BasicAccount account in bankAdmin.UserAccountsByID("2345"))
            {
                Console.WriteLine(account);
            }

            Console.WriteLine(bankAdmin.GetRichestID());

        }
    }
}
