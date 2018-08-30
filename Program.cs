using System;
using System.Collections.Generic;

namespace tuples
{
  class Program
  {
    static void Main(string[] args)
    {
      List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>() {

// Option 1
      ("Hammer", 19.99, 25),
      ("Nails", 7.99, 100),
      ("Nail Gun", 189.99, 1)

      };

// Option 2
      transactions.Add(("Bandaids", 6.72, 250));

// Option 3 - says this is the best way because it explains to someone what is actually going on if they aren't aware
      (string product, double amount, int quantity) staples = ("Staples", 3.98, 50);
      transactions.Add(staples);

      int TotalProductsSold = 0;
      double TotalRevenue = 0;

      foreach ((string product, double amount, int quantity) t in transactions)
      {
        // Logic goes here to look up quantity and amount in each transaction

        TotalProductsSold += t.quantity;
        TotalRevenue += t.quantity * t.amount;
      }
      Console.WriteLine($"We sold {TotalProductsSold} products for a total revenue of ${TotalRevenue}");
    }
  }
}
