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
   public class SavingsAccount : Account
   {
      public decimal interestRate;

      public SavingsAccount(decimal initialBalance, decimal interestRate)
         :base(initialBalance)
      {
         this.interestRate = interestRate;
      }


      public decimal CalculateInterest()
      {
         return AccountBalance * interestRate / 100m;
      }

      
    


   }
}
