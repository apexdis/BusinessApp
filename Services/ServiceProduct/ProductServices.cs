using System;
using System.Collections.Generic;
using System.Text;
using Model.ModelProduct;

namespace Services.ServiceProduct
{
    public class ProductServices : IProduct
    {
        // Created Product List 
        List<Product> products;


        public ProductServices()
        {
            products = new List<Product>(); //Intantiation of Product List
        }

        public void AddProduct(string productId, string productName, decimal productCost, decimal productPrice)
        {
            try
            {
                Product product = new Product()
                {
                    ProductId = productId,
                    ProductName = productName,
                    ProductCost = productCost,
                    ProductPrice = productPrice
                };

                products.Add(product);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProduct(string productId)
        {
            throw new NotImplementedException();
        }

        public void ListProduct()
        {
            throw new NotImplementedException();
        }

        public void SearchProduct(string productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(string productId, string productName, decimal productCost, decimal productPrice)
        {
            throw new NotImplementedException();
        }
    }
}
