using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
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
                if (filter(p))
                {
                    r.Add(p1);
                }
            }
            return r;
        }

        public override string ToString()
        {
            return products.ToString();
        }
    }
}
