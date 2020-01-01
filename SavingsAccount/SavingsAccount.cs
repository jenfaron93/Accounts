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
   class SavingsAccount
   {
      private static double AnnualInterestRate = 0.04;
      private double SavingsBalance { get; set; }


      public SavingsAccount(double initial = 0.0)
      {
         SavingsBalance = initial;
      }

      public double savingsBalance
      {
         get
         {
            return SavingsBalance;
         }
         set
         {
            SavingsBalance = value + CalculateMonthlyInterest(value);
         }
      }

      public double CalculateMonthlyInterest(double value)
      {
         return value * (AnnualInterestRate / 12);
      }

     
      public static void ModifyInterestRate(double rate)
      {
         AnnualInterestRate = rate / 100;
      }


      public override string ToString() => $"The total savings balance is " +
         $"{SavingsBalance:C}";
  

   }
}
