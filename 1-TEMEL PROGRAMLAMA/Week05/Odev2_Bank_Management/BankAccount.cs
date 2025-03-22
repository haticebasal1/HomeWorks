using System;

namespace Odev2_Bank_Management
{
    public class BankAccount
    {
        public BankAccount(string owner, string accountNumber, decimal balance)
        {
            Owner = owner;
            AccountNumber = accountNumber;
            Balance = Math.Max(0, balance);
            Console.WriteLine($"{Owner} adlı hesap, {balance:C2} bakiye ile açıldı...");
        }
        public string Owner { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Owner} adlı hesaba {amount:C2} yatırıldı.(Yeni Bakiye: {Balance:C2})");
            }
            else
            {
                Console.WriteLine("Geçersiz bir miktar yatırılmaya çalışıldığı için, para yatırma işlemi gerçekleştirilemedi.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Geçersiz miktar girildiği için para çekme işlemi tamamlanamadı...");
            }
            else if (Balance < amount)
            {
                Console.WriteLine($"Yetersiz bakiye({Balance:C2} bakiye bulunmaktadır.) Bu yüzden {amount:C2} para çekme işlemi tamamlanamadı...");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"{Owner} adlı hesaptan {amount:C2} para çekme işlemi tamamlandı.(Yeni Bakiye: {Balance:C2})");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"{Owner} adlı hesabın bakiyesi: {Balance:C2}");
        }
    }
}
    

