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
            get {
                return price;
            }
            set {
                price = value;
            }
        }


        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public DateTime ExpirationDate
        {
            get
            {
                return expirationDate;
            }
            set
            {
                expirationDate = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Price: {0}, Category: {1}, Expiration Date: {2}", price, category, expirationDate);
        }
    }

    class Store
    {
        private List<Product> products;

        public Store()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public List<Product> getProducts(Filter filter, Product p)
        {
            List<Product> r = new List<Product>();
            foreach (Product p1 in products)
            {
                if (filter(p1, p))
                {
                    r.Add(p1);
                }
            }
            return r;
        }

        public override string ToString()
        {
            String r = "{/n";
            foreach (Product p in products)
            {
                r += p.ToString() + "/n";
            }
            r += "}";
            return r;
        }
    }

    public delegate bool Filter(Product p1, Product p2);

    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Product productToCompare = new Product(50, "Dairy", new DateTime(2020, 1, 1));

            store.AddProduct(new Product(30, "Dairy",new DateTime(2020, 6, 1)));
            store.AddProduct(new Product(40, "Vegetables", new DateTime(2019, 6, 1)));
            store.AddProduct(new Product(60, "Vegetables", new DateTime(2018, 6, 1)));
            store.AddProduct(new Product(70, "Dairy", new DateTime(2021, 6, 1)));

            List<Product> products1 = store.getProducts(
                (p1,p2) => p1.Price > p2.Price, 
                productToCompare
            );

            List<Product> products2 = store.getProducts(
                (p1, p2) => p1.ExpirationDate > p2.ExpirationDate,
                productToCompare
            );

            List<Product> products3 = store.getProducts(
                (p1, p2) => p1.Category.Equals(p2.Category),
                productToCompare
            );

            foreach (Product p in products1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            foreach (Product p in products2)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            foreach (Product p in products3)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
