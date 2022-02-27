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
    public class Employee : Person
    {
        public string Login { get; set; }
        public string Pass { get; set; }

        public decimal Salary { get; set; }


        [Column("Role_Id")]
        public int? RoleId { get; set; }

        [Column("Role_Id")]
        public Role Role { get; set; }

        [Column("Branch_Id")]
        public int? BranchId { get; set; }

        [Column("Branch_Id")]
        public Branch Branch { get; set; }



        public List<Employee> GetAll(Employee FilterA, Employee FilterB)
        {

            return EmployeeList.GetEmployees_Filters(FilterA, FilterB);
        }
        public Employee FindById(int id)
        {
            return EmployeeList.GetById(id);
        }

        public static class EmployeeList
        {
            public static Employee GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Employee employee = db.Employees.Find(id);
                    db.Entry(employee).Reference(m => m.Branch).Load();
                    db.Entry(employee).Reference(m => m.Role).Load();


                    return employee;

                  
                }
            }


            public static List<Employee> GetEmployees_Filters(Employee FilterA, Employee FilterB)
            {
                //string Sorting, string AskOrDesc, int Count, int Page
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<Employee> employees = db.Employees.Include(p => p.Role).Include(c => c.Branch);
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            employees = employees.Where(p => p.Id == FilterA.Id);
                        }
                        if (FilterA.Fio != "")
                        {
                            employees = employees.Where(c => c.Fio == FilterA.Fio);
                        }
                        if (FilterA.Phone != "")
                        {
                            employees = employees.Where(n => n.Phone == FilterA.Phone);
                        }
                        if (FilterA.Branch != null)
                        {
                            employees = employees.Where(m => m.BranchId == FilterA.Branch.Id);
                        }
                      if(FilterA != null)
                      {
                            if (FilterA.Salary > 0 && FilterB.Salary == 0)                                           // от указанной до любой
                            {
                                employees = employees.Where(m => m.Salary >= FilterA.Salary);
                            }
                        }
                           
                        if(FilterB != null)
                        {
                            if (FilterA.Salary == 0 && FilterB.Salary > 0)                                                                 // от любой до указанной
                            {
                                employees = employees.Where(m => m.Salary <= FilterB.Salary);
                            }
                        }
                            
                        if(FilterA != null && FilterB != null)
                        {
                            if (FilterA.Salary > 0 && FilterB.Salary > 0)                                           // от указанной до указанной
                            {
                                employees = employees.Where(m => m.Salary >= FilterA.Salary && m.Salary <= FilterB.Salary);
                            }
                        }
                           
                        
                       

                    }




                    return employees.ToList();
                }

            }

        }


    }
    public enum DrivingCaregories
    {
        C,
        CE,
        C1,
        C1E
    }
    public class Driver : Employee
    {
        public string DrivingLicense { get; set; }
        public List<DrivingCaregories> Category = new List<DrivingCaregories>();
        public List<int> Categories { get; set; }

    
        public bool AddDriver(List<int> categories)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
               
               
                db.Drivers.Add(this);
                db.SaveChanges();
                AddDriverPare(db.Drivers.Max(x => x.Id), categories);
               
                

                return true;
            }
        }

        public List<DrivingCaregories> GetCategories()
        {
            foreach (int item in Categories)
            {
                switch (item)
                {
                    case 0:
                        Category.Add(DrivingCaregories.C);
                        break;
                    case 1:
                        Category.Add(DrivingCaregories.CE);
                        break;
                    case 2:
                        Category.Add(DrivingCaregories.C1);
                        break;
                    case 3:
                        Category.Add(DrivingCaregories.C1E);
                        break;
                }


                //case 0:
                //    return DrivingCaregories.С;
                //case 1:
                //    return DrivingCaregories.СE;
                //case 2:
                //    return DrivingCaregories.С1;
                //case 3:
                //    return DrivingCaregories.С1E;
                //default:
                //    return DrivingCaregories.Unknown;
            }
            return Category;
        }
    
            public bool AddDriverPare(int id, List<int> categories)
            {
            using (ApplicationContext db = new ApplicationContext())
            {

                    foreach (int item in categories)
                    {
                        db.DriverCategories.Add(new DriverCategories()
                        {
                            DriverId = id,
                            Category = item
                        });
                    }
               
                db.SaveChanges();
            }
            
            return true;
        }
        
        public bool DelDriver()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }

        public List<Driver> GetAllDrivers(Driver FilterA, Driver FilterB)
        {

            return DriverList.GetDrivers(FilterA, FilterB);
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
        public Driver FindByIdDriver(int id)
        {
            return DriverList.GetById(id);
        }
         public List<int> FindDrivingCaregories(Driver driver)
         {
            List<int> list = new List<int>();
            foreach(DriverCategories item in DriverList.GetDriverCategories(driver))
            {
                list.Add(item.Category);
            }
            return list;
           
         }

    }
    

    public static class DriverList
        {
        public static Driver GetById(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                Driver driver = db.Drivers.Find(id);
                db.Entry(driver).Reference(m => m.Branch).Load();
                db.Entry(driver).Reference(m => m.Role).Load();


                return driver;
            }
        }

        public static List<Driver> GetDrivers(Driver FilterA, Driver FilterB)
            {
               

                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<Driver> drivers = db.Drivers.Include(p => p.Role).Include(c => c.Branch);
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            drivers = drivers.Where(p => p.Id == FilterA.Id);
                        }
                        if (FilterA.Fio != "")
                        {
                            drivers = drivers.Where(c => c.Fio == FilterA.Fio);
                        }
                        if (FilterA.Phone != "")
                        {
                            drivers = drivers.Where(n => n.Phone == FilterA.Phone);
                        }
                        if (FilterA.Branch != null)
                        {
                            drivers = drivers.Where(m => m.BranchId == FilterA.Branch.Id);
                        }

                        if (FilterA.Salary > 0 && FilterB.Salary == 0)                                           // от указанной до любой
                        {
                            drivers = drivers.Where(m => m.Salary >= FilterA.Salary);
                        }

                        if (FilterA.Salary == 0 && FilterB.Salary > 0)                                                                 // от любой до указанной
                        {
                            drivers = drivers.Where(m => m.Salary <= FilterB.Salary);
                        }

                        if (FilterA.Salary > 0 && FilterB.Salary > 0)                                           // от указанной до указанной
                        {
                            drivers = drivers.Where(m => m.Salary >= FilterA.Salary && m.Salary <= FilterB.Salary);
                        }

                    }




                    return drivers.ToList();
                }

            }

        public static List<DriverCategories> GetDriverCategories(Driver FilterA)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<DriverCategories> drivers = db.DriverCategories;
                drivers = drivers.Where(p => p.DriverId == FilterA.Id);
                return drivers.ToList();
            }

        }


    }
    

     public class Manager : Employee

    {
       
        public bool AddManager()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Managers.Add(this);
                db.SaveChanges();
                //db.Employees.Add(this);
                //db.SaveChanges();
                return true;
            }
        }
        public bool DelManager()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }

        public List<Manager> GetAllManagers(Manager FilterA, Manager FilterB)
        {

            return ManagerList.GetManagers(FilterA, FilterB);
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
        public Manager FindByIdManager(int z)
        {
            return ManagerList.GetById(z);
        }

        public static class ManagerList
        {
            public static Manager GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.Managers.Find(id);
                }
            }

            public static List<Manager> GetManagers(Manager FilterA, Manager FilterB)
            {


                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<Manager> managers = db.Managers.Include(p => p.Role).Include(c => c.Branch);
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            managers = managers.Where(p => p.Id == FilterA.Id);
                        }
                        if (FilterA.Fio != "")
                        {
                            managers = managers.Where(c => c.Fio == FilterA.Fio);
                        }
                        if (FilterA.Phone != "")
                        {
                            managers = managers.Where(n => n.Phone == FilterA.Phone);
                        }
                        if (FilterA.Branch != null)
                        {
                            managers = managers.Where(m => m.BranchId == FilterA.Branch.Id);
                        }

                        if (FilterA.Salary > 0 && FilterB.Salary == 0)                                           // от указанной до любой
                        {
                            managers = managers.Where(m => m.Salary >= FilterA.Salary);
                        }

                        if (FilterA.Salary == 0 && FilterB.Salary > 0)                                                                 // от любой до указанной
                        {
                            managers = managers.Where(m => m.Salary <= FilterB.Salary);
                        }

                        if (FilterA.Salary > 0 && FilterB.Salary > 0)                                           // от указанной до указанной
                        {
                            managers = managers.Where(m => m.Salary >= FilterA.Salary && m.Salary <= FilterB.Salary);
                        }

                    }




                    return managers.ToList();
                }

            }




        }
    }
}

