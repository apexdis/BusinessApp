using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelProduct
{
    public interface IProduct
    {
        void AddProduct(string productId, string productName, decimal productCost, decimal productPrice);
        void SearchProduct(string productId);
        void UpdateProduct(string productId, string productName, decimal productCost, decimal productPrice);
        void DeleteProduct(string productId);
        void ListProduct();
    }
}
