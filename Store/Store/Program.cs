using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public delegate int CompareTo(Product p1, Product p2);
    public delegate bool Filter(Product value);

    class Program
    {
        public bool IsPriceGreatherThan(Product p1, Product p2)
        {
            bool r = false;
            if (p1.Price.CompareTo(p2.Price) > 0)
            {
                r = true;
            }
            return r;
        }

        //public bool IsExpirationDateGreatherThan(Product p1, Product p2)
        //{
        //    bool r = false;
        //    if (p1.ExpirationDate.CompareTo(p2.ExpirationDate) > 0)
        //    {
        //        r = true;
        //    }
        //    return r;
        //}

        //public bool isPriceEqual(Product p1, Product p2)
        //{

        //}       

        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddProduct(new Product(20, "Dairy",new DateTime(2020, 6, 1)));
            store.AddProduct(new Product(30, "Dairy", new DateTime(2020, 6, 1)));
            store.AddProduct(new Product(40, "Dairy", new DateTime(2020, 6, 1)));
            store.AddProduct(new Product(50, "Dairy", new DateTime(2020, 6, 1)));

            //Filter f = is
            //store.getProducts(isPriceGreatherThan, new Product(20, "Dairy", new DateTime(2020, 6, 1)));

            
        }
    }
}
