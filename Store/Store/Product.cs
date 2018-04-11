using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        private int price;
        private String category;
        private DateTime expirationDate;

        public Product(int price, String category, DateTime expirationDate)
        {
            this.price = price;
            this.category = category;
            this.expirationDate = expirationDate;
        }

        public int Price
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public DateTime ExpirationDate
        {
            get;
            set;
        }

        public override string ToString()
        {
            return String.Format("Price: {0} /n Category: {1} /n Expiration Date: {2}", price, category, expirationDate);
        }
    }
}
