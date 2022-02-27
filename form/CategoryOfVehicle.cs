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
   
    public class CategoryOfVehicle
    {
    public int Id { get; set; }
    
    public string Name { get; set; }

        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("ParentId")]
        public CategoryOfVehicle Parent { get; set; }
        

        public bool AddCategoryOfVehicle()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.CategoryOfVehicles.Add(this);
                db.SaveChanges();
                return true;
            }
        }
        public bool DelCategoryOfVehicle()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }


        public List<CategoryOfVehicle> GetAll()
        {

            return CategoryOfVehicleList.GetCategoriesOfVehicle();
        }
        public List<CategoryOfVehicle> FindByName(string name)
        {
            return CategoryOfVehicleList.GetByName(name);
        }
        public CategoryOfVehicle FindById(int id)
        {
            return CategoryOfVehicleList.GetById(id);
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

        public static class CategoryOfVehicleList
        {
            public static CategoryOfVehicle GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.CategoryOfVehicles.Find(id);
                }
            }
           

            public static List<CategoryOfVehicle> GetByName(string name)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<CategoryOfVehicle> categories = db.CategoryOfVehicles.Where(p => p.Name == name);
                    return categories.ToList();
                }
            }

            public static List<CategoryOfVehicle> GetCategoriesOfVehicle()
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    
                    IEnumerable<CategoryOfVehicle> categories = db.CategoryOfVehicles.Include(p => p.Parent);
                    return categories.ToList();
                }
            }



        }

    }
}
