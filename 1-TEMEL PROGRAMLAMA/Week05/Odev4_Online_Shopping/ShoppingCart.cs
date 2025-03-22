using System;

namespace Odev4_Online_Shopping;

public class ShoppingCart
{
public ShoppingCart()
        {
            Count = 0;
            Items = new Product[Count];
        }
        private Product[] Items { get; set; }
        private int Count { get; set; }

        public void AddToCart(Product product)
        {
            ResizeArray(Count + 1);
            Items[Count++] = product;
            Console.WriteLine($"{product.Name} sepete eklendi.");
        }

        public void RemoveProduct(string productName)
        {
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if (Items[i].Name.ToLower() == productName.ToLower())
                {
                    index = i;
                    break;
                }
            }
            // ["A","B","C","D","E"]  bunlardan C'yi remove yapmak istiyorum.
            // Yukarıda C'nin indexini bulmuş olduk, index=2
            // ["A","B","D","E","E"]
            // ["A","B","D","E"]
            if (index != -1)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    Items[i] = Items[i + 1];
                }
                ResizeArray(Count - 1);
                Count--;
                Console.WriteLine($"{productName} adlı ürün sepetten çıkarıldı.");
            }
            else
            {
                Console.WriteLine($"{productName} adlı ürün sepette bulunamadığı için çıkarma işlemi yapılamadı!");
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (Product nextItem in Items)
            {
                total += nextItem.Price;
            }
            return total;
        }

        public void Display()
        {
            Console.WriteLine("Sepetiniz");
            foreach (Product nextItem in Items)
            {
                Console.WriteLine($"{nextItem.Name} - {nextItem.Price:C2}");
            }
            Console.WriteLine();
            Console.WriteLine($"Toplam Tutar: {CalculateTotal():C2}");
        }
        private void ResizeArray(int newSize)
        {
            Product[] tempItems = new Product[newSize];
            for (int i = 0; i < Math.Min(Count, newSize); i++)
            {
                tempItems[i] = Items[i];
            }
            Items = tempItems;
  }
    }
