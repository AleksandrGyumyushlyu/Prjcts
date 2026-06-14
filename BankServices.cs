using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    internal class BankServices
    {
        protected const int DEFAULT_ACKS_AMOUNT = 100;
        BasicAccount[] accounts = new BasicAccount[BankServices.DEFAULT_ACKS_AMOUNT];

        public static void UnitTest()
        {
            
        }
    }
}
