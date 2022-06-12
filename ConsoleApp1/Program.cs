﻿
using System;
public class cardholder
{
    public string cardNum;
    int pin;
    string firstname;
    string lastname;
    public double balance;

    public cardholder(string CardNum, int Pin, string Firstname, string Lastname, double Balance)
    {
        this.cardNum = CardNum;
        this.pin = Pin;
        this.firstname = Firstname;
        this.lastname = Lastname;
        this.balance = Balance;
    }
    public string getCardNum { get { return cardNum; } }
    public int getPin { get { return pin; } }
    public string getFirstname { get { return firstname; } }
    public double getBalance { get { return balance; } }
    public string getLastname { get { return lastname; } }

    public void setCardNum(string CardNum) { cardNum = CardNum; }
    public void setPin(int Pin) { pin = Pin; }
    public void setFirstName(string Firstname) { firstname = Firstname; }
    public void setLastName(string Lastname) { lastname = Lastname; }
    public void setBalance(double Balance) {  balance = Balance; }

    static void Main(string[] args)
    {  
        void print_options() {
            Console.WriteLine("Choose from the following option:");
            Console.WriteLine("Press 1 for Deposite");
            Console.WriteLine("Press 2 for Withdraw");
            Console.WriteLine("Press 3 for Balance check");
            Console.WriteLine("Press 4 for Exit");
        }
        

        void deposit(cardholder currentuser)
        {   
            Console.WriteLine("How much money do you want to deposit on your account?");
            double deposit = double.Parse(Console.ReadLine());
            currentuser.setBalance(deposit+currentuser.getBalance);
            Console.WriteLine("You have Deposited"+deposit.ToString()+" BDT on your account.");
            Console.WriteLine("Your current balance is "+currentuser.getBalance.ToString()+"BDT.");
        }
        void withdraw(cardholder currentuser)
        {
            Console.WriteLine("How much money do you want to withdraw from your account?");
            double withdraw = double.Parse(Console.ReadLine());
            if (withdraw > currentuser.getBalance)
            {
                Console.WriteLine("Sorry!You dont have enough money");
            }
            else
            {
                Console.WriteLine("Withdrawal Successful");
                currentuser.setBalance(currentuser.getBalance - withdraw);
                Console.WriteLine("Your current balance is " + currentuser.getBalance + " BDT");
            }

        }

        void checkBalance(cardholder currentuser)
        {
            Console.WriteLine("Your current Balance is" + currentuser.getBalance.ToString() + "BDT");
        }


        List<cardholder> Cardholders = new List<cardholder>();
        Cardholders.Add(new cardholder("12121212", 1234, "dwain", "jonson", 3000.00));
        Cardholders.Add(new cardholder("23232323", 1111, "istiaq", "ahmed", 20000.00));
        Cardholders.Add(new cardholder("34343434", 2222, "imtiaz", "ahmed", 40000.00));
        Cardholders.Add(new cardholder("45454545", 3333, "zarin", "tasnim", 50000.00));
        Cardholders.Add(new cardholder("56565656", 4444, "mojnu", "ara", 500000.00));
        Cardholders.Add(new cardholder("67676767", 5555, "rafiqul", "islam", 600000.00));

        Console.WriteLine("Welcome to ATM management system.");
        Console.WriteLine("please enter your credit card number...");
        string debitCardNum = "";
        cardholder currentuser;

        while (true)
        {
            try {
                debitCardNum = Console.ReadLine();
                currentuser = Cardholders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if(debitCardNum != null) { break; }
                else
                {
                    Console.WriteLine("Enter Valid cardnumber & try again.");
                }
            }
            catch { Console.WriteLine("Try again with Valid Cardnumber."); }
              
        }

        Console.WriteLine("Enter your security pin number...");
        int security_pin=0;

        while (true)
        {
            try
            {
                security_pin = int.Parse(Console.ReadLine());
                if(currentuser.getPin==security_pin) { break; }
                else
                {
                    Console.WriteLine("Enter Valid security pin & try again.");
                }
            }
            catch
            {
                Console.WriteLine("Try again with Valid security pin number");
            }
        }
        Console.WriteLine("Welcome " + currentuser.getFirstname + ".");

        while(true)
        {
            print_options();
            int choose =int.Parse(Console.ReadLine());
            if(choose==1) { deposit(currentuser); }
            else if(choose==2) { withdraw(currentuser); }
            else if(choose ==3) { checkBalance(currentuser); }
            else if(choose==4) { break; }
            else { Console.WriteLine("Enter valid number to choose option."); }
        }
        Console.WriteLine("Thanks!Have a nice day");

    }


}
