namespace Project02_BankaHesapYönetimi;

class Program
{
    static void Main(string[] args)
    {
        BankAccount hesap1 = new BankAccount("Ayşe","123345",20000);
        BankAccount hesap2 = new BankAccount("Fatma","6789",15000);
        BankAccount hesap3 = new BankAccount("Ali","32789",10000);

        hesap1.Deposit(500);
        hesap1.Withdraw(200);
        hesap1.ShowBalance();

        hesap2.Deposit(900);
        hesap2.Withdraw(1000);
        hesap2.ShowBalance();

        hesap3.Deposit(2000);
        hesap3.Withdraw(1000);
        hesap3.ShowBalance();

        Console.WriteLine("\nTüm hesapların son durumu:");
        hesap1.ShowBalance();
        hesap2.ShowBalance();
        hesap3.ShowBalance();
    }
}
