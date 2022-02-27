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
   public class Discount
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public decimal PriceModifier { get; set; }
    public bool IsOptional { get; set; }
    public bool ForAllCategories { get; set; }
    public bool ForAllBranches { get; set; }

    public bool ForAllServices { get; set; }

        public List<CategoryOfVehicle> categories = new List<CategoryOfVehicle>();
        public List<Branch> branches = new List<Branch>();
        public List<Service> services = new List<Service>();



        public bool AddDiscount(List<CategoryOfVehicle> category, List<Branch> branch, List<Service> service)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                this.categories = category;
                this.branches = branch;
                this.services = service;
                db.Discounts.Add(this);
                db.SaveChanges();
                AddDiscountPare(db.Discounts.Max(x => x.Id));
                
                
                return true;
            }
        }
        public bool AddDiscountPare(int id)
        {

            using (ApplicationContext db = new ApplicationContext())
            {

                if(categories != null)
                {
                    foreach (CategoryOfVehicle item in categories)
                    {
                        db.DiscountCategoriesVehicle.Add(new DiscountCategoriesVehicle()
                        {
                            DiscountId = id,
                            IdCategory = item.Id
                        });
                    }
                }
              if(branches != null)
              {
                    foreach (Branch item in branches)
                    {
                        db.DiscountBranches.Add(new DiscountBranches()
                        {
                            DiscountId = id,
                            BranchId = item.Id
                        });

                    }
                }
               if(services != null)
               {
                    foreach (Service item in services)
                    {
                        db.DiscountServices.Add(new DiscountServices()
                        {
                            DiscountId = id,
                            ServiceId = item.Id
                        });

                    }
                }
             
                db.SaveChanges();
                return true;
                
            }
        }
        public bool DelDiscount()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }
        public string Get_City(string address)
        {
            string[] str2;
            str2 = address.Split(',');
            return str2[0];

        }
       
        public List<Discount> GetAll(Discount FilterA, Discount FilterB)
        {

            return DiscountList.GetDiscounts(FilterA, FilterB);
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
        public Discount FindById(int z)
        {
           return  DiscountList.GetById(z);
        }
        public List<Branch> FindDiscountBranches(Discount item)
        {
            Branch branch = new Branch();
            List<Branch> list = new List<Branch>();
            foreach (DiscountBranches obj in DiscountList.GetDiscountBranches(item))
            {
              
                list.Add(branch.FindById(obj.BranchId));
            }
            return list;
        }

        public static class DiscountList
        {
            public static Discount GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.Discounts.Find(id);
                }
            }


            public static List<Discount> GetDiscounts(Discount FilterA, Discount FilterB)
            {


                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<Discount> discounts = db.Discounts;
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            discounts = discounts.Where(p => p.Id == FilterA.Id);
                        }
                        if (FilterA.Name != "")
                        {
                            discounts = discounts.Where(c => c.Name == FilterA.Name);
                        }

                        //if (FilterB.Branch != null)
                        //{
                        //    discounts = discounts.Where(z => z.BranchId == FilterA.Branch.Id);
                        //}
                        //if (FilterA.Branch != null)
                        //{
                        //    discounts = discounts.Where(m => m.Get_City(m.Branch.Address) == FilterA.Branch.Address);
                        //}
                        if (FilterA.Start != null && FilterA.End == null)
                        {
                            discounts = discounts.Where(m => m.Start >= FilterA.Start);
                        }
                        if (FilterA.End != null && FilterA.Start == null)
                        {
                            discounts = discounts.Where(m => m.Start >= FilterA.Start);
                        }
                        if (FilterA.End != null && FilterA.Start != null)
                        {
                            discounts = discounts.Where(m => m.Start >= FilterA.Start && m.End >= FilterA.End);

                        }


                    }




                    return discounts.ToList();
                }

            }

            public static List<DiscountBranches> GetDiscountBranches(Discount FilterA)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<DiscountBranches> discounts = db.DiscountBranches;
                    discounts = discounts.Where(p => p.DiscountId == FilterA.Id);
                    return discounts.ToList();
                }
               
            }
        }

   }
}
