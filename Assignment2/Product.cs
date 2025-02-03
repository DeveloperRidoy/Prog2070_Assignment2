using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public double ItemPrice { get; set; }
        public int StockAmount { get; set; }

        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public void IncreaseStockCount(int stockAmount)
        {
            StockAmount += stockAmount;
        }

        public void DecreaseStockCount(int stockAmount)
        {
            StockAmount -= stockAmount;
        }
    }
}
