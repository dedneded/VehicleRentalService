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
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool AddRole()
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                db.Roles.Add(this);
                db.SaveChanges();
                return true;
            }
        }
        public bool DelRole()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }

        public List<Role> GetAll(Role FilterA, Role FilterB)
        {

            return RoleList.GetRoles(FilterA, FilterB);
        }
        public Role FindById(int s)
        {
            return RoleList.GetById(s);
        }
        public static class RoleList
        {
            public static Role GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.Roles.Find(id);
                }
            }

            public static List<Role> GetRoles(Role FilterA, Role FilterB)
            {
                //string Sorting, string AskOrDesc, int Count, int Page
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<Role> roles = db.Roles;
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            roles = roles.Where(p => p.Id == FilterA.Id);
                        }
                        if (FilterA.Name != "")
                        {
                            roles = roles.Where(c => c.Name == FilterA.Name);
                        }
                     
                    }
                    return roles.ToList();
                }
            }



        }
    }
}
