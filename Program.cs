using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;
using Banking;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ob1 = new Person("Varsha", "Ghute", "varshaghute35@gmail.com", 7385731507);
            Person ob2 = new Person("Samisha", "Jadhav", "jadhavsamisha19@gmail.com", 9011251658);
            Console.WriteLine("FirstName:"+ob1.GetFirstName() + "\nLastName:"+ob1.GetLastName() + "\nEmail:"+ob1.GetEmailid()+"\nContact Number:"+ ob1.GetContactNumber());
            Console.WriteLine("\nFirstName:" + ob2.GetFirstName() + "\nLastName:" + ob2.GetLastName() + "\nEmail:" + ob2.GetEmailid() + "\nContact Number:" + ob2.GetContactNumber());
            Console.WriteLine("\nTotal Object: " + Person.getCount());
            Console.ReadLine();
            /*
            Console.WriteLine("*****************************");
            Account a1 = new Account(101, "Shital", 12000);
            Console.WriteLine("Account ID : " + a1.GetaccountId() + "\nAccount Holder Name : " + a1.GetaccountHolder() + "\nAccount Balance : " + a1.Getbalance());
            Console.WriteLine("*****************************");
            a1.deposit(6000);
            Console.WriteLine("Balance After deposite :");
            Console.WriteLine("Account ID : " + a1.GetaccountId() + "\nAccount Holder Name : " + a1.GetaccountHolder() + "\nAccount Balance : " + a1.Getbalance());
            Console.WriteLine("*****************************");
            a1.withdraw(3000);
            Console.WriteLine("Balance After Withdraw :");
            Console.WriteLine("Account ID : " + a1.GetaccountId() + "\nAccount Holder Name : " + a1.GetaccountHolder() + "\nAccount Balance : " + a1.Getbalance());
            Console.ReadLine();
            */
        }
    }
}
