using System;

namespace Project02_BankaHesapYönetimi;

public class BankAccount
{
    public string Owner { get; set; }
    public string AccountNumber { get; private set; }
    public decimal Balance { get; private set; }
    public BankAccount(string owner,string accountNumber,decimal initialbalance=0)
    {
        Owner=owner;
        AccountNumber=accountNumber;
        Balance=initialbalance;
    }
 public void Deposit(decimal amount)
 {
    if (amount>0)
    {
        Balance+=amount;
        Console.WriteLine($"\n{amount} TL yatırıldı.Yeni bakiye:{Balance} TL");
    }
    else
    {
        Console.WriteLine("Geçersiz tutar");
    }
 }
 public void Withdraw(decimal amount)
 {
    if (amount>0&& amount<=Balance)
    {
        Balance-=amount;
        Console.WriteLine($"{amount} TL çekildi.Yeni bakiye:{Balance} TL");
    }
    else
    {
        Console.WriteLine("Yetersiz bakiye veya geçersiz tutar!");
    }
 }
 public void ShowBalance()
 {
    Console.WriteLine($"{Owner} hesabının güncel bakiyesi:{Balance} TL");
    
 }
}
