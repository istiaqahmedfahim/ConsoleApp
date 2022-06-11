
using System;
public class cardholder
{
    string cardNum;
    int pin;
    string firstname;
    string lastname;
    double balance;

    public cardholder(string cardNum, int pin, string firstname, string lastname, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstname = firstname;
        this.lastname = lastname;
        this.balance = balance;
    }
    public string getCardNum { get { return cardNum; } }
    public int getPin { get { return pin; } }
    public string getFirstname { get { return firstname; } }
    public double getBalance { get { return balance; } }
    public string getLastname { get { return lastname; } }

    public void setCardNum(string cardNum) { cardNum = cardNum; }
    public void setPin(int pin) { pin = pin; }
    public void setFirstName(string firstname) { firstname = firstname; }
    public void setLastName(string lastname) { lastname = lastname; }
    public void setBalance(double balance) { balance = balance; }

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
            currentuser.setBalance(deposit);
            Console.WriteLine("You have Deposited"+currentuser.getBalance.ToString()+" BDT on your account.");
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
                double current_balance = currentuser.getBalance - withdraw;
                currentuser.setBalance(current_balance);
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
            catch { Console.WriteLine("Try again with Valid Cardnumber.") };
              
        }

    }


}
