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
    public class Client : Person
    {
        public string Comment { get; set; }

        public bool AddClient()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Clients.Add(this);
                db.SaveChanges();
                return true;
            }
        }
        public bool DelClient()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }
        public List<Order> GetOrderOfClient()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<Order> items = db.Orders.Include(p => p.Branch).Include(c => c.Client).Include(c => c.Manager);
                items = items.Where(p => p.ClientId == this.Id);
                
                return items.ToList();
            }

        }
        public int GetClientOrders()
        {

            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<Order> items = db.Orders.Include(p => p.Branch).Include(c => c.Client).Include(c => c.Manager);
                items = items.Where(p => p.ClientId == this.Id);

                return items.Count();

            }

        }
        public Dictionary<int, int> GetClientsOrders()
        {

            
            Dictionary<int, int> quantityOrders = new Dictionary<int, int>();
            using (ApplicationContext db = new ApplicationContext())
            {
                IEnumerable<Client> clients = db.Clients;
                clients = clients.ToList();
                foreach (Client item in clients.ToList())
                {
                   
                        IEnumerable<Order> items = db.Orders.Include(p => p.Branch).Include(c => c.Client).Include(c => c.Manager);
                        items = items.Where(p => p.ClientId == item.Id);
                        quantityOrders.Add(item.Id, items.Count());

                    
                }
            }
               
            quantityOrders.OrderBy(pair => pair.Value);
            return quantityOrders;
        }
        public List<Client> GetNumberOfOrders(int From, int To)
        {
            Dictionary<int, int> quantityOrders = GetClientsOrders();
            Client obj = new Client();
            List<Client> clientsId = new List<Client>();
            if (From != 0 && To == 0)
            {
                foreach (var item in quantityOrders)
                {
                    if (From <= item.Value)
                    {
                        clientsId.Add(obj.FindById(item.Key));
                    }
                }
            }
            if (From == 0 && To != 0)
            {
                foreach (var item in quantityOrders)
                {
                    if (To >= item.Value)
                    {
                        clientsId.Add(obj.FindById(item.Key));
                    }
                }
            }
            if (From != 0 && To != 0)
            {
                foreach (var item in quantityOrders)
                {
                    if (From <= item.Value && To >= item.Value)
                    {
                        clientsId.Add(obj.FindById(item.Key));
                    }
                }
            }
            return clientsId;


        }
        public List<Client> GetAll(Client FilterA, Client FilterB, int From, int To)
        {

            return ClientList.GetClients(FilterA, FilterB, From, To);
        }
        public Client FindById(int s)
        {
            return ClientList.GetById(s);
        }
        public Client FindByFio(string Fio)
        {
            return ClientList.GetByFio(Fio);
        }
        public bool EditClient()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Entry(this).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
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

        public static class ClientList
        {
            public static Client GetById(int id)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.Clients.Find(id);
                }
            }
            public static Client GetByFio(string Fio)
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    return db.Clients.Find(Fio);
                }
            }

            public static List<Client> GetClients(Client FilterA, Client FilterB, int From, int To)
            {
                
                //string Sorting, string AskOrDesc, int Count, int Page
                using (ApplicationContext db = new ApplicationContext())
                {
                    IEnumerable<Client> clients;
                    Client client =  new Client();
                    if(From == 0 && To ==0)
                    {
                        clients = db.Clients;
                    }
                    else
                    {
                        clients = client.GetNumberOfOrders(From, To);
                    }
                   
                   
                    
                    if (FilterA != null || FilterB != null)
                    {
                        if (FilterA.Id != 0)
                        {
                            if(db.Clients.Find(FilterA.Id) != null)
                            {
                                clients = clients.Where(p => p.Id == FilterA.Id);
                            }
                            else
                            {
                                throw new Exception();

                            }

                        }
                        if (FilterA.Fio != null)
                        {
                        try
                        {
                                clients = clients.Where(c => c.Fio.ToUpper().Contains(FilterA.Fio.ToUpper()));
                        }
                                
                        catch
                        {
                                throw new Exception();
                        }
                       
                            
                        }
                        if (FilterA.Phone != null)
                        {
                           try
                           {
                                clients = clients.Where(n => n.Phone.Contains(FilterA.Phone));
                           }
                                
                            catch
                            {
                                throw new Exception();
                            }
                           
                           
                        }
                        
                       


                    }
                   
                    return clients.ToList();
                }
            }



        }
    }
}
