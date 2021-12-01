using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfApartmentDal : IApartmentDal
    {
        public void Add(Apartment entity)
        {
            using(FTSContext context=new FTSContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Apartment entity)
        {
            using (FTSContext context = new FTSContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Apartment Get(Expression<Func<Apartment, bool>> filter)
        {
            using (FTSContext context = new FTSContext())
            {
                return context.Set<Apartment>().SingleOrDefault(filter);
            }
        }

        public List<Apartment> GetAll(Expression<Func<Apartment, bool>> filter = null)
        {
            using (FTSContext context = new FTSContext())
            {
                return filter == null 
                     ? context.Set<Apartment>().ToList()
                     : context.Set<Apartment>().Where(filter).ToList();
            }
        }

        public void Update(Apartment entity)
        {
            using (FTSContext context = new FTSContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
