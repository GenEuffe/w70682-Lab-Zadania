using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp1;


// Zadanie 1

/*
Person person = new Person("Jan", "Nowak", 23);
person.WyświetlInformacje();
Person person1 = new Person("J", "Nowak", 23);
person1.WyświetlInformacje();
Person person2 = new Person("Jan", "N", 23);
person2.WyświetlInformacje();
Person person3 = new Person("Jan", "Nowak", -23);
person3.WyświetlInformacje();
*/

// Zadanie 2

/*
BankAccount account = new BankAccount("Default Name", 0);

account.Deposit(500);
Console.WriteLine($"Balance: {account.balance}");
account.Withdrawal(200);
Console.WriteLine($"Balance: {account.balance}");
account.Withdrawal(500);
*/

Student person = new Student("Jan", "Nowak", 23, "Sucharskiego", "Rzeszów", "12-123", 12345);

person.WyświetlInformacje();