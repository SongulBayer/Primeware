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
    public class ReferenceManager : IReferenceService
    {
        IReferenceDal _referenceDal;

        public ReferenceManager(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }
        public void Add(Reference t)
        {
            _referenceDal.Insert(t);    
        }

        public void Delete(Reference product)
        {
            _referenceDal.Delete(product);
        }

        public List<Reference> getList()
        {
          return  _referenceDal.GetListAll();
        }

        public Reference TgetByid(int id)
        {
            return  _referenceDal.GetById(id);   
        }

        public void Update(Reference product)
        {
            _referenceDal.Update(product);
        }
    }
}
