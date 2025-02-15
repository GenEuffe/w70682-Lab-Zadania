namespace ConsoleApp1
{   
    // Zadanie 1

    internal class Person
    {
        //pola klasy
        private string firstname;
        private string lastname;
        private int age;
        private Adres adres;

        //konstruktor
        public Person(string firstName, string lastName, int age, Adres adres)
        {
            firstname = firstName;
            lastname = lastName;
            Age = age;
        }

        //właściwości
        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (value.Length <= 2) { firstname = value; }
                else { Console.WriteLine("Imię musi mieć conajmnniej 2 znaki!"); }
            }
        }

        public string LastName
        {
            get { return lastname; }
            set
            {
                if (value.Length >= 2) { lastname = value; }
                else { Console.WriteLine("Nazwisko musi mieć conajmnniej 2 znaki!"); }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age >= 0) { age = value; }
                else { Console.WriteLine("Wiek musi być liczbą dodatnią!"); }
            }
        }

        //metoda
        public virtual void WyświetlInformacje()
        {
            Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}, Wiek: {Age}");
        }

    }

    // Zadanie 2

    internal class BankAccount
    {
        //class fields
        private string owner;
        public decimal balance;

        //constructor
        public BankAccount(string Owner, int Balance)
        {
            owner = Owner;
            balance = Balance;
        }

        //methods
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdrawal(decimal amount)
        {
            if (balance >= amount) { balance -= amount; }
            else { Console.WriteLine("Insufficient funds!"); }
        }
    }

    internal class Student : Person
    {
        private int nrAlbumu;
        public int NrAlbumu { get { return nrAlbumu; } set { nrAlbumu = value; } }

        public Student(string firstName, string lastName, int age, Adres adres, int nrAlbumu):
            base(firstName, lastName, age, adres)
        {
            NrAlbumu = nrAlbumu;
        }

        public void Info()
        {
            WyświetlInformacje();
            Console.WriteLine($"Nr. Albumu: {NrAlbumu}");
        }

        public override void WyświetlInformacje()
        {
            base.WyświetlInformacje();
            Console.WriteLine($"Nr. Albumu: {NrAlbumu}");
        }
    }

    internal class Adres
    {
        private string ulica;
        private string miasto;
        private string postal;
        
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string Postal { get; set; }

        public Adres(string ulica, string miasto, string postal)
        {
            Ulica = ulica;
            Miasto = miasto;
            Postal = postal;
        }

        public void WypiszAdres()
        {
            Console.WriteLine($"Ulica: {Ulica} Miasto: {Miasto} Kod Pocztowy: {Postal}");
        }
    }
}