using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IEntityRepository<Brand>
    {
        List<Brand> _Brands;

        public InMemoryBrandDal()
        {
            _Brands = new List<Brand>
            {
                new Brand(){BrandId=1, BrandName="Audi"},
                new Brand(){BrandId=2, BrandName="BMW"},
                new Brand(){BrandId=3, BrandName="Ford"},
                new Brand(){BrandId=4, BrandName="Mercedes"},
                new Brand(){BrandId=5, BrandName="Opel"},
                new Brand(){BrandId=6, BrandName="Renault"},
                new Brand(){BrandId=7, BrandName="Volkswagen"},
                new Brand(){BrandId=8, BrandName="Toyota"},
            };
        }

        public void Add(Brand brand)
        {
            _Brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _Brands.Remove(_Brands.SingleOrDefault(b => b.BrandId == brand.BrandId));
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _Brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            brandToUpdate.BrandId = brand.BrandId;
            brandToUpdate.BrandName = brand.BrandName;
        }

        public Brand get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _Brands;
        }
    }
}
