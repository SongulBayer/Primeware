using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product t)
        {
            _productDal.Insert(t);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> getList()
        {
            return _productDal.GetListAll();
        }

        public Product TgetByid(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
        public List<Product> GetProductById(int id)
        {
            return _productDal.GetListAll(x => x.Id == id);
        }
    }
}
