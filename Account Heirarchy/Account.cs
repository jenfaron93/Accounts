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
   public abstract class Account
   {
      private decimal accountBalance;

      public Account(decimal initalBalance)
      {
         accountBalance = initalBalance;
      }

      public decimal AccountBalance
      {
         get
         {
            return accountBalance;
         }
         set
         {
            if (value <= 0.0M)
            {
               throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(accountBalance)} cannot be a negative balance.");
            }

             accountBalance = value;
         }
      }

      public virtual void Credit(decimal credit)
      {
         accountBalance += credit;
      }

      public virtual bool Debit(decimal debit)
      {
         if (debit > accountBalance)
         {
            Console.WriteLine("Debit amount exceeded account balance");
            return false;
         }
         else
         {
            accountBalance -= debit;
            return true;
         }
      }

      public override string ToString() => $"The current balance is: {accountBalance:C}";

   }
}
