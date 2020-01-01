//Jennifer Faron
//November 14, 2017
//Assignment 5-Chapter 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccount
{
   class SavingsAccountTest
   {
      static void Main(string[] args)
      {
         SavingsAccount saver1 = new SavingsAccount();
         SavingsAccount saver2 = new SavingsAccount();

         SavingsAccount.ModifyInterestRate(4);
         saver1.savingsBalance = 2000;
         saver2.savingsBalance = 3000;

         Console.WriteLine(saver1);
         Console.WriteLine(saver2);



         SavingsAccount.ModifyInterestRate(5);
         saver1.savingsBalance = 2000;
         saver2.savingsBalance = 3000;

         Console.WriteLine(saver1);
         Console.WriteLine(saver2);
      }
   }
}
