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
    public class Order
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Price { get; set; }
        public bool ByCash { get; set; }

        Status status;
        public int Distance { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }

        [Column("Branch_Id")]
        public int? BranchId { get; set; }

        [Column("Branch_Id")]
        public Branch Branch { get; set; }

        [Column("Employee_Id")]
        public int? ManagerId { get; set; }

        [Column("Employee_Id")]
        public Manager Manager { get; set; }

        [Column("Client_Id")]

        public int? ClientId { get; set; }

        [Column("Client_Id")]
        public Client Client { get; set; }


        ServiceInOrder serviceInOrder = new ServiceInOrder();
        public bool AddOrder(List<ServiceInOrder> servicesInOrder, List<Discount> discounts, Dictionary<Service, Vehicle> parevehicle, Dictionary<Service, Employee> pareemployee)
        {
            List<ServiceInOrder> listServices = new List<ServiceInOrder>();
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Orders.Add(this);
                db.SaveChanges();
                listServices = serviceInOrder.AddServiceInOrder(servicesInOrder);
                int idOrder = db.Orders.Max(x => x.Id);
                AddServiceInOrder(listServices, idOrder);
                AddServiceVehiclePare(parevehicle, idOrder);
                AddServiceEmployeePare(pareemployee, idOrder);
                AddDiscountOrder(discounts, idOrder);
                return true;
            }


        }
        public bool AddServiceInOrder(List<ServiceInOrder> servicesInOrder, int idOrder)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (ServiceInOrder item in servicesInOrder)
                {
                    
                    db.OrderServiceInOrders.Add(new OrderServiceInOrders()
                    {
                        ServiceInOrderId = item.Id,
                        OrderId = idOrder,
                    });
                }
                db.SaveChanges();
            }
            
            return true;
        }
        public bool AddDiscountOrder(List<Discount> discounts, int idOrder)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (Discount item in discounts)
                {
                   
                    db.OrderDiscounts.Add(new OrderDiscounts()
                    {
                    
                        OrderId = idOrder,
                        DiscountId = item.Id,
                    });
                }
                db.SaveChanges();
            }

            return true;
        }
 
        public bool AddServiceVehiclePare(Dictionary<Service, Vehicle> parevehicle, int idOrder)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (var item in parevehicle)
                {
                    db.Services.Attach(item.Key);
                    db.ServiceVehicles.Add(new ServiceVehicles()
                    {
                        ServiceId = item.Key.Id,
                        VehicleId = item.Value.Id,
                        OrderId = idOrder,
                    });
                }
                db.SaveChanges();
            }

            return true;
        }

        public bool AddServiceEmployeePare(Dictionary<Service, Employee> pareemployee, int idOrder)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (var item in pareemployee)
                {
                    db.ServiceEmployees.Add(new ServiceEmployees()
                    {
                        ServiceId = item.Key.Id,
                        EmployeeId = item.Value.Id,
                        OrderId = idOrder,
                    });
                }
                db.SaveChanges();
            }

            return true;
        }
        public List<ServiceInOrder> GetServcieInOrder(int IdOrder)
        {
            List<ServiceInOrder> list = new List<ServiceInOrder>();
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<OrderServiceInOrders> items = db.OrderServiceInOrders.Include(p => p.Order).Include(c => c.ServiceInOrder);

                items = items.Where(p => p.OrderId == IdOrder);
                IEnumerable<ServiceInOrder> services = db.ServicesInOrder.Include(p => p.DeliveryDriver).Include(p => p.DeliveryVehicle).Include(p => p.Driver).Include(p => p.Service).Include(p => p.Vehicle);
                foreach (var item in items)
                {
                    foreach(var obj in services)
                    {
                        if(item.ServiceInOrderId == obj.Id)
                        {
                                    list.Add(obj);
                        }
                    }
                }

               
            }
            return list;

        }
        public Dictionary<Service, Employee> GetEmployees(int OrderId)
        {
            Dictionary<Service, Employee> dict = new Dictionary<Service, Employee>();
            using (ApplicationContext db = new ApplicationContext())
            {

                IEnumerable<ServiceEmployees> items = db.ServiceEmployees.Include(p => p.Order).Include(c => c.Service).Include(n => n.Employee);
                items = items.Where(p => p.OrderId == OrderId);
                foreach (var item in items)
                {
                    dict.Add(item.Service, item.Employee);
                }
            }
            return dict;


        }
        public Dictionary<Service, Vehicle> GetVehicles(int OrderId)
        {
            Dictionary<Service, Vehicle> dict = new Dictionary<Service, Vehicle>();
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<ServiceVehicles> items = db.ServiceVehicles.Include(p => p.Order).Include(c => c.Service).Include(n => n.Vehicle);
                items = items.Where(p => p.OrderId == OrderId);
                foreach (var item in items)
                {
                    dict.Add(item.Service, item.Vehicle);
                }
            }
            return dict;


        }
        public List<Discount> GetDiscounts(int OrderId)
        {
            List<Discount> list = new List<Discount>();
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<OrderDiscounts> items = db.OrderDiscounts.Include(p => p.Order).Include(c => c.Discount);
                items = items.Where(p => p.OrderId == OrderId);
                foreach (var item in items)
                {
                    list.Add(item.Discount);
                }
            }
            return list;
        }

        public Order FindById(int z)
        {
            return OrderList.GetById(z);
        }
        public List<Order> GetAll(Order FilterA, Order FilterB)
        {

            return OrderList.GetOrders(FilterA, FilterB);
        }
    }
        public enum Status
        {
            AwaitingPayment,
            AwaitingARefund,
            Accepted,
            DeliveredTo,
            Rent,
            DeliveredBack,
            Done,
            Canceled,
            Change,
            Unknown

    }
    public static class StatusStringExtensions
    {
        public static string GetStatusString(this Status status)
        {
            switch (status)
            {
                case Status.AwaitingPayment:
                    return "Ожидает оплаты";
                case Status.AwaitingARefund:
                    return "Ожидает возврата средств";
                case Status.Accepted:
                    return "Принят";
                case Status.DeliveredTo:
                    return "Доставляется на адрес";
                case Status.Rent:
                    return "Аренда";
                case Status.DeliveredBack:
                    return "Возвращается в офис";
                case Status.Done:
                    return "Выполнен";
                case Status.Canceled:
                    return "Отменен";
                case Status.Change:
                    return "Изменяется";

                default:
                    return "Неопределенный статус";
            }
        }

        public static Status GetStatusEnum(string status)
        {
            switch (status)
            {

                case "Ожидает оплаты":
                    return Status.AwaitingPayment;
                case "Ожидает возврата средств":
                    return Status.AwaitingARefund;
                case "Принят":
                    return Status.Accepted;
                case "Доставляется на адрес":
                    return Status.DeliveredTo;
                case "Аренда":
                    return Status.Rent;
                case "Возвращается в офис":
                    return Status.DeliveredBack;
                case "Выполнен":
                    return Status.Done;
                case "Отменен":
                    return Status.Canceled;
                case "Изменяется":
                    return Status.Change;

                default:
                    return Status.Unknown;
            }
        }
    }
    public static class OrderList
        {
            public static Order GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.Orders.Find(id);
                }
            }


        public static List<Order> GetOrders(Order FilterA, Order FilterB)
        {
            //string Sorting, string AskOrDesc, int Count, int Page
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<Order> orders = db.Orders.Include(p => p.Branch).Include(c => c.Client).Include(c => c.Manager);
                if (FilterA != null || FilterB != null)
                {
                    if (FilterA.Id != 0)
                    {
                        orders = orders.Where(p => p.Id == FilterA.Id);
                    }




                }




                return orders.ToList();
            }

        }
        
        }






    
}
