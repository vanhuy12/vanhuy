using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Repository
{
    interface IProduct
    {
        void InsertProduct(Models.Product product); 

        IEnumerable<Models.Product> GetProducts(); 

        Models.Product GetProductByID(int ProductID); 

        void UpdateProduct(Models.Product product);

        void DeleteProduct(int ProductID);

        void Save();

        IEnumerable<Models.Product> FindProductByName(string ProductName);
    }
}