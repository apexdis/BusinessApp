using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.ServiceProduct;

namespace UnitTestServices
{
    [TestClass]
    public class UnitTestProductServices
    {
        ProductServices productServices;

        [TestInitialize]
        public void InitializeProductService()
        {
            productServices = new ProductServices();
        }


        [TestMethod]
        public void TestMethodAddProdcut()
        {
            productServices.AddProduct("ABC123", "Pencil 2B", (decimal)15.00, (decimal)25.00);
        }
    }
}
