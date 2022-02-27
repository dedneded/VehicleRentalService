using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace form
{
    public class Branch
    {

        public int Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        


        public bool AddBranch()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Branches.Add(this);
                db.SaveChanges();
                return true;
            }
        }
        public bool DelBranch()
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
        public string Get_Street(string address)
        {
            string[] str2;
            str2 = address.Split(' ');
            return str2[1];

        }

        public List<Branch> GetAll(Branch FilterA, Branch FilterB)
        {

            return BranchList.GetBranches(FilterA, FilterB);
        }

        public Branch FindById(int id)
        {

            return BranchList.GetById(id);
        }
        
        public static class BranchList
        {
            public static Branch GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.Branches.Find(id);
                }
            }
            


            public static List<Branch> GetBranches(Branch FilterA, Branch FilterB)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<Branch> branches = db.Branches;
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            branches = branches.Where(n => n.Id == FilterA.Id);
                        }
                        if (FilterA.Address != "")
                        {

                                    branches = branches.Where(p => p.Get_City(p.Address) == FilterA.Address);
                                                     
                        }
                        if(FilterB.Address != "")
                        {
                                branches = branches.Where(c => c.Get_Street(c.Address) == FilterB.Address);
                            
                        }

                    }
                    return branches.ToList();
                }
                
            }

        }
    }
}
