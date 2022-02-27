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
    public class Vehicle
    {
        public int Id { get; set; }
       
        public bool IsNeedDelivery { get; set; }
        public string BrandAndModel { get; set; }
        public int YearOfIssue { get; set; }
        public string GosNum { get; set; }
        public int Mass { get; set; }
        public double AvgGas { get; set; }
        public int AvgSpeed { get; set; }
        public int ShipmentTime { get; set; }
        public decimal PricePerHour { get; set; }
        public string Comment { get; set; }

        
        public DrivingCaregories DrivingCategory { get; set; }
        
        [Column("CategoryOfVehicle_Id")]
        public int? IdVehicleCategory { get; set; }

        [Column("CategoryOfVehicle_Id")] 
        public CategoryOfVehicle CategoryOfVehicle { get; set; }
       
        [Column("Branch_Id")]
        public int? BranchId { get; set; }

        [Column("Branch_Id")]
        public Branch Branch { get; set; }
       
        public bool AddVehicle()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Vehicles.Add(this);
                db.SaveChanges();
                return true;
            }
        }
        public bool DelVehicle()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }
        public bool EditVehicle()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
               

                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;

            }
        }

        public List<Vehicle> GetAll(Vehicle FilterA, Vehicle FilterB)
        {

            return VehicleList.GetVehicles(FilterA, FilterB);
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
       
        public Vehicle FindById(int id)
        {
           return VehicleList.GetById(id);
        }
        public List<Vehicle> GetVehicleOfOrder(int OrderId)
        {
            List<int> vehicles = new List<int>();
            List<int> serviceInOrder= new List<int>();
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<OrderServiceInOrders> serviceOrder = db.OrderServiceInOrders.Include(p => p.ServiceInOrder).Include(p => p.Order);
                IEnumerable<ServiceInOrder> services = db.ServicesInOrder.Include(p => p.Service).Include(p => p.Vehicle).Include(p => p.DeliveryDriver).Include(p => p.DeliveryVehicle).Include(p => p.Driver);
                
               foreach(var item in serviceOrder)
               {

                   if(item.OrderId == OrderId) { serviceInOrder.Add(item.ServiceInOrderId); }
               }
               foreach(var item in services)
               {
                   foreach(int obj in serviceInOrder)
                   {
                       if(item.Id == obj)
                       {
                           if(item.VehicleId != null) { vehicles.Add(Convert.ToInt32(item.VehicleId));}
                           
                      
                       }
                   }

               }
                List<Vehicle> listVehicle = new List<Vehicle>();
                int i = 0;
                foreach (Vehicle obj in GetAll(null, null))
                {
                        foreach (int item in vehicles)
                        {
                            if(obj.Id == item)
                            {
                            
                                foreach(Vehicle obj2 in listVehicle)
                                {
                                    if(obj2.Id == obj.Id) { i++; }
                            
                                }
                                    if(i==0) { listVehicle.Add(obj); }
                           
                            }
                        }
                }
                
               
                return listVehicle;

            }
        }
        public List<Order> GetOrdersOfVehicle(int VehicleId)
        {
            List<int> ordersList = new List<int>();
            List<int> serviceInOrder = new List<int>();
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<Order> orders = db.Orders.Include(p => p.Client).Include(p => p.Branch).Include(p => p.Manager);
                IEnumerable<OrderServiceInOrders> serviceOrder = db.OrderServiceInOrders.Include(p => p.ServiceInOrder).Include(p => p.Order);
                IEnumerable<ServiceInOrder> services = db.ServicesInOrder.Include(p => p.Service).Include(p => p.Vehicle).Include(p => p.DeliveryDriver).Include(p => p.DeliveryVehicle).Include(p => p.Driver);

                foreach (var item in services)
                {

                    if (item.VehicleId == VehicleId || item.DeliveryVehicleId == VehicleId)
                    { serviceInOrder.Add(Convert.ToInt32(item.ServiceId)); }

                }
                foreach (var item in serviceOrder)
                {
                    foreach (int obj in serviceInOrder)
                    {
                        if (item.ServiceInOrderId == obj)
                        {
                            ordersList.Add(Convert.ToInt32(item.OrderId));


                        }
                    }

                }
                List <Order> list = new List<Order>();
                Order order = new Order();
                foreach(Order item in order.GetAll(null, null))
                {
                    foreach(int item2 in ordersList)
                    {
                        if(item.Id == item2)
                        {
                                list.Add(item);
                        }
                    }
                }
                var uniq = list.Distinct();
                return uniq.ToList();
            }
        }
        public static class VehicleList
        {
            

            public static Vehicle GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Vehicle vehicle = db.Vehicles.Find(id);
                    db.Entry(vehicle).Reference(m => m.Branch).Load();
                    db.Entry(vehicle).Reference(m => m.CategoryOfVehicle).Load();


                    return vehicle;
                }

            }

            public static List<Vehicle> GetVehicles(Vehicle FilterA, Vehicle FilterB)
            {
                
                //string Sorting, string AskOrDesc, int Count, int Page
                using (ApplicationContext db = new ApplicationContext())
                {

                    IEnumerable<Vehicle> vehicles = db.Vehicles.Include(c => c.CategoryOfVehicle).Include(p => p.Branch);
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            if (db.Vehicles.Find(FilterA.Id) != null)
                            {
                                vehicles = vehicles.Where(p => p.Id == FilterA.Id);
                            }
                            else
                            {
                                throw new Exception();
                            }
                            
                        }
                        if (FilterA.GosNum != "")
                        {
                        try
                        {
                                vehicles = vehicles.Where(c => c.GosNum == FilterA.GosNum);
                        }
                        catch
                        {
                                throw new Exception();
                        }
                           
                        }
                        if (FilterA.CategoryOfVehicle != null)
                        {
                        try
                        {
                                vehicles = vehicles.Where(n => n.IdVehicleCategory == FilterA.CategoryOfVehicle.Id);
                        }
                        catch
                        {
                                throw new Exception();
                         }
                            
                        }
                        if (FilterA.Branch != null)
                        {
                        try
                        {
                                vehicles = vehicles.Where(m => m.BranchId == FilterA.Branch.Id);
                        }
                        catch
                        {
                                throw new Exception();
                        }
                            
                        }
                        if (FilterA.IsNeedDelivery == true)
                        {
                            vehicles = vehicles.Where(m => m.IsNeedDelivery == FilterA.IsNeedDelivery);
                        }

                    }



                   
                    return vehicles.ToList();
                }

            }


        }
        

    }
}
