using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace form
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

      
        public bool AddService()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Services.Add(this);
                db.SaveChanges();
                return true;
            }
        }
        public bool DelService()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }

        public List<Service> GetAll(Service FilterA, Service FilterB)
        {

            return ServiceList.GetServices(FilterA, FilterB);
        }
        public Service FindById(int id)
        {
            return ServiceList.GetById(id);
        }
        public Service FindByName(string z)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

               
                return db.Services.Where(c => c.Name == z).ToList()[0];
            }
        }
        public List<Service> GetRent()
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                IEnumerable<Service> services = db.Services.Where(c => c.Name == "Аренда");
                return services.ToList();
            }
           
        }

        //public bool EditClient()
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {

        //        db.Entry(this).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return true;


        //    }
        //}

        public static class ServiceList
        {
            public static Service GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.Services.Find(id);
                }
            }

           
            public static List<Service> GetServices(Service FilterA, Service FilterB)
            {
                //string Sorting, string AskOrDesc, int Count, int Page
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<Service> services = db.Services;
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            services = services.Where(p => p.Id == FilterA.Id);
                        }
                        if (FilterA.Name != "")
                        {
                            services = services.Where(c => c.Name == FilterA.Name);
                        } 

                    }




                    return services.ToList();
                }

            }




        }
    }
}
