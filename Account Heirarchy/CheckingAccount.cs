//Jennifer Faron
//November 14, 2017
//Assignment 5- 11.9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Heirarchy
{
   class CheckingAccount : Account
   {
      public decimal fee;

      public CheckingAccount(decimal initalBalance, decimal fee)
         : base(initalBalance)
      {
         this.fee = fee;
      }

      public override void Credit(decimal credit)
      {
         base.Credit(credit);
         AccountBalance -= fee;
      }

      public override bool Debit(decimal debit)
      {
         if (base.Debit(debit))
         {
            AccountBalance -= fee;
            return true;
         }
         else
         {
            return false;
         }
      }
   }
}
