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
   class AccountTest
   {
      static void Main(string[] args)
      {
         Account[] accounts = new Account[6];

         accounts[0] = new SavingsAccount(500, 3);
         accounts[1] = new SavingsAccount(100, 10);
         accounts[2] = new CheckingAccount(250, 10);
         accounts[2] = new CheckingAccount(800, 5);


         
         for (int a = 0; a < accounts.Length; a++)
         {
            Console.WriteLine("How much would you like to debit into Account", a+1, "?");
         }

            //print array
         





      }
   }
}
