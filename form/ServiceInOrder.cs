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
    [Table("ServicesInOrder")]
    public class ServiceInOrder
    {
        public int Id { get; set; }

        [Column("ID_service")]
        public int? ServiceId { get; set; }

        [Column("ID_service")]
        public Service Service { get; set; }

        [Column("ID_driver")]
        public int? DriverId { get; set; }

        [Column("ID_driver")]
        public Driver Driver { get; set; }

        [Column("ID_vehicle")]
        public int? VehicleId { get; set; }

        [Column("ID_vehicle")]
        public Vehicle Vehicle { get; set; }

        [Column("ID_deliveryVehicle")]
        public int? DeliveryVehicleId { get; set; }

        [Column("ID_deliveryVehicle")]
        public Vehicle DeliveryVehicle { get; set; }


        [Column("ID_deliveryDriver")]
        public int? DeliveryDriverId { get; set; }

        [Column("ID_deliveryDriver")]
        public Driver DeliveryDriver { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime StartFrom { get; set; }
        public DateTime EndFrom { get; set; }
        public decimal Price { get; set; }


        public List<ServiceInOrder> AddServiceInOrder(List<ServiceInOrder> servicesInOrder)
        {
            List<ServiceInOrder> list = new List<ServiceInOrder>();
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (ServiceInOrder item in servicesInOrder)
                {
                    if (item.Vehicle != null)
                    {
                        db.Vehicles.Attach(item.Vehicle);
                    }
                    if (item.DeliveryVehicle != null)
                    {
                        db.Vehicles.Attach(item.DeliveryVehicle);
                    }
                    //if (item.DeliveryDriver != null)
                    //{
                    //    db.Drivers.Attach(item.Driver);
                    //}

                    //if (item.Driver != null)
                    //{
                    //    db.Drivers.Attach(item.Driver);
                    //}
                    db.ServicesInOrder.Add(item);
                    db.SaveChanges();
                    int id = db.ServicesInOrder.Max(x => x.Id);
                    list.Add(ServiceInOrderList.GetById(id));
                }


                return list;
            }


        }
        public ServiceInOrder FindById(int z)
        {
            return ServiceInOrderList.GetById(z);
        }
        //public List<ServiceInOrder> GetAll()
        //{

        //    return ServiceInOrderList.GetServicesInOrder();
        //}

        public ServiceInOrder FindByName(string z)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Service service = new Service();
                service = service.FindByName(z);

                return db.ServicesInOrder.Where(c => c.ServiceId == service.Id).ToList()[0];
            }
        }

    }
    public static class ServiceInOrderList
    {
        public static ServiceInOrder GetById(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                return db.ServicesInOrder.Find(id);
            }
        }
        

        //public static List<ServiceInOrder> GetServicesInOrder()
        //{
        //    //string Sorting, string AskOrDesc, int Count, int Page
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        IEnumerable<ServiceInOrder> ser = db.Orders.Include(p => p.Branch).Include(c => c.Client).Include(c => c.Manager);
                



        //        return orders.ToList();
        //    }

        //}
    }

    }
