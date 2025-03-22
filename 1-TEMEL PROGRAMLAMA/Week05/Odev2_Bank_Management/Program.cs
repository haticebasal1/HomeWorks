namespace Odev2_Bank_Management;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("BANG MANAGEMENT APP");
        Console.WriteLine("-------------------");
        Console.WriteLine();
        BankAccount[] bankAccounts = [
            new BankAccount("Ahmet Can","123456",10000),
            new BankAccount("Mehmet Çelik","432576",200),
            new BankAccount("Ayşen Umay","765213",5000)
        ];
        Console.WriteLine("-------------------");
        bankAccounts[0].Deposit(1000);
        bankAccounts[0].Withdraw(450);
        bankAccounts[0].Deposit(1350);
        bankAccounts[0].ShowBalance();

        Console.WriteLine("-------------------");
        bankAccounts[1].Deposit(900);
        bankAccounts[1].Withdraw(1250); // Yetersiz bakiye
        bankAccounts[1].Deposit(1000);
        bankAccounts[1].Withdraw(1250);
        bankAccounts[1].ShowBalance();

        Console.WriteLine("-------------------");
        bankAccounts[2].Deposit(-1000); // Geçersiz değer
        bankAccounts[2].Withdraw(450);
        bankAccounts[2].Deposit(1350);
        bankAccounts[2].Withdraw(10000); //Yetersiz bakiye
        bankAccounts[2].ShowBalance();
    }
}
