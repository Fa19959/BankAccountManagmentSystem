using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagmentSystem
{
    public class BankAccount
    {
        /* All the attribute "AccountNumber" is public, when its come to  the get it is keep them public
        And the set is private, so if we need the account number outside the class 
         that is mean if we said accoint.accountNumber it will show for us without function using only the (.)
        but the set we must use the function it will not work using (.) only! the only one
        who can change on the account number both constructor that we wrote! so this is the idea of set "this.AccountNumber = accountNumber;"
        public its general unless the one who will change it 
        */
        public string AccountNumber { get; private set; }
        /* set = change the things 
        get = give us the detils 
        */
        public string AccountHolderName {get; private set; }

        /*whenever found double, float or int do not keep it empty try to put 0 on it 
        because sometimes the memory place that you want to add the value it contain garbage before you,that is mean may another program ues it 
        so its good to keep it 0
        we will not get by balanc! we get by accountNumber! in term of Encapsulation (get , set).
        as long as the attribute is private we will get and set only using method, we can not using outside!
        */
        private decimal Balance = 0;

        /*constructor dose not have return type, its same the class name
         So this is will create a copy of the class , now we want to add value to the attribute above
         This 2 parameter will take the value from the user (function take the parameter from the user or return to the program)
        */
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
        /*Here inside this constructor inseted of using balance we will call the methode so we will change the name 
        of the attribute from balance to initial amount
        */
        public BankAccount(string accountNumber, string accountHolderName, decimal InitialAmount)
        {
           
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            //This is the first value
            //Balance = balanc; insted of using this , we will use to call function so we will write 
            // here is the example of use the function inside the class itself
            //Deposit(InitialAmount);
            if (InitialAmount > 0)
            {
                Balance += InitialAmount;
            }
            else
            {
                Console.WriteLine("Account is cerated but the balance is zero due to invalid input, please use deposit function");
            }
        }



        /*Public so can anyone call it
        void we dont expect to return anythings!
        to work its need balance from the user
        */

        /* For explination purpose: all the methods is public, if we have private methode we will not able to use it! so why we have private method!
         * we will need it for internal ues for example: if want to do calculation for age , he dont want the age itself
         * he want to know if he has validity or not!
        */

        //Use: Balance Increment
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

        /*void we dont expect to return anythings!, something will be done on the system
         we should give the amoute that we want it (decimal amount)
         its ok to writhe same name of parameters because it is on different scope
        */

        //Use : Withdraw from balance (Balance decrement)
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
        
        //Use: Print account information
        public void GetAccountInfo() { 
            Console.WriteLine(" The account number is :"+ AccountNumber);
            Console.WriteLine(" The account holder is :" + AccountHolderName);
            Console.WriteLine(" The Current balance is :" + Balance);
        }

        //Use: Edit holder name 
        public void editName(string NewName) {
            if (NewName.Length < 40)
            {
                AccountHolderName = NewName;
            }
            else
            {
                Console.WriteLine("Name must be less than 40 chars");
            }
        }

    }
    
}
