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
    class TimetableEmployee
    {
        public int Id { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }

        [Column("Employee_Id")]
        public int? EmployeeId { get; set; }

        [Column("Employee_Id")]
        public Employee Employee { get; set; }

        public bool AddTimetableEmployee()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.TimetableEmployees.Add(this);
                db.SaveChanges();
                return true;
            }
        }
        //public bool DelVehicle()
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        db.Entry(this).State = EntityState.Deleted;
        //        db.SaveChanges();
        //        return true;
        //    }
        //}

        public List<TimetableEmployee> GetAll(TimetableEmployee FilterA, TimetableEmployee FilterB, Driver driver)
        {

            return TimetableEmployeeList.GetTimeTables(FilterA, FilterB, driver);
        }
        public List<TimetableEmployee> GetAll(Driver driver)
        {

            return TimetableEmployeeList.GetTimeTables(driver);
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


        public static class TimetableEmployeeList
        {
            public static TimetableEmployee GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.TimetableEmployees.Find(id);
                }
            }

            public static List<TimetableEmployee> GetTimeTables(TimetableEmployee FilterA, TimetableEmployee FilterB, Driver driver)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    IEnumerable<TimetableEmployee> timetables = db.TimetableEmployees;
                    timetables = timetables.Where(p => p.EmployeeId == driver.Id);
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            timetables = timetables.Where(p => p.Id == FilterA.Id);
                        }
                      
                        DateTime k = Convert.ToDateTime("01.01.0001 0:00:00");
                            if (FilterA.StartDay != k && FilterB.StartDay == k)                                           // от указанной до любой
                            {
                                timetables = timetables.Where(m => m.StartDay >= FilterA.StartDay);
                            }
                        
                       
                       
                            if (FilterA.StartDay == k && FilterB.StartDay != k)                                                                 // от любой до указанной
                            {
                                timetables = timetables.Where(m => m.StartDay <= FilterB.StartDay);
                            }
                        
                       
                        

                        if (FilterA.StartDay != k && FilterB.StartDay != k)                                           // от указанной до указанной
                        {
                            timetables = timetables.Where(m => m.StartDay >= FilterA.StartDay && m.StartDay <= FilterB.StartDay);
                        }

                    }
                    return timetables.ToList();
                }


               

            }
            public static List<TimetableEmployee> GetTimeTables(Driver driver)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<TimetableEmployee> timetables = db.TimetableEmployees;
                    timetables = timetables.Where(p => p.EmployeeId == driver.Id);
                    return timetables.ToList();
                    
                }
           
            }

        }
    }
}
