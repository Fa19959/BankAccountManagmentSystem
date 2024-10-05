using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagmentSystem
{
    public class BankAccount
    {
        string AccountNumber;
        string AccountHolderName;
        //whenever found double, float or int do not keep it empty try to put 0 on it 
        //because sometimes the memory place that you want to add the value it contain garbage before you,that is mean may another program ues it 
        //so its good to keep it 0
        decimal Balance = 0;

        //constructor dose not have return type, its same the class name
        //So this is will create a copy of the class , now we want to add value to the attribute above
        //This 2 parameter will take the value from the user (function take the parameter from the user or return to the program)
        public BankAccount(string AccountNumber, string AccountHolderName) {
           /*if we write the same name of the attributes that we define in the program
            * and the parameter which is in constructor you will have problem
            * so we can differentiate between them using (This) keyword this will let 
            * you know that its from the class itself
            * So this constructor if you call it it will constract a copy from the class
            * as object.
           */
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
        }
        public BankAccount(string accountNumber, string accountHolderName, decimal balanc)
        {
           
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            //This is the first value
            Balance = balanc;
        }

        //Public so can anyone call it
        //void we dont expect to return anythings!
        //to work its need balance from the user
        public void Deposit(decimal amount)
        {
            //So its take the amount then add it to balance
            //assum that the amount with minus
            if (amount < 0)
            {
                Balance += amount;
                //to let the user know what is happen
                Console.WriteLine("The amount of" + amount + "added successfully");
                Console.WriteLine("The new balance eqauls :" + Balance);
            }
            else
            {
                Console.WriteLine("The amount is not valid, must be grater than 0");

            }

        }

        //void we dont expect to return anythings!, something will be done on the system
        //we should give the amoute that we want it (decimal amount)
        // its ok to writhe same name of parameters because it is on different scope
        public void Withdraw(decimal amount)
        {

            //this is the functionallity of Withdraw, but may this will do mistakes 
            // so we should write if statment to check
            if (Balance >= amount && amount > 0)
            {
                Balance -= amount;
                Console.WriteLine("The amount of" + amount + "Withdraw successfully");
                Console.WriteLine("The new balance eqauls :" + Balance);
            }
            else
            {

            }
        }
        public void GetAccountInfo() { 
            Console.WriteLine(" The account number is :"+ AccountNumber);
            Console.WriteLine(" The account holder is :" + AccountHolderName);
            Console.WriteLine(" The Current balance is :" + Balance);
        }

    }
    
}
