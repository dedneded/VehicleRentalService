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
    class TimetableBranch
    {
        public int Id { get; set; }
        public double StartDay { get; set; }
        public double EndDay { get; set; }

        [Column("Branch_Id")]
        public int? BranchId { get; set; }

        [Column("Branch_Id")]
        public Branch Branch { get; set; }
        public DateTime RelevantFrom { get; set; }
        public DateTime RelevantUntil { get; set; }

        public bool AddTimetableBranch()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.TimetableBranches.Add(this);
                db.SaveChanges();
                return true;
            }
        }
        public bool DelTimetableBranch()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }

        public List<TimetableBranch> GetAll(Branch branch)
        {

            return TimetableBranchList.GetTimetableBranches(branch);
        }
        public List<TimetableBranch> GetAll(TimetableBranch FilterA, TimetableBranch FilterB, Branch branch)
        {

            return TimetableBranchList.GetTimetableBranches(FilterA, FilterB, branch);
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

        public static class TimetableBranchList
        {
            public static TimetableBranch GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.TimetableBranches.Find(id);
                }
            }

            public static List<TimetableBranch> GetTimetableBranches(Branch branch)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<TimetableBranch> timetables = db.TimetableBranches;
                    timetables = timetables.Where(p => p.BranchId == branch.Id);
                    return timetables.ToList();
                }
            }
            public static List<TimetableBranch> GetTimetableBranches(TimetableBranch FilterA, TimetableBranch FilterB, Branch branch)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<TimetableBranch> timetables = db.TimetableBranches;
                    timetables = timetables.Where(p => p.BranchId == branch.Id);


                    if (FilterA != null || FilterB != null)
                    {
                        
                        DateTime k = Convert.ToDateTime("01.01.0001 0:00:00");
                        if (FilterA.RelevantFrom != k && FilterA.RelevantUntil == k)                                           // от указанной до любой
                        {
                            timetables = timetables.Where(m => m.RelevantFrom >= FilterA.RelevantFrom);
                        }



                        if (FilterA.RelevantFrom == k && FilterA.RelevantUntil != k)                                                                 // от любой до указанной
                        {
                            timetables = timetables.Where(m => m.RelevantUntil <= FilterA.RelevantUntil);
                        }




                        if (FilterA.RelevantFrom != k && FilterA.RelevantUntil != k)                                           // от указанной до указанной
                        {
                            timetables = timetables.Where(m => m.RelevantFrom >= FilterA.RelevantFrom && m.RelevantUntil <= FilterA.RelevantUntil);
                        }

                    }
                    return timetables.ToList();
                }




            }

        }
            }



        }

    

